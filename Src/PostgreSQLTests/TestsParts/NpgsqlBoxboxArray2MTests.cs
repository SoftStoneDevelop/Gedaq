

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7951538829446007d,right: 0.37875833888420374d,bottom: 0.5469965672495647d,left: 0.26831522562758636d),

new NpgsqlTypes.NpgsqlBox(top: 0.797709761494004d,right: 0.9558906005654173d,bottom: 0.524343934458864d,left: 0.4779055666137423d),

new NpgsqlTypes.NpgsqlBox(top: 0.9384599543654442d,right: 0.3708411218262394d,bottom: 0.822532488328648d,left: 0.034381389047115074d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6916154065739516d,right: 0.7544651639963986d,bottom: 0.17042674052884155d,left: 0.49866169943353067d),

new NpgsqlTypes.NpgsqlBox(top: 0.9467389183418836d,right: 0.5634384580484916d,bottom: 0.8632924567433088d,left: 0.19646221469217695d),

new NpgsqlTypes.NpgsqlBox(top: 0.4970990692446452d,right: 0.6143488545491687d,bottom: 0.21126183670431764d,left: 0.4869912489842786d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9491389455967613d,right: 0.7219307414532897d,bottom: 0.4377590204439581d,left: 0.11026388328575032d),

new NpgsqlTypes.NpgsqlBox(top: 0.661058362907773d,right: 0.24239034421331773d,bottom: 0.40720580014265995d,left: 0.20212392678401014d),

new NpgsqlTypes.NpgsqlBox(top: 0.9618469584085542d,right: 0.8288243061116072d,bottom: 0.16682133788090248d,left: 0.010935802208097534d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8450480219094523d,right: 0.17267266293997197d,bottom: 0.8372489924155797d,left: 0.1690778403128742d),

new NpgsqlTypes.NpgsqlBox(top: 0.8470696880356342d,right: 0.5410067872702115d,bottom: 0.030132299248245786d,left: 0.19260838335751496d),

new NpgsqlTypes.NpgsqlBox(top: 0.4569493268157847d,right: 0.614782012824475d,bottom: 0.40496235288972804d,left: 0.5905244750304008d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6837136302616476d,right: 0.2586947775548599d,bottom: 0.5759708742942516d,left: 0.16590596710464411d),

new NpgsqlTypes.NpgsqlBox(top: 0.4611621894465753d,right: 0.5457967943120671d,bottom: 0.18613172535555966d,left: 0.5143327584464726d),

new NpgsqlTypes.NpgsqlBox(top: 0.9271377280869039d,right: 0.20500896050560657d,bottom: 0.6432004617398246d,left: 0.07869271356118601d),

new NpgsqlTypes.NpgsqlBox(top: 0.8578955980491676d,right: 0.38147522010887613d,bottom: 0.07287003271434311d,left: 0.2999827123639155d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.125946073830972d,right: 0.4269237931264117d,bottom: 0.07547777011313306d,left: 0.2064314992471925d),

new NpgsqlTypes.NpgsqlBox(top: 0.5941643849862186d,right: 0.948599652667648d,bottom: 0.04441627577319718d,left: 0.22005903820052952d),

new NpgsqlTypes.NpgsqlBox(top: 0.922198112677531d,right: 0.5295100585401207d,bottom: 0.7717561004854302d,left: 0.2733044731274594d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6366150232205462d,right: 0.7142949892587404d,bottom: 0.2639864177729898d,left: 0.07531094905519753d),

new NpgsqlTypes.NpgsqlBox(top: 0.9885851771098413d,right: 0.1889563536486123d,bottom: 0.5277649232641148d,left: 0.1310884417489233d),

new NpgsqlTypes.NpgsqlBox(top: 0.7626608469671133d,right: 0.9628197947504604d,bottom: 0.02004638150461635d,left: 0.20850483750526827d),

new NpgsqlTypes.NpgsqlBox(top: 0.4309622549389194d,right: 0.6578552613424822d,bottom: 0.40390973983049316d,left: 0.5547714730152741d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7304571838408176d,right: 0.5841170711425759d,bottom: 0.007060579674739609d,left: 0.31755595020586147d),

new NpgsqlTypes.NpgsqlBox(top: 0.9198000297822904d,right: 0.723432913676513d,bottom: 0.3006816897309367d,left: 0.6215417074440458d),

new NpgsqlTypes.NpgsqlBox(top: 0.6364852853619704d,right: 0.9745804705892802d,bottom: 0.3500505534544468d,left: 0.6169261838653756d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42439124628749014d,right: 0.8649568499721965d,bottom: 0.3815662154226611d,left: 0.8171919447422117d),

new NpgsqlTypes.NpgsqlBox(top: 0.8755009302870332d,right: 0.9209859615582363d,bottom: 0.06727041173029014d,left: 0.1252386202510073d),

new NpgsqlTypes.NpgsqlBox(top: 0.2848481163771518d,right: 0.8259553284753661d,bottom: 0.07017876187433725d,left: 0.743724242847765d),

new NpgsqlTypes.NpgsqlBox(top: 0.9229864460251888d,right: 0.7738148997131791d,bottom: 0.3212725340320107d,left: 0.13578390094124404d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9263049530835731d,right: 0.9338777991389423d,bottom: 0.35045448065049256d,left: 0.1348946313538767d),

new NpgsqlTypes.NpgsqlBox(top: 0.9811382327524075d,right: 0.4295448667178512d,bottom: 0.9111891867066501d,left: 0.1137988192199334d),

new NpgsqlTypes.NpgsqlBox(top: 0.9391570780730747d,right: 0.8188335598500394d,bottom: 0.7389673587278971d,left: 0.24134522297902972d),

new NpgsqlTypes.NpgsqlBox(top: 0.7904126054881943d,right: 0.7628867660337864d,bottom: 0.111831612328949d,left: 0.755763766089623d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6395140626505483d,right: 0.8983193018167013d,bottom: 0.2034730196037795d,left: 0.1513028400248836d),

new NpgsqlTypes.NpgsqlBox(top: 0.40152574723719614d,right: 0.7455720113879627d,bottom: 0.04974408258182217d,left: 0.6141952341218506d),

