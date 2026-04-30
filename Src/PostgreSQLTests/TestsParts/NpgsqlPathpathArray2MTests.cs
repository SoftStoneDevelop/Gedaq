

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5163637075264291d, y: 0.9076766297108692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8831899872633427d, y: 0.4716990363847122d), new NpgsqlTypes.NpgsqlPoint(x: 0.007021024520657337d, y: 0.6365729389437726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6251488885975275d, y: 0.9104371274904088d), new NpgsqlTypes.NpgsqlPoint(x: 0.885339615212107d, y: 0.2248197516585574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9042784705504843d, y: 0.046559274297672815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.332121922005459d, y: 0.5868512419436476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401553909171229d, y: 0.5948009045179404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772014291209985d, y: 0.1278152652203195d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7202188813292153d, y: 0.2797542405954103d), new NpgsqlTypes.NpgsqlPoint(x: 0.2674624076068439d, y: 0.15178641295307482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126540434369299d, y: 0.5839642832942232d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2715090258853202d, y: 0.4587595682988834d), new NpgsqlTypes.NpgsqlPoint(x: 0.34863476381930203d, y: 0.9812913423703433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183056621907391d, y: 0.987237477510721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3516219001676656d, y: 0.19881909000820785d), new NpgsqlTypes.NpgsqlPoint(x: 0.42772199435350866d, y: 0.0659365814517876d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613091233447895d, y: 0.3689248662845521d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6564081956603487d, y: 0.5732301929813766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785120293462892d, y: 0.055031361784324995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766803033405641d, y: 0.6581915476135756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41208809491484566d, y: 0.877169086086775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646903063499999d, y: 0.9790434275130856d), new NpgsqlTypes.NpgsqlPoint(x: 0.13856738430177573d, y: 0.427147709004687d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7651957040572845d, y: 0.9760901074889449d), new NpgsqlTypes.NpgsqlPoint(x: 0.07976022128708271d, y: 0.7414694033987871d), new NpgsqlTypes.NpgsqlPoint(x: 0.7737104355397957d, y: 0.5902397754946752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6000112475539657d, y: 0.8509026027093833d), new NpgsqlTypes.NpgsqlPoint(x: 0.21188686443660376d, y: 0.7719297203557971d), new NpgsqlTypes.NpgsqlPoint(x: 0.31817474853624605d, y: 0.36375777956528776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019400992976681d, y: 0.47979663266606776d), new NpgsqlTypes.NpgsqlPoint(x: 0.14428963928835703d, y: 0.8704486902517238d), new NpgsqlTypes.NpgsqlPoint(x: 0.32503752185421386d, y: 0.495857429943071d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21178187916437952d, y: 0.7320184200903899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712295694907835d, y: 0.46776386352522126d), new NpgsqlTypes.NpgsqlPoint(x: 0.4166860901493249d, y: 0.27721420370362104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2505845889646906d, y: 0.4932687245845001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841782096295504d, y: 0.41128990708240654d), new NpgsqlTypes.NpgsqlPoint(x: 0.21672762338277451d, y: 0.1884732342072314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6312400116436988d, y: 0.07984034241482374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936823184433597d, y: 0.33739523150809203d), new NpgsqlTypes.NpgsqlPoint(x: 0.803443224980638d, y: 0.6523698841342883d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8907472434673586d, y: 0.6206238732937075d), new NpgsqlTypes.NpgsqlPoint(x: 0.035535185785117385d, y: 0.4055695021322223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440374941383481d, y: 0.750544790616296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5865050300276969d, y: 0.5684524614731757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006276016914431d, y: 0.7021867771290683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2748816187346447d, y: 0.1515988506427004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20943248335917397d, y: 0.9793977864119245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319259423508294d, y: 0.03929759166998947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256178196544884d, y: 0.3989722896757676d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.869774758605792d, y: 0.044806039806678744d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868145934092162d, y: 0.6345165132105844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075243153815309d, y: 0.3925937326231954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5723955185809649d, y: 0.8723718139810474d), new NpgsqlTypes.NpgsqlPoint(x: 0.44042103718245496d, y: 0.8483242865818279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7010584635789213d, y: 0.42854032601111824d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8801388949160298d, y: 0.3062192248719079d), new NpgsqlTypes.NpgsqlPoint(x: 0.008187332501381483d, y: 0.9578761002008447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746885144154376d, y: 0.14324475443843698d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11484523787500311d, y: 0.009179483766834529d), new NpgsqlTypes.NpgsqlPoint(x: 0.15440916297529828d, y: 0.1246455227999601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675324535251351d, y: 0.36030241867737245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038466947735286916d, y: 0.9433418717051428d), new NpgsqlTypes.NpgsqlPoint(x: 0.614816888288701d, y: 0.42252103342162217d), new NpgsqlTypes.NpgsqlPoint(x: 0.49170607904434915d, y: 0.12873982057692923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20687707861418392d, y: 0.12614132869800732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620279052532104d, y: 0.3393889509886442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601714811124487d, y: 0.7449459432445575d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7686527927058113d, y: 0.7895822693098089d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098343397118877d, y: 0.3190071866649856d), new NpgsqlTypes.NpgsqlPoint(x: 0.2819181152830331d, y: 0.3260188884799756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4912673179200814d, y: 0.45623089752637913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006231144594314d, y: 0.5403285588912532d), new NpgsqlTypes.NpgsqlPoint(x: 0.05182728356850308d, y: 0.631834065748121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3805441146308175d, y: 0.476605680839681d), new NpgsqlTypes.NpgsqlPoint(x: 0.16464362745394234d, y: 0.9109302152062143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5755281472422458d, y: 0.17096629642069217d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650624245597528d, y: 0.4935896189304204d), new NpgsqlTypes.NpgsqlPoint(x: 0.14215866695537427d, y: 0.2506451123522181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040000726464759d, y: 0.6914300616564076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5050366064755547d, y: 0.29565445721799033d), new NpgsqlTypes.NpgsqlPoint(x: 0.16580168140820595d, y: 0.6101107647613234d), new NpgsqlTypes.NpgsqlPoint(x: 0.040870939268626505d, y: 0.5851228776577595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44487051032301506d, y: 0.30101663808247947d), new NpgsqlTypes.NpgsqlPoint(x: 0.2561391919780174d, y: 0.008948464049694183d), new NpgsqlTypes.NpgsqlPoint(x: 0.42741541268469185d, y: 0.9893913399980484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8789126244612866d, y: 0.1619234830153118d), new NpgsqlTypes.NpgsqlPoint(x: 0.64859371937832d, y: 0.1244874098290123d), new NpgsqlTypes.NpgsqlPoint(x: 0.210146788661988d, y: 0.7358212332112578d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02821494695182325d, y: 0.3214958898216228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989591170568247d, y: 0.1251164722700674d), new NpgsqlTypes.NpgsqlPoint(x: 0.20264983144700766d, y: 0.592032378041737d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028818303386784d, y: 0.5370327604873703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062576550163378d, y: 0.9598809853583259d), new NpgsqlTypes.NpgsqlPoint(x: 0.478170406238552d, y: 0.8214328315266883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5319278297400425d, y: 0.5297901671926021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949632743145988d, y: 0.3969437946953862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277695444081387d, y: 0.9452048727878016d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8525856886220853d, y: 0.6655235126180002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987388380868366d, y: 0.6124029478587536d), new NpgsqlTypes.NpgsqlPoint(x: 0.30025327458887996d, y: 0.6960294902819896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.472119643332898d, y: 0.1615435881987094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234606719876272d, y: 0.5301943578736532d), new NpgsqlTypes.NpgsqlPoint(x: 0.3144916860300506d, y: 0.8614490296359602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19665606482749887d, y: 0.7002488244048645d), new NpgsqlTypes.NpgsqlPoint(x: 0.09588947588520191d, y: 0.4592712117435934d), new NpgsqlTypes.NpgsqlPoint(x: 0.525308120199379d, y: 0.9754451276604588d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008422791240885519d, y: 0.6644729245827751d), new NpgsqlTypes.NpgsqlPoint(x: 0.28794330787079614d, y: 0.9955707788554192d), new NpgsqlTypes.NpgsqlPoint(x: 0.06066218937879331d, y: 0.07131283617884088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8371507841366581d, y: 0.8850113712155551d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584438024881765d, y: 0.8778812174614999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777272264296234d, y: 0.4220723027095902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030824662079523946d, y: 0.16825832277603936d), new NpgsqlTypes.NpgsqlPoint(x: 0.07472913964966821d, y: 0.06735363432601305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281306680324473d, y: 0.5398151240439687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5123850148828107d, y: 0.42998280897615215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384017259716482d, y: 0.8497176699942509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045045876628718d, y: 0.8802300956471888d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8384152785142198d, y: 0.4928435665840737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8174036077713983d, y: 0.2247016956873532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790137269118382d, y: 0.6332984296528361d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.454911539607064d, y: 0.5536345606443931d), new NpgsqlTypes.NpgsqlPoint(x: 0.3313695677501456d, y: 0.15934042006385873d), new NpgsqlTypes.NpgsqlPoint(x: 0.25612597510931867d, y: 0.5811758811100726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2822379904206568d, y: 0.22158600733499878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655806942304509d, y: 0.4163606073032481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475635868060082d, y: 0.48309775205933236d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28762475907984997d, y: 0.44586888606215036d), new NpgsqlTypes.NpgsqlPoint(x: 0.006784678014961076d, y: 0.9174502779336844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385588914178206d, y: 0.8703283966507882d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3773732332999249d, y: 0.9865519278418589d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613262857669567d, y: 0.02175452963762503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081434439832711d, y: 0.4086288839085944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507153688014437d, y: 0.5334633820671137d), new NpgsqlTypes.NpgsqlPoint(x: 0.696448140960829d, y: 0.5094161121062889d), new NpgsqlTypes.NpgsqlPoint(x: 0.474850498447447d, y: 0.2222118702513045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8358876052221645d, y: 0.07777797815798182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331999741177663d, y: 0.07615798919647365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638015590755176d, y: 0.40381594787603436d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8258248730794664d, y: 0.18581373183837502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618297477660786d, y: 0.27967407233236097d), new NpgsqlTypes.NpgsqlPoint(x: 0.12232895674526434d, y: 0.705225019631485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8039162449793558d, y: 0.39339751883246676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872293431955618d, y: 0.6738607269757141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581145588633063d, y: 0.224509882843122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903957729212521d, y: 0.3391225191209569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186119924520574d, y: 0.16790001354382988d), new NpgsqlTypes.NpgsqlPoint(x: 0.343518497463025d, y: 0.322387941582167d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12251127793959093d, y: 0.5301009777338029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963006059513257d, y: 0.4763350779108215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447226565677387d, y: 0.08261090189196818d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26303161725522173d, y: 0.06934985877140953d), new NpgsqlTypes.NpgsqlPoint(x: 0.615472538811597d, y: 0.11203862971162637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525718222793376d, y: 0.8842347080467748d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7007196537903767d, y: 0.280817843500756d), new NpgsqlTypes.NpgsqlPoint(x: 0.24107905118226747d, y: 0.8873564086276212d), new NpgsqlTypes.NpgsqlPoint(x: 0.07461518901890762d, y: 0.08841872436513376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6801830781517201d, y: 0.7243709807042302d), new NpgsqlTypes.NpgsqlPoint(x: 0.36384030240956755d, y: 0.8094853840635571d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685512545395626d, y: 0.45015756735097856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35376196190214215d, y: 0.7779309309425883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09747234409515204d, y: 0.8246310980670315d), new NpgsqlTypes.NpgsqlPoint(x: 0.07052396846185605d, y: 0.036801565439598005d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3451362141483505d, y: 0.3612767081795978d), new NpgsqlTypes.NpgsqlPoint(x: 0.39546804114927525d, y: 0.48003991750949404d), new NpgsqlTypes.NpgsqlPoint(x: 0.18550077053381497d, y: 0.8771299284192887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6031652708289322d, y: 0.34093042277676344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824888271625466d, y: 0.07430918511020834d), new NpgsqlTypes.NpgsqlPoint(x: 0.21137415974394203d, y: 0.43806364032269773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19605206150946963d, y: 0.609405075725614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261067004231571d, y: 0.2691790118941436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591978512289024d, y: 0.1195759312236172d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05087380527194618d, y: 0.41888117676363934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3180003574361092d, y: 0.789690090219358d), new NpgsqlTypes.NpgsqlPoint(x: 0.1281895038856239d, y: 0.5181687949867477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1687417942010998d, y: 0.7651205002493638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553680135310212d, y: 0.8153038652423623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5724354018540309d, y: 0.04447121946343069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3643249604902572d, y: 0.9539828806188834d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908884080684992d, y: 0.8327997314570215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255314712900295d, y: 0.3527418558020545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2686870003894981d, y: 0.37632998850888566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7989137446049888d, y: 0.5850556422248966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958571938888802d, y: 0.16779849194055463d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29819607454128394d, y: 0.7331094164518254d), new NpgsqlTypes.NpgsqlPoint(x: 0.014904642587300732d, y: 0.508043846610888d), new NpgsqlTypes.NpgsqlPoint(x: 0.0381135508342233d, y: 0.5302817295548629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8407340149597354d, y: 0.03475918911596709d), new NpgsqlTypes.NpgsqlPoint(x: 0.21943296377579635d, y: 0.4174254664846644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525791015371227d, y: 0.6691248665670314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755235492929671d, y: 0.49658974070235906d), new NpgsqlTypes.NpgsqlPoint(x: 0.49792842349327426d, y: 0.755545856070695d), new NpgsqlTypes.NpgsqlPoint(x: 0.259819986950531d, y: 0.9790390075372647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22419865443060338d, y: 0.41591237523866154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815331880176443d, y: 0.028828434636761213d), new NpgsqlTypes.NpgsqlPoint(x: 0.09364939224908664d, y: 0.953852824198981d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236942782596151d, y: 0.6500591001585216d), new NpgsqlTypes.NpgsqlPoint(x: 0.45528979226336885d, y: 0.016134741102689754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8596974641687448d, y: 0.12455900998781333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26796091453622894d, y: 0.3106630745133526d), new NpgsqlTypes.NpgsqlPoint(x: 0.040211430431329576d, y: 0.03405759805228936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013691111450388d, y: 0.5360245605060221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4942102902203047d, y: 0.9522902822296297d), new NpgsqlTypes.NpgsqlPoint(x: 0.27084886258969d, y: 0.593651480759328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930228860963804d, y: 0.9138813745560574d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32031170133878895d, y: 0.5830733419131024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939548008818113d, y: 0.6985897515810402d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570239604160948d, y: 0.26003031461803516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7277417732149813d, y: 0.7020887064314014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8754114653707686d, y: 0.36146808159594146d), new NpgsqlTypes.NpgsqlPoint(x: 0.04547553850144104d, y: 0.3995952460035044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9913999990085366d, y: 0.18361885692303404d), new NpgsqlTypes.NpgsqlPoint(x: 0.24961397740456626d, y: 0.49264888497590087d), new NpgsqlTypes.NpgsqlPoint(x: 0.473833644576235d, y: 0.9500885468941733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8633758516158514d, y: 0.9145585900977523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747270315201764d, y: 0.008176999026809462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131517986449027d, y: 0.8564016231837219d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.800264016715313d, y: 0.37542710058705997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9471072847876346d, y: 0.09649365534668686d), new NpgsqlTypes.NpgsqlPoint(x: 0.47357363432909827d, y: 0.15785852668920652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23036778926605794d, y: 0.25094477757955724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174832775025753d, y: 0.5497390696654748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628605345056488d, y: 0.7441000036163711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6634360397281299d, y: 0.4980732088218961d), new NpgsqlTypes.NpgsqlPoint(x: 0.4338257447706886d, y: 0.36113295883533403d), new NpgsqlTypes.NpgsqlPoint(x: 0.09804061170508382d, y: 0.7978072833040425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23507373115232444d, y: 0.10350940080943771d), new NpgsqlTypes.NpgsqlPoint(x: 0.5870558880799337d, y: 0.7963891762719305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2045261224321855d, y: 0.9301217757668439d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050576295903714374d, y: 0.15844258293621483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566881187526852d, y: 0.49725576956621653d), new NpgsqlTypes.NpgsqlPoint(x: 0.46391555179701593d, y: 0.6602449998561175d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5417252395909566d, y: 0.10330064550088058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644840138317632d, y: 0.9161601722329038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927533119568209d, y: 0.8649545997504964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.619243299633483d, y: 0.5110471345195631d), new NpgsqlTypes.NpgsqlPoint(x: 0.2751969840813583d, y: 0.41033729720527023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238044590085174d, y: 0.5658290499112552d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7268560635561312d, y: 0.6265266374548464d), new NpgsqlTypes.NpgsqlPoint(x: 0.0310116337614722d, y: 0.004725380747395369d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887650837381012d, y: 0.5998943249382921d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9019895778797312d, y: 0.20130191127915487d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651041629442203d, y: 0.6264346009183841d), new NpgsqlTypes.NpgsqlPoint(x: 0.0240407269674332d, y: 0.34948111317785957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08866432594583906d, y: 0.17948500398643707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8791171798656834d, y: 0.33164476502629214d), new NpgsqlTypes.NpgsqlPoint(x: 0.987570319713369d, y: 0.7344233992227945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06297173379979315d, y: 0.7317738559926746d), new NpgsqlTypes.NpgsqlPoint(x: 0.08720059017291226d, y: 0.9976664225793249d), new NpgsqlTypes.NpgsqlPoint(x: 0.38162430519390655d, y: 0.9626867371632932d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17686412917356997d, y: 0.8822168844998604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9430266868162362d, y: 0.3540223587385771d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395471041690012d, y: 0.7030452626082632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5764113557761326d, y: 0.8467484355691133d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774080187759071d, y: 0.7134125160280977d), new NpgsqlTypes.NpgsqlPoint(x: 0.08027209293616355d, y: 0.4856989078448296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6881800265269642d, y: 0.5456515820061336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149324581498898d, y: 0.027938026452176135d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692770403785839d, y: 0.4000238246603034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8317856300138242d, y: 0.5676070240064028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584173141396306d, y: 0.28957485398632854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4185490441942552d, y: 0.09528812464305547d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6746446437288931d, y: 0.39819847222003635d), new NpgsqlTypes.NpgsqlPoint(x: 0.20872897075165586d, y: 0.3471638872766779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731470096341343d, y: 0.0719591315240864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5397212866625061d, y: 0.15178293529769304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5475692493866017d, y: 0.9038864579934459d), new NpgsqlTypes.NpgsqlPoint(x: 0.12977509820644284d, y: 0.756958805443594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8790025207701443d, y: 0.21613905574118664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3029361219217863d, y: 0.18538423774949364d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730351137861018d, y: 0.6323472450405626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27414237038017586d, y: 0.08043550214313788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759813801904506d, y: 0.49997612217137455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442735441079809d, y: 0.8114890231249672d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7891643647558312d, y: 0.7430447518323733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18850732094849965d, y: 0.6786385324748766d), new NpgsqlTypes.NpgsqlPoint(x: 0.246463903514754d, y: 0.4818741178246233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4365704037743322d, y: 0.7356991545193458d), new NpgsqlTypes.NpgsqlPoint(x: 0.48994708858739056d, y: 0.17780374429722623d), new NpgsqlTypes.NpgsqlPoint(x: 0.22703453517821282d, y: 0.5538134350642986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9578801726544175d, y: 0.2811139031492881d), new NpgsqlTypes.NpgsqlPoint(x: 0.978924844979417d, y: 0.2625537423353588d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468732910768837d, y: 0.703322813966646d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03912100286485698d, y: 0.38957915450660907d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679346386481944d, y: 0.2163769980534297d), new NpgsqlTypes.NpgsqlPoint(x: 0.21358936969252174d, y: 0.19733370813220397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5372375747148073d, y: 0.07470505830722673d), new NpgsqlTypes.NpgsqlPoint(x: 0.96889894845414d, y: 0.2715566961157988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397531007469594d, y: 0.3769992251518727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25664374666763023d, y: 0.05226047067779305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595650139863443d, y: 0.7275550156030659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567388442769661d, y: 0.8624211292129925d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7911557890593771d, y: 0.4831425000418884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221132902988894d, y: 0.5626331940480914d), new NpgsqlTypes.NpgsqlPoint(x: 0.06701566801261427d, y: 0.6557287777093858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6910298602619113d, y: 0.9115240205226978d), new NpgsqlTypes.NpgsqlPoint(x: 0.29226978471226805d, y: 0.06355941913903285d), new NpgsqlTypes.NpgsqlPoint(x: 0.0653319031209385d, y: 0.8689487966427725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8143031117541746d, y: 0.4477533989204312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803051283713917d, y: 0.574778341839551d), new NpgsqlTypes.NpgsqlPoint(x: 0.20484210055915197d, y: 0.8647834690541446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10834985594234547d, y: 0.4935592740114586d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968981554901037d, y: 0.37891186650828956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7960534950668349d, y: 0.4340901220627271d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4137369596664878d, y: 0.15327334482463228d), new NpgsqlTypes.NpgsqlPoint(x: 0.984015994080353d, y: 0.2318619698594795d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648096343168804d, y: 0.7705678115724025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18339644910709063d, y: 0.2766164394423626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369215632863086d, y: 0.9068154741772139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9362500551657238d, y: 0.8817879317614378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.616488022589668d, y: 0.9744608871201497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995891496863354d, y: 0.8198941977231962d), new NpgsqlTypes.NpgsqlPoint(x: 0.874026062889614d, y: 0.7323074370947217d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4785845415788781d, y: 0.4513424017469213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159019369871764d, y: 0.8040406239889406d), new NpgsqlTypes.NpgsqlPoint(x: 0.37430425551180024d, y: 0.5822999659084894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14972381277035196d, y: 0.131848859438366d), new NpgsqlTypes.NpgsqlPoint(x: 0.788803028758884d, y: 0.37146000706726323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8498817739037496d, y: 0.5207770190812202d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4606174970311825d, y: 0.38936197529384964d), new NpgsqlTypes.NpgsqlPoint(x: 0.269684040455477d, y: 0.25105380546738976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507742431261345d, y: 0.4223031598026097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8622591924054539d, y: 0.13639221906926036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3046950720165599d, y: 0.2724413338273577d), new NpgsqlTypes.NpgsqlPoint(x: 0.813227681401937d, y: 0.13480489624042635d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6917665541167692d, y: 0.029207454662118826d), new NpgsqlTypes.NpgsqlPoint(x: 0.3419612390827297d, y: 0.7398918352728212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877299211829075d, y: 0.4656867235847363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8697578797161375d, y: 0.11313837428008022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986928623996354d, y: 0.3406533480192768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048259662380114d, y: 0.9513536005393819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9209275370062275d, y: 0.7661485267958115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7670226117432013d, y: 0.4590251323033794d), new NpgsqlTypes.NpgsqlPoint(x: 0.920689160949506d, y: 0.2074272916126958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9325548030395072d, y: 0.500789526883018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980883778548198d, y: 0.38437950209176874d), new NpgsqlTypes.NpgsqlPoint(x: 0.744697862113943d, y: 0.07102015168272768d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9762054659304136d, y: 0.3565190821242137d), new NpgsqlTypes.NpgsqlPoint(x: 0.10804311735918548d, y: 0.7638208968449121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8785153047190158d, y: 0.3090691441252954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5876322213362792d, y: 0.5140788818415968d), new NpgsqlTypes.NpgsqlPoint(x: 0.1733504636535378d, y: 0.6637332596892768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765383036724709d, y: 0.23360365428832552d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3100663350203525d, y: 0.7320060055955917d), new NpgsqlTypes.NpgsqlPoint(x: 0.556466301777988d, y: 0.7437710978636002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789735663238139d, y: 0.14818434617188492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155356277409413d, y: 0.10426254481428521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001081761863232d, y: 0.2060286635290497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010450912966724d, y: 0.9318374546909926d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6104938766646014d, y: 0.519455708074634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364317442311742d, y: 0.7603466614327743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572562155011428d, y: 0.7888359356721063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8117956531184264d, y: 0.6037221535195578d), new NpgsqlTypes.NpgsqlPoint(x: 0.16966333604270945d, y: 0.4294170522340899d), new NpgsqlTypes.NpgsqlPoint(x: 0.005276364054374927d, y: 0.8819451224841178d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9271802569117876d, y: 0.5537989246954423d), new NpgsqlTypes.NpgsqlPoint(x: 0.22172124982253627d, y: 0.6106174174783113d), new NpgsqlTypes.NpgsqlPoint(x: 0.12348010585710856d, y: 0.7437993354402331d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3162758920371168d, y: 0.329605869052477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5127411823358454d, y: 0.6702666546944278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590109571953986d, y: 0.6199004824470324d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.869331861789799d, y: 0.5862449342664923d), new NpgsqlTypes.NpgsqlPoint(x: 0.2372415440522061d, y: 0.9657586698429051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523294284704583d, y: 0.08735226549132402d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2744432303832859d, y: 0.6019067050347003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876637923264143d, y: 0.2802105780878559d), new NpgsqlTypes.NpgsqlPoint(x: 0.057766779972199145d, y: 0.1711988481645691d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4352018539687964d, y: 0.383588552489063d), new NpgsqlTypes.NpgsqlPoint(x: 0.006284843589788314d, y: 0.9943345850415165d), new NpgsqlTypes.NpgsqlPoint(x: 0.1940459895569362d, y: 0.5138568449405811d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6702782183270134d, y: 0.28540966063758155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722545402692433d, y: 0.7264622589033835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810891819310094d, y: 0.517860783911214d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3507727143696241d, y: 0.9726424745226135d), new NpgsqlTypes.NpgsqlPoint(x: 0.792339069961156d, y: 0.03366709225865805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2329030269331963d, y: 0.5684274238263185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34991950913679315d, y: 0.034756783563239524d), new NpgsqlTypes.NpgsqlPoint(x: 0.11925554155857943d, y: 0.9870815243539748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375857110084445d, y: 0.7545764667513387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387901284197948d, y: 0.31960762950542954d), new NpgsqlTypes.NpgsqlPoint(x: 0.07473542146805068d, y: 0.44152449823662043d), new NpgsqlTypes.NpgsqlPoint(x: 0.16241693417837355d, y: 0.6416236089827174d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33623749966548977d, y: 0.9840615767465039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9944293059291304d, y: 0.16327224446516442d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789986262525241d, y: 0.4772332023624054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19189712657800084d, y: 0.5415254590188306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688326924559627d, y: 0.9865350538048633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233673551315771d, y: 0.18914043937970126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.713502819858342d, y: 0.5113668885040488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7736694865323283d, y: 0.5971825911530877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488346150476383d, y: 0.5456090698146318d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36923960174512893d, y: 0.8139515809636855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5946111397637727d, y: 0.4807590589641326d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512854533569527d, y: 0.6380423059872254d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09322477883818658d, y: 0.8038591911066766d), new NpgsqlTypes.NpgsqlPoint(x: 0.10252347448608301d, y: 0.7895852006070654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578276810785929d, y: 0.7577231891478463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16046724696016557d, y: 0.7622648682033005d), new NpgsqlTypes.NpgsqlPoint(x: 0.22923349931608483d, y: 0.35355514129226984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359082421266456d, y: 0.9800091741863236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8427646626328857d, y: 0.5455670790076147d), new NpgsqlTypes.NpgsqlPoint(x: 0.306427305249071d, y: 0.12480469579909526d), new NpgsqlTypes.NpgsqlPoint(x: 0.12980933314771625d, y: 0.7300899617334469d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.844643575660732d, y: 0.03308902588597318d), new NpgsqlTypes.NpgsqlPoint(x: 0.34683265100838223d, y: 0.9996873469295318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160245291368338d, y: 0.7672505044244364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4297303765713778d, y: 0.5827574695832242d), new NpgsqlTypes.NpgsqlPoint(x: 0.3933287017150846d, y: 0.5934187373381399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974029308933126d, y: 0.05465374811278678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.98181821593502d, y: 0.34346227604995416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228246252030532d, y: 0.37469758441072254d), new NpgsqlTypes.NpgsqlPoint(x: 0.705109016744809d, y: 0.09363509104711543d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35791812661914546d, y: 0.2218440514449499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575855243744544d, y: 0.5781527986859656d), new NpgsqlTypes.NpgsqlPoint(x: 0.49225946284165345d, y: 0.7340991931042878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39311346026145577d, y: 0.47098889017031653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031096615626812d, y: 0.42795440654822003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022030344091429d, y: 0.9297005266831356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21685072229353108d, y: 0.23196894435914728d), new NpgsqlTypes.NpgsqlPoint(x: 0.33094855553923874d, y: 0.8988308735554245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9010510656475141d, y: 0.9264651332254996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6220757107872522d, y: 0.9365778147847145d), new NpgsqlTypes.NpgsqlPoint(x: 0.41849608753174083d, y: 0.5893775791029693d), new NpgsqlTypes.NpgsqlPoint(x: 0.041662735382834604d, y: 0.4276356040835221d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28694736238760954d, y: 0.25019107416556374d), new NpgsqlTypes.NpgsqlPoint(x: 0.1913954824184717d, y: 0.7125023088670868d), new NpgsqlTypes.NpgsqlPoint(x: 0.702854960977267d, y: 0.22724816027665318d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6080371701406259d, y: 0.8499407714845469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670711418143058d, y: 0.11560092413326928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606874126554183d, y: 0.7373208440505359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7300782496429584d, y: 0.35787297378662675d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832697400996507d, y: 0.7273087571645951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22150183711186888d, y: 0.5593849298949953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15197495727633348d, y: 0.28829312372117233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161153105525678d, y: 0.8260978852789201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251830471548311d, y: 0.15698512366988482d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03081535713039696d, y: 0.6729541962925518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807936588833141d, y: 0.7431383158276924d), new NpgsqlTypes.NpgsqlPoint(x: 0.998510318236018d, y: 0.9798941605680597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4423001294788579d, y: 0.7959105465280704d), new NpgsqlTypes.NpgsqlPoint(x: 0.10139313846025855d, y: 0.8636634707716314d), new NpgsqlTypes.NpgsqlPoint(x: 0.13369520936054813d, y: 0.007534921524204319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6588682773761068d, y: 0.07754792946987188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800339267186019d, y: 0.8230842094097841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8382322281041461d, y: 0.11618103291069048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4199700492171091d, y: 0.7078088840733399d), new NpgsqlTypes.NpgsqlPoint(x: 0.4439592721564667d, y: 0.9062880199020366d), new NpgsqlTypes.NpgsqlPoint(x: 0.03940281865298689d, y: 0.7440400542384761d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3259077055353905d, y: 0.017073430742940543d), new NpgsqlTypes.NpgsqlPoint(x: 0.41203347598079076d, y: 0.6006748196586023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847751364248633d, y: 0.8717772647198725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6362844820992107d, y: 0.11740495053329991d), new NpgsqlTypes.NpgsqlPoint(x: 0.007813155165619534d, y: 0.6259168750257449d), new NpgsqlTypes.NpgsqlPoint(x: 0.10601243080828215d, y: 0.17884615507761048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8159766868327608d, y: 0.3240623927927929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8029075384209272d, y: 0.6706385910335354d), new NpgsqlTypes.NpgsqlPoint(x: 0.05024787623907545d, y: 0.43382709166373634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2778851468043124d, y: 0.20203303304716236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520518347365177d, y: 0.6599737465873919d), new NpgsqlTypes.NpgsqlPoint(x: 0.311647986542009d, y: 0.15529080986053956d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7724886811289491d, y: 0.822123945735381d), new NpgsqlTypes.NpgsqlPoint(x: 0.009975277562922602d, y: 0.181119743634804d), new NpgsqlTypes.NpgsqlPoint(x: 0.6980482326857881d, y: 0.2648698507027286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967178742193145d, y: 0.42162829332115204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444955492343077d, y: 0.5273567295909316d), new NpgsqlTypes.NpgsqlPoint(x: 0.04597609022114679d, y: 0.42544448471829033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8802856908353817d, y: 0.8220781595057964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926806744682405d, y: 0.28346320689336324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9252070021890227d, y: 0.6698302395819077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06517243659078853d, y: 0.8681556567854648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564870372487243d, y: 0.5158402602294132d), new NpgsqlTypes.NpgsqlPoint(x: 0.907056195861433d, y: 0.9796469714686179d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16321665208267122d, y: 0.4332512245237614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17110364442226722d, y: 0.368545046501184d), new NpgsqlTypes.NpgsqlPoint(x: 0.01803814217657962d, y: 0.351747906594043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36184186098846305d, y: 0.371856018246554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608313355758141d, y: 0.5130108333604784d), new NpgsqlTypes.NpgsqlPoint(x: 0.1999885192686356d, y: 0.7904598623339968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3935096428278776d, y: 0.5995225980166341d), new NpgsqlTypes.NpgsqlPoint(x: 0.34122310168879666d, y: 0.319567154880413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375101264669396d, y: 0.9024422349476612d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9007327467504219d, y: 0.42503736581038254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080735894281409d, y: 0.8906401712309915d), new NpgsqlTypes.NpgsqlPoint(x: 0.18515426142158242d, y: 0.5556863418486699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7749539599580584d, y: 0.6671753931969147d), new NpgsqlTypes.NpgsqlPoint(x: 0.36001059488723575d, y: 0.6773619577675846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858876580824649d, y: 0.8839876638414667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19053435175014521d, y: 0.3751416503792244d), new NpgsqlTypes.NpgsqlPoint(x: 0.018728553240274226d, y: 0.6231730173143682d), new NpgsqlTypes.NpgsqlPoint(x: 0.44260212660872555d, y: 0.5738603349342651d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9420057372573554d, y: 0.24306836455793268d), new NpgsqlTypes.NpgsqlPoint(x: 0.45310368083879626d, y: 0.054598633768626614d), new NpgsqlTypes.NpgsqlPoint(x: 0.15887694963215104d, y: 0.561104019996486d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926567471697673d, y: 0.691126938911665d), new NpgsqlTypes.NpgsqlPoint(x: 0.12424199136700698d, y: 0.48726729936353186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922604359230165d, y: 0.17899907757919353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3311865925423352d, y: 0.6706541737159004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852765999762374d, y: 0.649532877134334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3853317671794815d, y: 0.9695390639562801d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024069528864135048d, y: 0.945942952751297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6054713134987589d, y: 0.6404694791894501d), new NpgsqlTypes.NpgsqlPoint(x: 0.2827876513986445d, y: 0.819484243497533d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.871959809682554d, y: 0.826063791926161d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964297910670877d, y: 0.0873891064709813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792292363153825d, y: 0.5526543450627491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08842211636957586d, y: 0.6014623777415273d), new NpgsqlTypes.NpgsqlPoint(x: 0.013080679675401163d, y: 0.18217348568634528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874325671979876d, y: 0.38832978358760106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8861804327658306d, y: 0.020119629864244426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856239962912942d, y: 0.20022462484291337d), new NpgsqlTypes.NpgsqlPoint(x: 0.2591591053682184d, y: 0.18200794301248013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9489024700419323d, y: 0.48451026085030546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499949729425017d, y: 0.8062776721168206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298485568480721d, y: 0.3271882336558043d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7077028399814923d, y: 0.6820811094116227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808273135373183d, y: 0.9767911298881681d), new NpgsqlTypes.NpgsqlPoint(x: 0.12396497359905545d, y: 0.3713154159529608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07886839384522137d, y: 0.9915561077280848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829416320374938d, y: 0.5728919284891284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315731613957102d, y: 0.09291259597260237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131612435428986d, y: 0.9220578652925346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342137236335288d, y: 0.5439547592507138d), new NpgsqlTypes.NpgsqlPoint(x: 0.28875509438175884d, y: 0.5717514208434819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3987993302195876d, y: 0.049308642329889296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3814125796652521d, y: 0.9531365032681653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521546821586943d, y: 0.9985578941494295d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9567339772863288d, y: 0.5304585533950432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455120973731003d, y: 0.9712221111359081d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334629100952832d, y: 0.7649639057661973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016308644495596103d, y: 0.959158644892691d), new NpgsqlTypes.NpgsqlPoint(x: 0.42038172689658515d, y: 0.1973904404027993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294923744493655d, y: 0.11371236211293445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288480524540586d, y: 0.4359378032617375d), new NpgsqlTypes.NpgsqlPoint(x: 0.2417913338792791d, y: 0.464115058874906d), new NpgsqlTypes.NpgsqlPoint(x: 0.16097795088895517d, y: 0.44903630967829966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4841309233472364d, y: 0.4374329598798399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637403118064939d, y: 0.31293491102165305d), new NpgsqlTypes.NpgsqlPoint(x: 0.27226140599164395d, y: 0.882652846607241d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4304877843705395d, y: 0.41713777366022986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8342679666178144d, y: 0.6378453340104806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8103973774510222d, y: 0.11376777533952398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9866427859559784d, y: 0.2578809569294933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400008299826045d, y: 0.3116594564387176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968527872095058d, y: 0.8003975082115404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.723327100765269d, y: 0.5336782719748183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846199643001161d, y: 0.1805780666936858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688773337792729d, y: 0.24143378087624057d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602147694098704d, y: 0.1640231660781063d), new NpgsqlTypes.NpgsqlPoint(x: 0.16444241917458624d, y: 0.4018211248424245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894278615902607d, y: 0.44559555153148367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02417838594293209d, y: 0.09749078225172969d), new NpgsqlTypes.NpgsqlPoint(x: 0.2853792865537408d, y: 0.7746195000268404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818578104989857d, y: 0.5715717687905423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267395829135362d, y: 0.6209740998019092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312903704979014d, y: 0.5899736282870712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331536669472141d, y: 0.1257008112426765d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29030434880568246d, y: 0.6184821748269725d), new NpgsqlTypes.NpgsqlPoint(x: 0.27741887779707386d, y: 0.9377797613984122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572984495165004d, y: 0.6973184985758943d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5492565787854508d, y: 0.12460932885142961d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953752345885803d, y: 0.7749842401931425d), new NpgsqlTypes.NpgsqlPoint(x: 0.542295178747492d, y: 0.6674328868363987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4439541066221955d, y: 0.9136148459760011d), new NpgsqlTypes.NpgsqlPoint(x: 0.42763400658962825d, y: 0.7887477241053794d), new NpgsqlTypes.NpgsqlPoint(x: 0.570644458381195d, y: 0.6016675579843068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5656612765188751d, y: 0.463424809979054d), new NpgsqlTypes.NpgsqlPoint(x: 0.009774252736182043d, y: 0.26125934617260016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462959549498285d, y: 0.22929463440499775d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4307233338670783d, y: 0.9637520454338372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9911165645272474d, y: 0.4550371656599259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679493700135874d, y: 0.8296567912172595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5678924116377223d, y: 0.37817330486750356d), new NpgsqlTypes.NpgsqlPoint(x: 0.35738841681946343d, y: 0.9982719971684826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089587832024501d, y: 0.5000972433287164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8880975929776525d, y: 0.3005618319358473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160154948449154d, y: 0.3594907400392744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289051233499175d, y: 0.34542487591478654d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566617715341651d, y: 0.22465504981958084d), new NpgsqlTypes.NpgsqlPoint(x: 0.38523268480337725d, y: 0.7014757056558096d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035402625884933d, y: 0.022837249592999265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753933122638234d, y: 0.0234716930679445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917505451940783d, y: 0.9586141781510554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6262139667210781d, y: 0.42595234922426717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036302660275451d, y: 0.00435599143065557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7287108903754911d, y: 0.7648620665094702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9854184658398142d, y: 0.6732086754830457d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284322404675738d, y: 0.41140185104766325d), new NpgsqlTypes.NpgsqlPoint(x: 0.15207405830802956d, y: 0.6782067294397084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603529089924363d, y: 0.6802185065556589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6838286504165187d, y: 0.9342333438833287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959564095647354d, y: 0.16563934168674133d), new NpgsqlTypes.NpgsqlPoint(x: 0.17723311291967747d, y: 0.8284397289686761d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6009159587581417d, y: 0.5548755134210224d), new NpgsqlTypes.NpgsqlPoint(x: 0.25459058400898427d, y: 0.6387253875121423d), new NpgsqlTypes.NpgsqlPoint(x: 0.34877710259746564d, y: 0.7661747632911988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17050584500141208d, y: 0.11016872463568117d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486039052445711d, y: 0.43266427477586744d), new NpgsqlTypes.NpgsqlPoint(x: 0.478133791004157d, y: 0.9531209486349072d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8507187856178207d, y: 0.4537162501869524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2824158947682025d, y: 0.5883127371645407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577106860748109d, y: 0.8009480470459837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8106242751227009d, y: 0.12163663033779204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757950702717794d, y: 0.14430694871076855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8756547737380619d, y: 0.666062596156558d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799024654034635d, y: 0.9618461623347717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657082990405212d, y: 0.993658812665352d), new NpgsqlTypes.NpgsqlPoint(x: 0.746082518763732d, y: 0.1011148606210085d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9027064229439407d, y: 0.5499031041233423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8925793363360027d, y: 0.3170102026853263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6717307655470423d, y: 0.5198993757065429d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9082223428795166d, y: 0.8163209282723224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4037570812268956d, y: 0.22874413466138932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784165383926504d, y: 0.09470974329671356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14821119421437268d, y: 0.9163440789886368d), new NpgsqlTypes.NpgsqlPoint(x: 0.25526739392207576d, y: 0.6741240256449091d), new NpgsqlTypes.NpgsqlPoint(x: 0.1225441843552022d, y: 0.8805264346982711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6989507519341425d, y: 0.26290877116742495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4312140438098362d, y: 0.6064052187648774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247388911534036d, y: 0.8697068908424483d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5889469505597399d, y: 0.035873994632415473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619551711851487d, y: 0.7305871828842095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759234770830869d, y: 0.4410469224904895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331003210050528d, y: 0.31541381866965934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5450442232090228d, y: 0.7851150557333243d), new NpgsqlTypes.NpgsqlPoint(x: 0.18517064282401552d, y: 0.576567138682263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2455063847736012d, y: 0.510079323844205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607945779977459d, y: 0.5720405680224988d), new NpgsqlTypes.NpgsqlPoint(x: 0.22468042838289282d, y: 0.6325225265116053d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3319801329451735d, y: 0.6791299587220267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060687709246433d, y: 0.17681423222637893d), new NpgsqlTypes.NpgsqlPoint(x: 0.3593029170521491d, y: 0.21098748379335297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8986340869236584d, y: 0.6183857729535192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078398798017443d, y: 0.3161944447132393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784749737259059d, y: 0.030256155929002437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7252894639145686d, y: 0.8484498309908195d), new NpgsqlTypes.NpgsqlPoint(x: 0.08933753686041224d, y: 0.33788949411304736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528325210013687d, y: 0.4357713047629722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5453288994983163d, y: 0.5902749654417182d), new NpgsqlTypes.NpgsqlPoint(x: 0.944688520582651d, y: 0.5866244247144105d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746168436282904d, y: 0.41746295975014625d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3350397780906259d, y: 0.7061873656998205d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697616497483304d, y: 0.40209777446755346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240147617819982d, y: 0.933447228364108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8969881789327891d, y: 0.30432783920549233d), new NpgsqlTypes.NpgsqlPoint(x: 0.60847742401004d, y: 0.5806321385274075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501325591135551d, y: 0.1061936854555432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8352803024373547d, y: 0.8283057266757482d), new NpgsqlTypes.NpgsqlPoint(x: 0.23438776824660257d, y: 0.5115596054723329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2950132108928565d, y: 0.16879320219120275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915385267439707d, y: 0.9070191609375701d), new NpgsqlTypes.NpgsqlPoint(x: 0.31522803163149327d, y: 0.37452631462751396d), new NpgsqlTypes.NpgsqlPoint(x: 0.27272297525378253d, y: 0.7299080268664733d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6336012060339166d, y: 0.34091778166849795d), new NpgsqlTypes.NpgsqlPoint(x: 0.2946249789354837d, y: 0.4269469579055013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4463051073424996d, y: 0.1728639409715932d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8696408872438423d, y: 0.9041871193799711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945281239161009d, y: 0.6264588894511471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201712022496434d, y: 0.35372452240023655d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22848922156899476d, y: 0.26084510318072507d), new NpgsqlTypes.NpgsqlPoint(x: 0.13638439372353006d, y: 0.8780118452803701d), new NpgsqlTypes.NpgsqlPoint(x: 0.38784213551837077d, y: 0.3948403463939425d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 103;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                parametr2.Value = 24;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 35, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 24, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 60, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 12, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 12, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