new NpgsqlTypes.NpgsqlBox(top: 0.590337893303519d,right: 0.33917457645195936d,bottom: 0.3608743745872628d,left: 0.10015338549405084d),

new NpgsqlTypes.NpgsqlBox(top: 0.3757486024403529d,right: 0.41981112691832934d,bottom: 0.30061336236740355d,left: 0.364855449334028d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7239384606112316d,right: 0.2840706030626704d,bottom: 0.6481844093905595d,left: 0.17151970915567005d),

new NpgsqlTypes.NpgsqlBox(top: 0.6906829842314933d,right: 0.8289492891655795d,bottom: 0.4325329677900658d,left: 0.15369983787047437d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746432251793817d,right: 0.8663941155557369d,bottom: 0.5827664186107221d,left: 0.6395663372380254d),

new NpgsqlTypes.NpgsqlBox(top: 0.5343788772869331d,right: 0.532242461303834d,bottom: 0.041302933178211654d,left: 0.09421008062311953d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39012491202160215d,right: 0.9979954740731516d,bottom: 0.1207533329344227d,left: 0.6714303930858605d),

new NpgsqlTypes.NpgsqlBox(top: 0.9814969599620686d,right: 0.4235872952386375d,bottom: 0.7921960670994832d,left: 0.41502004280582394d),

new NpgsqlTypes.NpgsqlBox(top: 0.8092771900995245d,right: 0.10122755864136623d,bottom: 0.6229808425260175d,left: 0.03408567496631121d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8486881973838204d,right: 0.261733871682576d,bottom: 0.14063987283150248d,left: 0.1640391145487956d),

new NpgsqlTypes.NpgsqlBox(top: 0.7975653758791643d,right: 0.7072733460079623d,bottom: 0.327036647061798d,left: 0.043181044514534195d),

new NpgsqlTypes.NpgsqlBox(top: 0.43549272646128623d,right: 0.4844019571855014d,bottom: 0.28440651695247665d,left: 0.21097102121383549d),

new NpgsqlTypes.NpgsqlBox(top: 0.696143563196122d,right: 0.2617405610291095d,bottom: 0.5521666220357074d,left: 0.008024027712383641d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8260070429599596d,right: 0.19606270253367397d,bottom: 0.804090536739806d,left: 0.09455480574603203d),

new NpgsqlTypes.NpgsqlBox(top: 0.3303758531551494d,right: 0.6860832257068055d,bottom: 0.08858557438046133d,left: 0.5810754934873851d),

new NpgsqlTypes.NpgsqlBox(top: 0.5451873698182753d,right: 0.7418241454078262d,bottom: 0.31047459960639545d,left: 0.507307710392632d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4351768893111244d,right: 0.8963602150848137d,bottom: 0.08410749934112771d,left: 0.3799433966067004d),

new NpgsqlTypes.NpgsqlBox(top: 0.23937908381188133d,right: 0.7914093099599392d,bottom: 0.1535338754272707d,left: 0.46785571276958193d),

new NpgsqlTypes.NpgsqlBox(top: 0.8209620101597762d,right: 0.7895160964308933d,bottom: 0.03670968849611389d,left: 0.03902687652182879d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6438656687839048d,right: 0.5294211858552222d,bottom: 0.49337466432577526d,left: 0.4591065263283811d),

new NpgsqlTypes.NpgsqlBox(top: 0.25191066608286816d,right: 0.8157385944514355d,bottom: 0.15613777235085602d,left: 0.7118746893042743d),

new NpgsqlTypes.NpgsqlBox(top: 0.8611474034783644d,right: 0.6622949189579682d,bottom: 0.7475782092648826d,left: 0.07099304993324773d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8790172082293859d,right: 0.3680827689405224d,bottom: 0.677965128236491d,left: 0.2893191456232347d),

new NpgsqlTypes.NpgsqlBox(top: 0.4850112522770136d,right: 0.8921068589033339d,bottom: 0.40516687646029115d,left: 0.12328712173655798d),

new NpgsqlTypes.NpgsqlBox(top: 0.9811717982955162d,right: 0.7824341416109705d,bottom: 0.4754083632934889d,left: 0.5630542413380418d),

new NpgsqlTypes.NpgsqlBox(top: 0.3313163307099316d,right: 0.7728092405472481d,bottom: 0.19796622194378555d,left: 0.3054974902295219d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9360399175244196d,right: 0.3768059506300002d,bottom: 0.32784311340192396d,left: 0.3766432984983994d),

new NpgsqlTypes.NpgsqlBox(top: 0.32158453297297906d,right: 0.5327708275535874d,bottom: 0.00628109014379874d,left: 0.19069422926554302d),

new NpgsqlTypes.NpgsqlBox(top: 0.4420416419668446d,right: 0.9246704352866804d,bottom: 0.26586195622646236d,left: 0.2731377790333922d),

new NpgsqlTypes.NpgsqlBox(top: 0.9827670793564055d,right: 0.47163903169695587d,bottom: 0.7424055574598691d,left: 0.4635893190019831d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6679627946517958d,right: 0.9056249530172062d,bottom: 0.6218639974298372d,left: 0.7567792681324027d),

new NpgsqlTypes.NpgsqlBox(top: 0.1391031937885462d,right: 0.9439653566584514d,bottom: 0.1190180272950635d,left: 0.08081694683867269d),

new NpgsqlTypes.NpgsqlBox(top: 0.8469055282676795d,right: 0.8599181689616108d,bottom: 0.47661629623484036d,left: 0.4837624021166166d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9707077572393114d,right: 0.6452285842799976d,bottom: 0.21302225122880813d,left: 0.2643897320995052d),

new NpgsqlTypes.NpgsqlBox(top: 0.848979977698144d,right: 0.7749873448577966d,bottom: 0.5893644934417537d,left: 0.334890376221877d),

new NpgsqlTypes.NpgsqlBox(top: 0.6566950173875937d,right: 0.7084334562388507d,bottom: 0.3890372458242024d,left: 0.3743203445714933d),

new NpgsqlTypes.NpgsqlBox(top: 0.8507800566430995d,right: 0.6870565563824418d,bottom: 0.6743219729378053d,left: 0.1713393184797113d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9119396684955818d,right: 0.9757399128669897d,bottom: 0.0622094428603408d,left: 0.8492440192951889d),

new NpgsqlTypes.NpgsqlBox(top: 0.910639269818694d,right: 0.6439440588598379d,bottom: 0.874277053222651d,left: 0.16133821454750485d),

new NpgsqlTypes.NpgsqlBox(top: 0.9612892991791091d,right: 0.7073719141140435d,bottom: 0.04338069891471008d,left: 0.13342645810167597d),

new NpgsqlTypes.NpgsqlBox(top: 0.06083066294764439d,right: 0.36607164293626115d,bottom: 0.044457260761144424d,left: 0.028004638800555925d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6683373729453918d,right: 0.8149684738482805d,bottom: 0.1321707062820041d,left: 0.27830038010238833d),

new NpgsqlTypes.NpgsqlBox(top: 0.6977901291818053d,right: 0.8924484892545735d,bottom: 0.2725230603528366d,left: 0.10366122362701713d),

new NpgsqlTypes.NpgsqlBox(top: 0.5446317042652679d,right: 0.9450721795274531d,bottom: 0.47143826690291935d,left: 0.5423874327063777d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5110956940748729d,right: 0.9136642787602723d,bottom: 0.43614218863105036d,left: 0.7634406233094101d),

new NpgsqlTypes.NpgsqlBox(top: 0.9317511188102774d,right: 0.9920254989873024d,bottom: 0.2883741077653261d,left: 0.30632492464852057d),

new NpgsqlTypes.NpgsqlBox(top: 0.7513286697039679d,right: 0.28290907492188155d,bottom: 0.18957080904516954d,left: 0.21116204574821107d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6445288726181941d,right: 0.8457164298758796d,bottom: 0.0714161519843215d,left: 0.3688891569850795d),

new NpgsqlTypes.NpgsqlBox(top: 0.8846295406702093d,right: 0.6178584723304295d,bottom: 0.6271080105814419d,left: 0.4566087627197981d),

new NpgsqlTypes.NpgsqlBox(top: 0.33372414038220066d,right: 0.7996322971309062d,bottom: 0.32343795851556345d,left: 0.6884727162820993d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.885486836368654d,right: 0.6914098761772665d,bottom: 0.4038744302328373d,left: 0.3553165511044888d),

new NpgsqlTypes.NpgsqlBox(top: 0.9102272992319367d,right: 0.6803585085426469d,bottom: 0.093119047337348d,left: 0.07736077703144617d),

new NpgsqlTypes.NpgsqlBox(top: 0.9204594307259663d,right: 0.990257534295085d,bottom: 0.8745528129461034d,left: 0.16884196453440348d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6322814347460087d,right: 0.9143829322072099d,bottom: 0.41449638851385195d,left: 0.7269405053282142d),

new NpgsqlTypes.NpgsqlBox(top: 0.7875525788203914d,right: 0.732157881286484d,bottom: 0.03145678949868247d,left: 0.06437857207619924d),

new NpgsqlTypes.NpgsqlBox(top: 0.5019907076134515d,right: 0.7866239002525997d,bottom: 0.0335345410716974d,left: 0.772723228321131d),

new NpgsqlTypes.NpgsqlBox(top: 0.6719466834611931d,right: 0.6785170771196266d,bottom: 0.29299963926431016d,left: 0.021623226823582087d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6322760915376049d,right: 0.7217703599854294d,bottom: 0.41874404362060336d,left: 0.3133166408430743d),

new NpgsqlTypes.NpgsqlBox(top: 0.7507533160778732d,right: 0.7175811280212656d,bottom: 0.3569813696617913d,left: 0.37089052148035684d),

new NpgsqlTypes.NpgsqlBox(top: 0.9594342033361183d,right: 0.8421022237158232d,bottom: 0.9591097979581653d,left: 0.01191895632264306d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8548521262526232d,right: 0.883514848898736d,bottom: 0.8504060140345238d,left: 0.3878703553098428d),

new NpgsqlTypes.NpgsqlBox(top: 0.8859008135399608d,right: 0.7470321426000553d,bottom: 0.7658674748158264d,left: 0.6918051562978277d),

new NpgsqlTypes.NpgsqlBox(top: 0.7258494788343149d,right: 0.9693264455823647d,bottom: 0.38101612969221377d,left: 0.38847531305208005d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.650212266551336d,right: 0.8011510843271014d,bottom: 0.5916519966463795d,left: 0.7386643736246168d),

new NpgsqlTypes.NpgsqlBox(top: 0.9545990863167403d,right: 0.9006504410974967d,bottom: 0.031055865070832245d,left: 0.13407103903327122d),

new NpgsqlTypes.NpgsqlBox(top: 0.5615817833448815d,right: 0.9391592451642937d,bottom: 0.1302244844935957d,left: 0.07733274403459334d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.18552065422862107d,right: 0.792541459285867d,bottom: 0.13134258467379312d,left: 0.3101360589888369d),

new NpgsqlTypes.NpgsqlBox(top: 0.7173476549154861d,right: 0.8978698490716325d,bottom: 0.21423648676525853d,left: 0.5211183693616581d),

new NpgsqlTypes.NpgsqlBox(top: 0.8267111045521918d,right: 0.24795503275509845d,bottom: 0.13893348669836614d,left: 0.06277559574599145d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42405607428706615d,right: 0.39904187650197176d,bottom: 0.2918383139845452d,left: 0.37864642489018085d),

new NpgsqlTypes.NpgsqlBox(top: 0.1945286970666359d,right: 0.5543917254318075d,bottom: 0.07447766887011698d,left: 0.03888870396470745d),

new NpgsqlTypes.NpgsqlBox(top: 0.9367360396483327d,right: 0.93648020352018d,bottom: 0.7871806047923767d,left: 0.7502453585174036d),

new NpgsqlTypes.NpgsqlBox(top: 0.9576534093348043d,right: 0.6661647506472872d,bottom: 0.3988243283781643d,left: 0.10908282916318779d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8500009986161554d,right: 0.4516133116740214d,bottom: 0.49696748252395917d,left: 0.3883749187093376d),

new NpgsqlTypes.NpgsqlBox(top: 0.9218572887691359d,right: 0.11251269439230926d,bottom: 0.4575401304979244d,left: 0.08015287832233953d),

new NpgsqlTypes.NpgsqlBox(top: 0.9100759560835666d,right: 0.9807255629680723d,bottom: 0.4923966514741598d,left: 0.26804276835953356d),

new NpgsqlTypes.NpgsqlBox(top: 0.964024820557965d,right: 0.2958892030822696d,bottom: 0.682789281385758d,left: 0.005679110044913616d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.604393671457551d,right: 0.5579658438579006d,bottom: 0.5628770116708862d,left: 0.047511029977094665d),

new NpgsqlTypes.NpgsqlBox(top: 0.9846631323817292d,right: 0.7876009323096486d,bottom: 0.5736614092189718d,left: 0.5366393587001815d),

new NpgsqlTypes.NpgsqlBox(top: 0.608259574679018d,right: 0.5423053201143306d,bottom: 0.24031954813867207d,left: 0.09322619496350937d),

new NpgsqlTypes.NpgsqlBox(top: 0.5933779498835532d,right: 0.6732039065736408d,bottom: 0.5179339540654796d,left: 0.5946994345353045d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7550590571853002d,right: 0.5752856481525598d,bottom: 0.2332556100881037d,left: 0.03310650923260994d),

new NpgsqlTypes.NpgsqlBox(top: 0.9041197043029833d,right: 0.9782050485124137d,bottom: 0.43123390025334796d,left: 0.9513560735967034d),

new NpgsqlTypes.NpgsqlBox(top: 0.786918262079907d,right: 0.2950483814343531d,bottom: 0.2525936702697392d,left: 0.23294834952083443d),

new NpgsqlTypes.NpgsqlBox(top: 0.9551685169161578d,right: 0.8705573528339111d,bottom: 0.9163470635768315d,left: 0.10171436164510272d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7109707781768554d,right: 0.5809492242689606d,bottom: 0.6769214802090846d,left: 0.09850217767381353d),

new NpgsqlTypes.NpgsqlBox(top: 0.547290781990856d,right: 0.6736143697897888d,bottom: 0.01887973413638877d,left: 0.25624849072231304d),

new NpgsqlTypes.NpgsqlBox(top: 0.23381761849965443d,right: 0.7919928715865321d,bottom: 0.050799146467265466d,left: 0.5239464761235172d),

new NpgsqlTypes.NpgsqlBox(top: 0.9222209638685317d,right: 0.9193267535613424d,bottom: 0.6798045024953623d,left: 0.3859907362786481d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.479303115964858d,right: 0.6723355430124016d,bottom: 0.35883798181839754d,left: 0.3351626612508173d),

new NpgsqlTypes.NpgsqlBox(top: 0.8272510616398254d,right: 0.7047897533963051d,bottom: 0.3591977221573526d,left: 0.07612623892621762d),

new NpgsqlTypes.NpgsqlBox(top: 0.5086478436559252d,right: 0.9466929051534463d,bottom: 0.029529502659606965d,left: 0.20880062187819282d),

new NpgsqlTypes.NpgsqlBox(top: 0.8155192090623402d,right: 0.8734457864243941d,bottom: 0.4220525715801453d,left: 0.32457552646915444d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3530725976688458d,right: 0.9891041154306713d,bottom: 0.3427112074306726d,left: 0.029982226058823946d),

new NpgsqlTypes.NpgsqlBox(top: 0.7906128022065317d,right: 0.0577698882570884d,bottom: 0.03320961931932509d,left: 0.026456986742829702d),

new NpgsqlTypes.NpgsqlBox(top: 0.14350742513468984d,right: 0.5986875076480874d,bottom: 0.09523805500665028d,left: 0.1215126555189946d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4344688813849452d,right: 0.8886789894075939d,bottom: 0.341262415163159d,left: 0.2662808964286896d),

new NpgsqlTypes.NpgsqlBox(top: 0.9844207219598907d,right: 0.6021103924928016d,bottom: 0.7594329947110381d,left: 0.0138605907609185d),

new NpgsqlTypes.NpgsqlBox(top: 0.7619106599236568d,right: 0.9833259351270207d,bottom: 0.4849247006447155d,left: 0.48869346707562433d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.781133736973928d,right: 0.6256334568834678d,bottom: 0.47685326464945d,left: 0.1856280921929956d),

new NpgsqlTypes.NpgsqlBox(top: 0.5634649608840296d,right: 0.18665729651388618d,bottom: 0.24689123099961885d,left: 0.12605432406929518d),

new NpgsqlTypes.NpgsqlBox(top: 0.9874738420078242d,right: 0.8362375569541077d,bottom: 0.9078068002622195d,left: 0.3086597189379836d),

new NpgsqlTypes.NpgsqlBox(top: 0.68315232258117d,right: 0.8801334796678978d,bottom: 0.265304336256281d,left: 0.7112053371562581d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9559440575858332d,right: 0.9792778892026739d,bottom: 0.6941301111111788d,left: 0.835919626195809d),

new NpgsqlTypes.NpgsqlBox(top: 0.960993636139839d,right: 0.7993996533698425d,bottom: 0.47342971131633405d,left: 0.01829200201678649d),

new NpgsqlTypes.NpgsqlBox(top: 0.9914974361297403d,right: 0.7349324698038227d,bottom: 0.36653109264080463d,left: 0.6096302807526346d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.18210975723586287d,right: 0.8685780114668269d,bottom: 0.18105835559012118d,left: 0.12162059959800864d),

new NpgsqlTypes.NpgsqlBox(top: 0.6652594736634506d,right: 0.5235474714468615d,bottom: 0.38111993205785133d,left: 0.3858366024767038d),

new NpgsqlTypes.NpgsqlBox(top: 0.5652904432952032d,right: 0.4600219841068123d,bottom: 0.34916384520638166d,left: 0.03855661977399183d),

new NpgsqlTypes.NpgsqlBox(top: 0.9413504036451477d,right: 0.853959195712727d,bottom: 0.5362003942018064d,left: 0.25497970812527726d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8157202760407966d,right: 0.19670302916695925d,bottom: 0.6815865890415902d,left: 0.021070937477271512d),

new NpgsqlTypes.NpgsqlBox(top: 0.6879578262399946d,right: 0.4207941417220683d,bottom: 0.4944390363815492d,left: 0.23740898499630692d),

new NpgsqlTypes.NpgsqlBox(top: 0.22819402480608775d,right: 0.7612964218499687d,bottom: 0.18725191402881558d,left: 0.4720493007793096d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9691062318683061d,right: 0.8534675567316502d,bottom: 0.6451115054926899d,left: 0.25478235845787345d),

new NpgsqlTypes.NpgsqlBox(top: 0.5305244034692682d,right: 0.7955273548488294d,bottom: 0.407657989812377d,left: 0.2177650012821889d),

new NpgsqlTypes.NpgsqlBox(top: 0.20493307936091254d,right: 0.7978490957567089d,bottom: 0.18930903734833415d,left: 0.4756570265807366d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7821835885375906d,right: 0.8227858596018983d,bottom: 0.4194984210355235d,left: 0.5678080661851486d),

new NpgsqlTypes.NpgsqlBox(top: 0.44346034959651637d,right: 0.6420782915878875d,bottom: 0.10939392404508474d,left: 0.1598567692914754d),

new NpgsqlTypes.NpgsqlBox(top: 0.3214200214219777d,right: 0.8542583032132891d,bottom: 0.043537293943437194d,left: 0.5145308672517436d),

new NpgsqlTypes.NpgsqlBox(top: 0.9286298835403614d,right: 0.5781664165178565d,bottom: 0.27065981281728313d,left: 0.22450761251444384d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8093638674786342d,right: 0.702123336098944d,bottom: 0.5333445565309961d,left: 0.2827260545704554d),

new NpgsqlTypes.NpgsqlBox(top: 0.037804988800076544d,right: 0.31865301451795935d,bottom: 0.019481194955541792d,left: 0.14259858342769283d),

new NpgsqlTypes.NpgsqlBox(top: 0.31205076546251476d,right: 0.9832999542924359d,bottom: 0.11519343973118157d,left: 0.2253880912538655d),

new NpgsqlTypes.NpgsqlBox(top: 0.720439689694523d,right: 0.9385746031729765d,bottom: 0.262206453092773d,left: 0.6087862368769906d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5274919617635194d,right: 0.9167675617111194d,bottom: 0.338072444865711d,left: 0.623752264046825d),

new NpgsqlTypes.NpgsqlBox(top: 0.6692431814233627d,right: 0.8738346799176894d,bottom: 0.6349094504129617d,left: 0.7669538749585364d),

new NpgsqlTypes.NpgsqlBox(top: 0.6487607481345403d,right: 0.6738682119735153d,bottom: 0.09565007602752251d,left: 0.6117719783711066d),

new NpgsqlTypes.NpgsqlBox(top: 0.7892338816526421d,right: 0.94860291429661d,bottom: 0.005737667828555448d,left: 0.40821394404225453d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9633606571713225d,right: 0.34445361981915124d,bottom: 0.7607638696055128d,left: 0.18467872649543216d),

new NpgsqlTypes.NpgsqlBox(top: 0.9539020935610274d,right: 0.43956933144449273d,bottom: 0.6121951878277869d,left: 0.23777759274384214d),

new NpgsqlTypes.NpgsqlBox(top: 0.1075688169989607d,right: 0.3438281058101753d,bottom: 0.02784539016990406d,left: 0.11440774857621727d),

new NpgsqlTypes.NpgsqlBox(top: 0.8892981013964607d,right: 0.44945026851353453d,bottom: 0.6521726428267248d,left: 0.3854363432330835d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4509889924082051d,right: 0.379256796965714d,bottom: 0.23790267742711768d,left: 0.2532978437281005d),

new NpgsqlTypes.NpgsqlBox(top: 0.37464703977304736d,right: 0.6877063634005107d,bottom: 0.09383332983035786d,left: 0.184259197348983d),

new NpgsqlTypes.NpgsqlBox(top: 0.8196849479172673d,right: 0.6777295847805151d,bottom: 0.6519283955957865d,left: 0.6193776364660276d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6936501035415926d,right: 0.9079296327697228d,bottom: 0.6540230733182847d,left: 0.31360195688225856d),

new NpgsqlTypes.NpgsqlBox(top: 0.6104657943240647d,right: 0.20211271681043397d,bottom: 0.6094330521825176d,left: 0.0029438138820815363d),

new NpgsqlTypes.NpgsqlBox(top: 0.9048787042720194d,right: 0.8055639412986635d,bottom: 0.3715273056568278d,left: 0.679263654981229d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7629139574449109d,right: 0.17184071633231235d,bottom: 0.5981173527331013d,left: 0.04135012319835496d),

new NpgsqlTypes.NpgsqlBox(top: 0.40511420360091066d,right: 0.5578600309227265d,bottom: 0.188196873738809d,left: 0.19183814423761592d),

new NpgsqlTypes.NpgsqlBox(top: 0.9986180306449222d,right: 0.5492443883010054d,bottom: 0.9375527697951991d,left: 0.4683025483224733d),

new NpgsqlTypes.NpgsqlBox(top: 0.5832728440492032d,right: 0.8376754804264025d,bottom: 0.09710782784400906d,left: 0.2932294657827864d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9393723327649854d,right: 0.5716015545239146d,bottom: 0.19078198744421337d,left: 0.1611771296676986d),

new NpgsqlTypes.NpgsqlBox(top: 0.5873580726288701d,right: 0.6040212860510734d,bottom: 0.19375359722600194d,left: 0.4465369758593031d),

new NpgsqlTypes.NpgsqlBox(top: 0.6762680185045475d,right: 0.5162892060278684d,bottom: 0.18786044187822193d,left: 0.31384331410737987d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8806827475490245d,right: 0.9649413347579068d,bottom: 0.7269970594682346d,left: 0.9336997902543028d),

new NpgsqlTypes.NpgsqlBox(top: 0.6515225795486167d,right: 0.7127723693406882d,bottom: 0.34253970996180827d,left: 0.1526267981016044d),

new NpgsqlTypes.NpgsqlBox(top: 0.6977215876792955d,right: 0.3441146899017822d,bottom: 0.08816317919747851d,left: 0.004376248695521223d),

new NpgsqlTypes.NpgsqlBox(top: 0.40359100425501326d,right: 0.9244732006517751d,bottom: 0.05485940120913846d,left: 0.3654954723790389d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3637688878721095d,right: 0.734673251398994d,bottom: 0.09537646895437335d,left: 0.6487366955203057d),

new NpgsqlTypes.NpgsqlBox(top: 0.9012620841477057d,right: 0.5558978863988282d,bottom: 0.17928720321813918d,left: 0.17157482551745318d),

new NpgsqlTypes.NpgsqlBox(top: 0.12050048748349307d,right: 0.9141608026613559d,bottom: 0.0795055879227019d,left: 0.2486346509413936d),

new NpgsqlTypes.NpgsqlBox(top: 0.856309956173984d,right: 0.7781588943667536d,bottom: 0.8479993178141916d,left: 0.06085138789585065d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8793227282215931d,right: 0.9168005714380024d,bottom: 0.4409956441279165d,left: 0.650009723188363d),

new NpgsqlTypes.NpgsqlBox(top: 0.75088121807016d,right: 0.692072821497802d,bottom: 0.4249604704109885d,left: 0.4487584394575479d),

new NpgsqlTypes.NpgsqlBox(top: 0.9605576239743594d,right: 0.8831673232370951d,bottom: 0.2580685625917021d,left: 0.4152036279745118d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8088152620156057d,right: 0.23903636553450558d,bottom: 0.3003052298604386d,left: 0.14534231136821385d),

new NpgsqlTypes.NpgsqlBox(top: 0.6040845935407301d,right: 0.6204897640433564d,bottom: 0.4237543072773824d,left: 0.06653824417519538d),

new NpgsqlTypes.NpgsqlBox(top: 0.7637845350244084d,right: 0.8868886133968109d,bottom: 0.35932503056856435d,left: 0.4617556916506582d),

new NpgsqlTypes.NpgsqlBox(top: 0.8244795446683403d,right: 0.8140695086135677d,bottom: 0.3227817318371857d,left: 0.7490829607931004d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3781117358882945d,right: 0.5926258248955375d,bottom: 0.031111893642509103d,left: 0.5032221075984309d),

new NpgsqlTypes.NpgsqlBox(top: 0.9722023857541388d,right: 0.5112303012945913d,bottom: 0.5266847817466263d,left: 0.042906163241342d),

new NpgsqlTypes.NpgsqlBox(top: 0.9925826958336236d,right: 0.5043365634665404d,bottom: 0.16303388534086083d,left: 0.17734423759626772d),

new NpgsqlTypes.NpgsqlBox(top: 0.24969894450548957d,right: 0.9120630451460602d,bottom: 0.17167716029784164d,left: 0.3024397807559095d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8894637492358829d,right: 0.520080169440845d,bottom: 0.7089657230938721d,left: 0.3378504310285415d),

new NpgsqlTypes.NpgsqlBox(top: 0.7783578488608918d,right: 0.752812527049077d,bottom: 0.42657838701194506d,left: 0.251255516658194d),

new NpgsqlTypes.NpgsqlBox(top: 0.780326810273148d,right: 0.8242897225000637d,bottom: 0.589062947962108d,left: 0.26776576317071177d),

new NpgsqlTypes.NpgsqlBox(top: 0.3420394260600921d,right: 0.5215228095303798d,bottom: 0.0753968498013976d,left: 0.33174455807935654d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2473514057144769d,right: 0.5203090421791823d,bottom: 0.03945618463417078d,left: 0.07888932924312664d),

new NpgsqlTypes.NpgsqlBox(top: 0.47320807971678336d,right: 0.5970342136618709d,bottom: 0.017552484277651215d,left: 0.4508138718179623d),

new NpgsqlTypes.NpgsqlBox(top: 0.4823783777578303d,right: 0.6173391684821687d,bottom: 0.0970993078668323d,left: 0.35770591460234535d),

new NpgsqlTypes.NpgsqlBox(top: 0.8496731346451994d,right: 0.7386875901736276d,bottom: 0.14525344016146502d,left: 0.07756485937904467d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6866442761577471d,right: 0.7722125675696446d,bottom: 0.3923537850058719d,left: 0.01800167370520578d),

new NpgsqlTypes.NpgsqlBox(top: 0.5666114079970436d,right: 0.44762385102918945d,bottom: 0.4475972364508748d,left: 0.21065531844567398d),

new NpgsqlTypes.NpgsqlBox(top: 0.6303262651761308d,right: 0.8286283512017435d,bottom: 0.19871493151963038d,left: 0.30253425508013587d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6197301545461651d,right: 0.1948857723208891d,bottom: 0.37135051503338945d,left: 0.024083298765503636d),

new NpgsqlTypes.NpgsqlBox(top: 0.7573377591650997d,right: 0.8060718827346718d,bottom: 0.5909498244274995d,left: 0.14881856676724736d),

new NpgsqlTypes.NpgsqlBox(top: 0.3589744866272203d,right: 0.7397762907217045d,bottom: 0.3571451313502534d,left: 0.09791270928038132d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9843179069506939d,right: 0.9545119171085799d,bottom: 0.23491257008519673d,left: 0.15802857832638317d),

new NpgsqlTypes.NpgsqlBox(top: 0.5506345140856772d,right: 0.19888902666463604d,bottom: 0.1731014831508182d,left: 0.17537965553705037d),

new NpgsqlTypes.NpgsqlBox(top: 0.674005680938228d,right: 0.37837397369447223d,bottom: 0.24934644617187163d,left: 0.14163334877168d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4409712273872336d,right: 0.35029889180626317d,bottom: 0.06036761092189524d,left: 0.11232142767260767d),

new NpgsqlTypes.NpgsqlBox(top: 0.32431820777508347d,right: 0.2987089842763856d,bottom: 0.29585458815648524d,left: 0.03741245849319885d),

new NpgsqlTypes.NpgsqlBox(top: 0.23826352692149844d,right: 0.22143287070637485d,bottom: 0.20152167431965384d,left: 0.216593004310196d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6722672787347732d,right: 0.6706656356209421d,bottom: 0.04120030906280503d,left: 0.11675272843527373d),

new NpgsqlTypes.NpgsqlBox(top: 0.5126261973428271d,right: 0.8917136576915642d,bottom: 0.4610736587849835d,left: 0.11345090948964509d),

new NpgsqlTypes.NpgsqlBox(top: 0.10298040026909971d,right: 0.9529967501313835d,bottom: 0.1016506008275514d,left: 0.7214500102278554d),

new NpgsqlTypes.NpgsqlBox(top: 0.7419445941952871d,right: 0.6963316789093122d,bottom: 0.2554376213089481d,left: 0.6229608847323559d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.882109221291352d,right: 0.7364140281928208d,bottom: 0.25070504811461347d,left: 0.12058230972936756d),

new NpgsqlTypes.NpgsqlBox(top: 0.7906468085030055d,right: 0.6969845587408363d,bottom: 0.25835923556307805d,left: 0.3831808235252986d),

new NpgsqlTypes.NpgsqlBox(top: 0.529177284775254d,right: 0.8253847352881777d,bottom: 0.49087023298232535d,left: 0.26732272661468404d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47238564908003255d,right: 0.28420363565632134d,bottom: 0.27330626969464633d,left: 0.21824315344523393d),

new NpgsqlTypes.NpgsqlBox(top: 0.2039638127457123d,right: 0.3632509805503873d,bottom: 0.14653905564433012d,left: 0.051587914039188054d),

new NpgsqlTypes.NpgsqlBox(top: 0.5572881072035699d,right: 0.6027409760970129d,bottom: 0.19070774543500235d,left: 0.5279419782272805d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6957266418967065d,right: 0.4023541800281025d,bottom: 0.6654382036994505d,left: 0.37007791173730487d),

new NpgsqlTypes.NpgsqlBox(top: 0.31884674191232676d,right: 0.5453061399310665d,bottom: 0.008907745498803132d,left: 0.14754406446746626d),

new NpgsqlTypes.NpgsqlBox(top: 0.7193600760430623d,right: 0.5894977520337542d,bottom: 0.02834376814439199d,left: 0.4705166024857891d),

new NpgsqlTypes.NpgsqlBox(top: 0.14737781608938527d,right: 0.8704024146418224d,bottom: 0.038088787940419366d,left: 0.40460461769917866d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4074413234908363d,right: 0.909481045026938d,bottom: 0.2646697301669506d,left: 0.1398965751994553d),

new NpgsqlTypes.NpgsqlBox(top: 0.5520429915884952d,right: 0.8565206981287583d,bottom: 0.3730185352834794d,left: 0.1878729099030041d),

new NpgsqlTypes.NpgsqlBox(top: 0.395811234647483d,right: 0.3671284400307585d,bottom: 0.3126829193547974d,left: 0.3449143149406153d),

new NpgsqlTypes.NpgsqlBox(top: 0.6490806714797376d,right: 0.9744656594035714d,bottom: 0.4675477358546771d,left: 0.1732037272374236d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6021416942661408d,right: 0.7035281071169508d,bottom: 0.2122038825354945d,left: 0.6652475929569521d),

new NpgsqlTypes.NpgsqlBox(top: 0.6526648590446394d,right: 0.6045421998783277d,bottom: 0.18169371256758804d,left: 0.27847676392339404d),

new NpgsqlTypes.NpgsqlBox(top: 0.540814834877367d,right: 0.8263086978406438d,bottom: 0.037117378081115926d,left: 0.05138955866967443d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7997604566860812d,right: 0.7975686364657115d,bottom: 0.4141749960690544d,left: 0.35620251017620974d),

new NpgsqlTypes.NpgsqlBox(top: 0.7685307843475505d,right: 0.7628206694239079d,bottom: 0.1783952778842045d,left: 0.3869970821667844d),

new NpgsqlTypes.NpgsqlBox(top: 0.8075870909547938d,right: 0.599424748334973d,bottom: 0.7240293558971233d,left: 0.019304966928463063d),

new NpgsqlTypes.NpgsqlBox(top: 0.3064247048835229d,right: 0.7420533252473481d,bottom: 0.1455469421141231d,left: 0.6172608724275663d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5231820397814747d,right: 0.8825482698810182d,bottom: 0.1498597881382565d,left: 0.05520533997840926d),

new NpgsqlTypes.NpgsqlBox(top: 0.6136578046829654d,right: 0.14978642418798516d,bottom: 0.5754683108138274d,left: 0.10082779716097534d),

new NpgsqlTypes.NpgsqlBox(top: 0.5672887404383012d,right: 0.7140421916353691d,bottom: 0.09844627954511875d,left: 0.5739843522838611d),

new NpgsqlTypes.NpgsqlBox(top: 0.36557509415634115d,right: 0.6729810913185089d,bottom: 0.0015910779272743092d,left: 0.41465109284082535d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5788873420831697d,right: 0.9561288056436684d,bottom: 0.0644831742535591d,left: 0.8717020912678829d),

new NpgsqlTypes.NpgsqlBox(top: 0.6556244761232323d,right: 0.6072607511157668d,bottom: 0.29151330014650956d,left: 0.19137261310318288d),

new NpgsqlTypes.NpgsqlBox(top: 0.8802035081748378d,right: 0.9188974195234346d,bottom: 0.379395523817482d,left: 0.3120157235285298d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.963385625244446d,right: 0.2610038398656397d,bottom: 0.6938502659881894d,left: 0.24617471683239311d),

new NpgsqlTypes.NpgsqlBox(top: 0.789520329804173d,right: 0.08632168011122743d,bottom: 0.7481359275714944d,left: 0.08475861447870836d),

new NpgsqlTypes.NpgsqlBox(top: 0.11227972806712361d,right: 0.7672023554492442d,bottom: 0.06410698166478002d,left: 0.24144790771748603d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9843200398112485d,right: 0.7279195367097607d,bottom: 0.3990950383681223d,left: 0.3473776621368201d),

new NpgsqlTypes.NpgsqlBox(top: 0.9286146037987234d,right: 0.8918551276846339d,bottom: 0.16866851655453952d,left: 0.10298780516911465d),

new NpgsqlTypes.NpgsqlBox(top: 0.964907990120153d,right: 0.7974042648367512d,bottom: 0.778567978567095d,left: 0.5151000390510454d),

new NpgsqlTypes.NpgsqlBox(top: 0.9501780243193158d,right: 0.25993525484201174d,bottom: 0.26775106585040187d,left: 0.016184149088803168d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7742594713057155d,right: 0.9057769355412355d,bottom: 0.4853492882275734d,left: 0.8010186424129156d),

new NpgsqlTypes.NpgsqlBox(top: 0.5511572070525901d,right: 0.1269677602351036d,bottom: 0.26634918435562704d,left: 0.0903823372738245d),

new NpgsqlTypes.NpgsqlBox(top: 0.9750164161424301d,right: 0.889174872905654d,bottom: 0.9543260324095719d,left: 0.7907582737009081d),

new NpgsqlTypes.NpgsqlBox(top: 0.7977608912815588d,right: 0.9708490221468733d,bottom: 0.48445737791854415d,left: 0.7875364326474913d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8114914290321852d,right: 0.97585035803334d,bottom: 0.5275733937426914d,left: 0.6926590214599037d),

new NpgsqlTypes.NpgsqlBox(top: 0.9464207598928757d,right: 0.2551824651820296d,bottom: 0.19368890105234982d,left: 0.22764414986472425d),

new NpgsqlTypes.NpgsqlBox(top: 0.7650512520423698d,right: 0.7912408041011056d,bottom: 0.519576095639138d,left: 0.2981014658820841d),

new NpgsqlTypes.NpgsqlBox(top: 0.942373285758847d,right: 0.4649535853494672d,bottom: 0.20138817515639074d,left: 0.23690227976562184d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15974992829935952d,right: 0.6889705667899017d,bottom: 0.08706542853342991d,left: 0.2800074140677209d),

new NpgsqlTypes.NpgsqlBox(top: 0.8405275596866347d,right: 0.6954874191091146d,bottom: 0.8185154681768954d,left: 0.5078593838357871d),

new NpgsqlTypes.NpgsqlBox(top: 0.7997343211497995d,right: 0.8380048666798442d,bottom: 0.7635483537795078d,left: 0.5831092105967287d),

new NpgsqlTypes.NpgsqlBox(top: 0.8463595148440735d,right: 0.9259971509472449d,bottom: 0.6403456143155233d,left: 0.18629183646126968d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8742410936010808d,right: 0.7798963048498437d,bottom: 0.4311050892328233d,left: 0.5969714987792103d),

new NpgsqlTypes.NpgsqlBox(top: 0.6660679052468305d,right: 0.8802924321393856d,bottom: 0.2919405541049296d,left: 0.5529857726512364d),

new NpgsqlTypes.NpgsqlBox(top: 0.3045683630081585d,right: 0.2482429347166114d,bottom: 0.28283837817515434d,left: 0.16638880872513273d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7623302873458571d,right: 0.7747607270856012d,bottom: 0.34857222946062916d,left: 0.5562711521268537d),

new NpgsqlTypes.NpgsqlBox(top: 0.8683261869697373d,right: 0.5486183331596655d,bottom: 0.7178633997237182d,left: 0.21144353977892594d),

new NpgsqlTypes.NpgsqlBox(top: 0.7927336032858973d,right: 0.7506182020890769d,bottom: 0.31585902939529353d,left: 0.624491875949544d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6005655214179259d,right: 0.7726049651480262d,bottom: 0.0563114988751352d,left: 0.21008430908315423d),

new NpgsqlTypes.NpgsqlBox(top: 0.7413932857503347d,right: 0.25946340829891956d,bottom: 0.3915071035916877d,left: 0.12673058809694304d),

new NpgsqlTypes.NpgsqlBox(top: 0.7061079389801391d,right: 0.9663405614353361d,bottom: 0.3233164931601925d,left: 0.9540133134782711d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7264229274229976d,right: 0.9482022893817442d,bottom: 0.5228857650186841d,left: 0.9343940914856147d),

new NpgsqlTypes.NpgsqlBox(top: 0.5787246980937841d,right: 0.9172829302493244d,bottom: 0.2686985990581755d,left: 0.022142788204027264d),

new NpgsqlTypes.NpgsqlBox(top: 0.7718711915235676d,right: 0.5295075918072025d,bottom: 0.030480250143660736d,left: 0.1300909552955164d),

new NpgsqlTypes.NpgsqlBox(top: 0.7963433426314123d,right: 0.7217739321133628d,bottom: 0.6516339167403612d,left: 0.3783624435489804d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23280002269485722d,right: 0.5267191523971574d,bottom: 0.18038569328990284d,left: 0.14282309853572228d),

new NpgsqlTypes.NpgsqlBox(top: 0.9708327614092068d,right: 0.8236183237754204d,bottom: 0.5925359551448669d,left: 0.5291174841815596d),

new NpgsqlTypes.NpgsqlBox(top: 0.3836952909966307d,right: 0.26997948937388305d,bottom: 0.31827900489053096d,left: 0.1849668934264398d),

new NpgsqlTypes.NpgsqlBox(top: 0.6580072542945165d,right: 0.8228615650711906d,bottom: 0.06144625198459963d,left: 0.7018638389835068d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3122624607662208d,right: 0.792960290417344d,bottom: 0.16116047008668133d,left: 0.3208342036293048d),

new NpgsqlTypes.NpgsqlBox(top: 0.5024415044234457d,right: 0.9037855817387733d,bottom: 0.3819780054516434d,left: 0.7112040784495897d),

new NpgsqlTypes.NpgsqlBox(top: 0.9725099718051724d,right: 0.8521494962255296d,bottom: 0.29584716899516805d,left: 0.33751393602905166d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 10;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 102, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 58, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

