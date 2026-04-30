

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7529269428286822d, b: 0.5210654248317141d, c: 0.8566868399229312d),
new NpgsqlTypes.NpgsqlLine(a: 0.7693484795786973d, b: 0.8358043911427392d, c: 0.4121639020977579d),
new NpgsqlTypes.NpgsqlLine(a: 0.9699116652799286d, b: 0.2803148088050613d, c: 0.6964691342003052d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0668470867387424d, b: 0.8804619347056702d, c: 0.16151740576471674d),
new NpgsqlTypes.NpgsqlLine(a: 0.772462144508972d, b: 0.949815379185953d, c: 0.9484832431698769d),
new NpgsqlTypes.NpgsqlLine(a: 0.39029468459618455d, b: 0.7837384228866382d, c: 0.8146341989661494d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4196433439167768d, b: 0.6835807597425035d, c: 0.8985297832414436d),
new NpgsqlTypes.NpgsqlLine(a: 0.24795085922004967d, b: 0.8567933974370515d, c: 0.3683764812964647d),
new NpgsqlTypes.NpgsqlLine(a: 0.09142983989306463d, b: 0.47199913476096755d, c: 0.5408917894060343d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4082361929372378d, b: 0.5135621468456898d, c: 0.4084746655154088d),
new NpgsqlTypes.NpgsqlLine(a: 0.20570530100323237d, b: 0.36135459977814466d, c: 0.9386838070221947d),
new NpgsqlTypes.NpgsqlLine(a: 0.8217235013536173d, b: 0.7169801681791826d, c: 0.3273540194199589d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7969911096377299d, b: 0.3582744274737969d, c: 0.5096892656172823d),
new NpgsqlTypes.NpgsqlLine(a: 0.4256154013447986d, b: 0.5729546135142501d, c: 0.5678694821036577d),
new NpgsqlTypes.NpgsqlLine(a: 0.04230412405711015d, b: 0.8464574932510001d, c: 0.41882180820992887d),
new NpgsqlTypes.NpgsqlLine(a: 0.3596748400916443d, b: 0.450216237249663d, c: 0.07194613509372316d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23918029809051267d, b: 0.5182015485638365d, c: 0.4475715424109654d),
new NpgsqlTypes.NpgsqlLine(a: 0.8080831758310175d, b: 0.48264340173886533d, c: 0.48750712333109636d),
new NpgsqlTypes.NpgsqlLine(a: 0.7227926822131092d, b: 0.43132559872101994d, c: 0.6158027287968477d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7606605253745157d, b: 0.4459084851960826d, c: 0.08703238654342949d),
new NpgsqlTypes.NpgsqlLine(a: 0.4195720445518827d, b: 0.6534237873811589d, c: 0.8447387059809535d),
new NpgsqlTypes.NpgsqlLine(a: 0.7344227781461526d, b: 0.2836926343195578d, c: 0.4407549955806047d),
new NpgsqlTypes.NpgsqlLine(a: 0.9382883233215902d, b: 0.5006520474936992d, c: 0.4105498690824195d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32214392747933673d, b: 0.43832404729865426d, c: 0.13984565656527514d),
new NpgsqlTypes.NpgsqlLine(a: 0.5652792208150231d, b: 0.701084551839329d, c: 0.683779964036151d),
new NpgsqlTypes.NpgsqlLine(a: 0.6177068111629045d, b: 0.6401156852137313d, c: 0.6504096470316794d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38245967406965187d, b: 0.40379490161191833d, c: 0.2477267204455822d),
new NpgsqlTypes.NpgsqlLine(a: 0.6761484552360116d, b: 0.5311593217617424d, c: 0.7711500228818571d),
new NpgsqlTypes.NpgsqlLine(a: 0.14342232160690005d, b: 0.7905519292195873d, c: 0.09504098212172263d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8827287266309495d, b: 0.6380615850792166d, c: 0.12552843084944354d),
new NpgsqlTypes.NpgsqlLine(a: 0.3997486734482606d, b: 0.5281503731422537d, c: 0.7943642819878988d),
new NpgsqlTypes.NpgsqlLine(a: 0.8934447167875385d, b: 0.4736897947460629d, c: 0.7132711576521678d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5238658170186467d, b: 0.29323498293418027d, c: 0.6200165422964111d),
new NpgsqlTypes.NpgsqlLine(a: 0.8636955896325093d, b: 0.853667760308038d, c: 0.24786342346891033d),
new NpgsqlTypes.NpgsqlLine(a: 0.944734732979514d, b: 0.6859795181155691d, c: 0.5103474609237595d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.680664915545823d, b: 0.2036755617672723d, c: 0.625442143341058d),
new NpgsqlTypes.NpgsqlLine(a: 0.17167439514059668d, b: 0.010039987677225803d, c: 0.3738995179149457d),
new NpgsqlTypes.NpgsqlLine(a: 0.8898549309917817d, b: 0.040837949768367965d, c: 0.4692767413454654d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3012113474659087d, b: 0.6043610221427659d, c: 0.4097129498652414d),
new NpgsqlTypes.NpgsqlLine(a: 0.5999453128863301d, b: 0.42740032223997204d, c: 0.5532870027370251d),
new NpgsqlTypes.NpgsqlLine(a: 0.8857484883498944d, b: 0.4735037034318682d, c: 0.9409961537133232d),
new NpgsqlTypes.NpgsqlLine(a: 0.37314791663906144d, b: 0.6971364767516807d, c: 0.23566067686033365d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8070378159254752d, b: 0.28233224246755395d, c: 0.025344655856559428d),
new NpgsqlTypes.NpgsqlLine(a: 0.6664501265906739d, b: 0.5927727770780206d, c: 0.5248006387934326d),
new NpgsqlTypes.NpgsqlLine(a: 0.3153716554624847d, b: 0.5984282053737543d, c: 0.9896859724014437d),
new NpgsqlTypes.NpgsqlLine(a: 0.9153327393835798d, b: 0.5506885953928844d, c: 0.303631574406931d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.712300743378132d, b: 0.2921657467824763d, c: 0.09236152357352323d),
new NpgsqlTypes.NpgsqlLine(a: 0.029604200311408646d, b: 0.03388320225062469d, c: 0.17571907224691574d),
new NpgsqlTypes.NpgsqlLine(a: 0.4940587557032837d, b: 0.9877859223441905d, c: 0.8417403012277618d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9562562899913291d, b: 0.32590196068146127d, c: 0.3659875233578629d),
new NpgsqlTypes.NpgsqlLine(a: 0.6204225352114506d, b: 0.25000537445035176d, c: 0.931279426778698d),
new NpgsqlTypes.NpgsqlLine(a: 0.22146890308705325d, b: 0.5867318854503789d, c: 0.053341840837637045d),
new NpgsqlTypes.NpgsqlLine(a: 0.772051756410125d, b: 0.8472822082097853d, c: 0.9366965069730127d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9075927762903742d, b: 0.029694225070181157d, c: 0.8369460540134077d),
new NpgsqlTypes.NpgsqlLine(a: 0.7358208030366297d, b: 0.7795284099201297d, c: 0.34191328600639503d),
new NpgsqlTypes.NpgsqlLine(a: 0.7812078960456277d, b: 0.031196713564427325d, c: 0.769956250676226d),
new NpgsqlTypes.NpgsqlLine(a: 0.20748486779752928d, b: 0.6022678239041304d, c: 0.29190963154556715d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14515498691794004d, b: 0.7879820539618893d, c: 0.23672527120467646d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659379242752233d, b: 0.5075367382598522d, c: 0.043166765710067834d),
new NpgsqlTypes.NpgsqlLine(a: 0.9686030749169157d, b: 0.48634344611380753d, c: 0.05651481846694806d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7777509317957451d, b: 0.11178151116476964d, c: 0.6201064647502069d),
new NpgsqlTypes.NpgsqlLine(a: 0.48325577385508345d, b: 0.43183551828697764d, c: 0.47526995238164227d),
new NpgsqlTypes.NpgsqlLine(a: 0.2948491336589206d, b: 0.5290590656779807d, c: 0.347839577811202d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6475181948628713d, b: 0.7983066244035232d, c: 0.7227729747317495d),
new NpgsqlTypes.NpgsqlLine(a: 0.7942762549050434d, b: 0.21192663330626416d, c: 0.19282786259969575d),
new NpgsqlTypes.NpgsqlLine(a: 0.787061282791723d, b: 0.9935135478061308d, c: 0.6165463526787064d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05387743902979525d, b: 0.30363326517914024d, c: 0.6613635974570904d),
new NpgsqlTypes.NpgsqlLine(a: 0.43812970629989745d, b: 0.48854091844244385d, c: 0.9362562984140157d),
new NpgsqlTypes.NpgsqlLine(a: 0.2585096074672111d, b: 0.6439501226126181d, c: 0.1608002549006684d),
new NpgsqlTypes.NpgsqlLine(a: 0.7895307442152812d, b: 0.4568212940761791d, c: 0.6101181561054001d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8719887570179037d, b: 0.48400484854144654d, c: 0.47662811971958075d),
new NpgsqlTypes.NpgsqlLine(a: 0.4841176072039738d, b: 0.7868247386675162d, c: 0.9114741513925462d),
new NpgsqlTypes.NpgsqlLine(a: 0.8788322408870771d, b: 0.15829443022327094d, c: 0.48057087957795075d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5831663764925213d, b: 0.632125429849055d, c: 0.5287782843566788d),
new NpgsqlTypes.NpgsqlLine(a: 0.49487368329474846d, b: 0.01421670152310417d, c: 0.45317146817518017d),
new NpgsqlTypes.NpgsqlLine(a: 0.45782376498535293d, b: 0.11062636877030274d, c: 0.7115313510718946d),
new NpgsqlTypes.NpgsqlLine(a: 0.32246103718651564d, b: 0.4252452052581802d, c: 0.9959387590930783d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9412218439985699d, b: 0.8782117129645562d, c: 0.8080418251439199d),
new NpgsqlTypes.NpgsqlLine(a: 0.5808233108965141d, b: 0.19182020861466065d, c: 0.34296587859118755d),
new NpgsqlTypes.NpgsqlLine(a: 0.7438045979062561d, b: 0.926503674030159d, c: 0.6650492926425489d),
new NpgsqlTypes.NpgsqlLine(a: 0.35120882623746275d, b: 0.36194078757947645d, c: 0.0029762339733002685d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31041382642834403d, b: 0.6090628045126869d, c: 0.39678504691273664d),
new NpgsqlTypes.NpgsqlLine(a: 0.08652047482982528d, b: 0.49766569881735956d, c: 0.8437257671934137d),
new NpgsqlTypes.NpgsqlLine(a: 0.9501764481825878d, b: 0.9973354310010519d, c: 0.9194651735071319d),
new NpgsqlTypes.NpgsqlLine(a: 0.5857788892982172d, b: 0.053213940196027876d, c: 0.5177375554485334d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8112353297298629d, b: 0.08975369907634723d, c: 0.3897214957217162d),
new NpgsqlTypes.NpgsqlLine(a: 0.07623420661779412d, b: 0.28754573385114457d, c: 0.8753115282654068d),
new NpgsqlTypes.NpgsqlLine(a: 0.36380301576637153d, b: 0.047059889544662115d, c: 0.5099283460841116d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8002482815447906d, b: 0.9782250203273058d, c: 0.45458405947758496d),
new NpgsqlTypes.NpgsqlLine(a: 0.14630332867873774d, b: 0.496754724753921d, c: 0.857347313617129d),
new NpgsqlTypes.NpgsqlLine(a: 0.732564309158021d, b: 0.7621312785750206d, c: 0.8699509697470965d),
new NpgsqlTypes.NpgsqlLine(a: 0.7107795071833901d, b: 0.6518659731677866d, c: 0.7769038240277355d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16010697588645317d, b: 0.8004586827926938d, c: 0.788853062880358d),
new NpgsqlTypes.NpgsqlLine(a: 0.16483969051973402d, b: 0.7789109155667009d, c: 0.4761710525465266d),
new NpgsqlTypes.NpgsqlLine(a: 0.9861019168922335d, b: 0.3666459531235774d, c: 0.04656868114901114d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2845864289008351d, b: 0.527827681280073d, c: 0.08491420051690235d),
new NpgsqlTypes.NpgsqlLine(a: 0.8053251616175651d, b: 0.5912255303227993d, c: 0.942576593776085d),
new NpgsqlTypes.NpgsqlLine(a: 0.10380315548777119d, b: 0.42321061100578516d, c: 0.8647623129282012d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11912887513462433d, b: 0.9934693194726119d, c: 0.4514322645250345d),
new NpgsqlTypes.NpgsqlLine(a: 0.9804228923863105d, b: 0.7634282110924588d, c: 0.719724697466032d),
new NpgsqlTypes.NpgsqlLine(a: 0.5178401790063112d, b: 0.5875768882445048d, c: 0.4397858526297639d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6888020189994678d, b: 0.4605207642986838d, c: 0.4834430105077824d),
new NpgsqlTypes.NpgsqlLine(a: 0.7285753862859333d, b: 0.8622275299632088d, c: 0.9235053945155137d),
new NpgsqlTypes.NpgsqlLine(a: 0.5519309613815605d, b: 0.8734821712942137d, c: 0.6584774139970831d),
new NpgsqlTypes.NpgsqlLine(a: 0.00236328444842826d, b: 0.21991702943665048d, c: 0.9895216773186981d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4268602682249516d, b: 0.2015426768320927d, c: 0.33021452172884735d),
new NpgsqlTypes.NpgsqlLine(a: 0.9611846099886506d, b: 0.6684875630594546d, c: 0.2344901138677401d),
new NpgsqlTypes.NpgsqlLine(a: 0.7991914003466148d, b: 0.49122691720783696d, c: 0.7332296624106133d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1998236114311478d, b: 0.8296606846717643d, c: 0.19832235663650088d),
new NpgsqlTypes.NpgsqlLine(a: 0.656986463913779d, b: 0.6862494874920907d, c: 0.6448705101297648d),
new NpgsqlTypes.NpgsqlLine(a: 0.35312636349140747d, b: 0.7210956783993226d, c: 0.2825763327935761d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8684120477415689d, b: 0.9959405275112598d, c: 0.522884599032097d),
new NpgsqlTypes.NpgsqlLine(a: 0.8896598187313897d, b: 0.43339055740523913d, c: 0.6534521146464635d),
new NpgsqlTypes.NpgsqlLine(a: 0.8862331901242233d, b: 0.41929057705559847d, c: 0.7729642626862553d),
new NpgsqlTypes.NpgsqlLine(a: 0.4670843659897287d, b: 0.19657353412174383d, c: 0.20039525976984984d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7004982513060368d, b: 0.8335159771111554d, c: 0.8213079053299294d),
new NpgsqlTypes.NpgsqlLine(a: 0.5064758476229451d, b: 0.9753011458644156d, c: 0.957873753508679d),
new NpgsqlTypes.NpgsqlLine(a: 0.7285603745209634d, b: 0.7289183320733283d, c: 0.5019141723884656d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7971186383160871d, b: 0.4445430507523792d, c: 0.6234315667071308d),
new NpgsqlTypes.NpgsqlLine(a: 0.18563184669420874d, b: 0.6576416786577591d, c: 0.6053249388230978d),
new NpgsqlTypes.NpgsqlLine(a: 0.2130917092293918d, b: 0.03724083970441727d, c: 0.6600959962169005d),
new NpgsqlTypes.NpgsqlLine(a: 0.3702677403982728d, b: 0.8250005045130852d, c: 0.40774998232658743d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8242880589470456d, b: 0.4150827238197158d, c: 0.0652089980598638d),
new NpgsqlTypes.NpgsqlLine(a: 0.0656637355886811d, b: 0.7651165958242933d, c: 0.6035022437708154d),
new NpgsqlTypes.NpgsqlLine(a: 0.08864063091525365d, b: 0.37492300195670447d, c: 0.8077988592394498d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14240329560365927d, b: 0.6853624445758045d, c: 0.39268409893390244d),
new NpgsqlTypes.NpgsqlLine(a: 0.006894844741402006d, b: 0.5919303314699883d, c: 0.5438646926971121d),
new NpgsqlTypes.NpgsqlLine(a: 0.6394725618858946d, b: 0.7049706894839618d, c: 0.0588936529529156d),
new NpgsqlTypes.NpgsqlLine(a: 0.03845810469668198d, b: 0.4568714848003512d, c: 0.9928563454299306d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3088224244019322d, b: 0.2970532954783681d, c: 0.5260578881073487d),
new NpgsqlTypes.NpgsqlLine(a: 0.33945255265229424d, b: 0.38132883825475083d, c: 0.8494889079765805d),
new NpgsqlTypes.NpgsqlLine(a: 0.02557161498189875d, b: 0.4819167582341035d, c: 0.6376319422691623d),
new NpgsqlTypes.NpgsqlLine(a: 0.6888122637271479d, b: 0.32270933974638494d, c: 0.2290727889790356d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7117037310085065d, b: 0.37588298660130925d, c: 0.5496828928232631d),
new NpgsqlTypes.NpgsqlLine(a: 0.13602800297279038d, b: 0.8745685494755056d, c: 0.18142327033725003d),
new NpgsqlTypes.NpgsqlLine(a: 0.47512368247459325d, b: 0.3621964549467521d, c: 0.014868692127247507d),
new NpgsqlTypes.NpgsqlLine(a: 0.5323430993520789d, b: 0.5990872424372607d, c: 0.623713012769355d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24330329190565836d, b: 0.8335238253661836d, c: 0.2751559450589588d),
new NpgsqlTypes.NpgsqlLine(a: 0.1511302048409633d, b: 0.4775830756578596d, c: 0.14722447721521903d),
new NpgsqlTypes.NpgsqlLine(a: 0.2952234746539413d, b: 0.9486018517277742d, c: 0.8235375754111397d),
new NpgsqlTypes.NpgsqlLine(a: 0.941295126162534d, b: 0.7170896484784796d, c: 0.4301831508934829d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3392992355646355d, b: 0.2229460778823945d, c: 0.5641882600757783d),
new NpgsqlTypes.NpgsqlLine(a: 0.07465046244412843d, b: 0.11445288659683994d, c: 0.058511978060455605d),
new NpgsqlTypes.NpgsqlLine(a: 0.547656345332037d, b: 0.7096635460099554d, c: 0.45835653103879936d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39573492580638236d, b: 0.22931238205737892d, c: 0.5509819217557528d),
new NpgsqlTypes.NpgsqlLine(a: 0.6670719554085691d, b: 0.9114667342227498d, c: 0.16105361047913624d),
new NpgsqlTypes.NpgsqlLine(a: 0.20071476989766224d, b: 0.3166217306759114d, c: 0.3490446887458776d),
new NpgsqlTypes.NpgsqlLine(a: 0.20441602977358375d, b: 0.3008269305148097d, c: 0.8803522194971081d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8779979663339781d, b: 0.17863549623990915d, c: 0.8525891519703062d),
new NpgsqlTypes.NpgsqlLine(a: 0.8883385394466006d, b: 0.018048365093333407d, c: 0.7708575671669683d),
new NpgsqlTypes.NpgsqlLine(a: 0.20656303969469125d, b: 0.10940765824450793d, c: 0.9402808816419682d),
new NpgsqlTypes.NpgsqlLine(a: 0.7312741428924593d, b: 0.3703050395688491d, c: 0.2297842279366541d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6139776779653606d, b: 0.6653314273900849d, c: 0.69225797115577d),
new NpgsqlTypes.NpgsqlLine(a: 0.9704571466985471d, b: 0.13644360766200225d, c: 0.9077979389482236d),
new NpgsqlTypes.NpgsqlLine(a: 0.88529019906329d, b: 0.3780320759438184d, c: 0.6770482395828615d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8624276347652002d, b: 0.22416737861227898d, c: 0.8119069916843085d),
new NpgsqlTypes.NpgsqlLine(a: 0.7158666868503266d, b: 0.38868466182491235d, c: 0.4781265153839458d),
new NpgsqlTypes.NpgsqlLine(a: 0.9488265642916986d, b: 0.8308667700323599d, c: 0.059318816461833346d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08197444947470012d, b: 0.964235388132402d, c: 0.7203826236794595d),
new NpgsqlTypes.NpgsqlLine(a: 0.15831849189333014d, b: 0.4812895412996536d, c: 0.5686055748185466d),
new NpgsqlTypes.NpgsqlLine(a: 0.038920946302681725d, b: 0.4609571804178043d, c: 0.5422479339669283d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6494955564206485d, b: 0.9648368610759199d, c: 0.6948317719230173d),
new NpgsqlTypes.NpgsqlLine(a: 0.2078984818366525d, b: 0.2044614748616227d, c: 0.6066024120171808d),
new NpgsqlTypes.NpgsqlLine(a: 0.532316978470093d, b: 0.29395997674366514d, c: 0.007081887297499145d),
new NpgsqlTypes.NpgsqlLine(a: 0.17221206817878265d, b: 0.2993794603649229d, c: 0.400180969874941d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08750485712280609d, b: 0.2941419279023295d, c: 0.2063752810392222d),
new NpgsqlTypes.NpgsqlLine(a: 0.587688341936191d, b: 0.2598038139938036d, c: 0.6435317536637659d),
new NpgsqlTypes.NpgsqlLine(a: 0.42943978271963756d, b: 0.5929817581304392d, c: 0.947182767235501d),
new NpgsqlTypes.NpgsqlLine(a: 0.8919538843745971d, b: 0.9237248902096228d, c: 0.5417773678465166d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18046600642802724d, b: 0.3610614670538027d, c: 0.1489650638450064d),
new NpgsqlTypes.NpgsqlLine(a: 0.8271071488558157d, b: 0.053386244484308065d, c: 0.6311654704972478d),
new NpgsqlTypes.NpgsqlLine(a: 0.8376763979233539d, b: 0.9835571395934155d, c: 0.8952288553540877d),
new NpgsqlTypes.NpgsqlLine(a: 0.4651278773855386d, b: 0.2798758722407436d, c: 0.9715721874070712d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5860787512396606d, b: 0.7022638564850044d, c: 0.8997771562119219d),
new NpgsqlTypes.NpgsqlLine(a: 0.576759250884936d, b: 0.5176272042285567d, c: 0.7202005847414333d),
new NpgsqlTypes.NpgsqlLine(a: 0.9718286593079207d, b: 0.2125640836402164d, c: 0.7434037339045351d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2810738998830441d, b: 0.744392038059475d, c: 0.002336367457589361d),
new NpgsqlTypes.NpgsqlLine(a: 0.5569339986741415d, b: 0.7590274017677461d, c: 0.3719156555378479d),
new NpgsqlTypes.NpgsqlLine(a: 0.5443296426741449d, b: 0.44176545671593226d, c: 0.5190091135898255d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9547459075693978d, b: 0.4934972729837831d, c: 0.5848325635934589d),
new NpgsqlTypes.NpgsqlLine(a: 0.8661906337470486d, b: 0.2578941808322597d, c: 0.9169698470496117d),
new NpgsqlTypes.NpgsqlLine(a: 0.6885228711790209d, b: 0.32334078911844855d, c: 0.48481155933314d),
new NpgsqlTypes.NpgsqlLine(a: 0.2846253979281924d, b: 0.36268435730107185d, c: 0.021817686990493024d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2486709962952418d, b: 0.9654957657755607d, c: 0.7626030436884008d),
new NpgsqlTypes.NpgsqlLine(a: 0.8705888301205523d, b: 0.3821769012675753d, c: 0.3790066693723878d),
new NpgsqlTypes.NpgsqlLine(a: 0.09826382844479153d, b: 0.20359255197261739d, c: 0.6560080841247443d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17518646694455486d, b: 0.23351057833890043d, c: 0.41511737925016745d),
new NpgsqlTypes.NpgsqlLine(a: 0.0014204653581851856d, b: 0.40985920097053263d, c: 0.5182397645877045d),
new NpgsqlTypes.NpgsqlLine(a: 0.1183809178459091d, b: 0.9319402805899502d, c: 0.5126070912410386d),
new NpgsqlTypes.NpgsqlLine(a: 0.7598193945985818d, b: 0.9786649825653528d, c: 0.9924225076978855d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24269715036625683d, b: 0.16244609958906187d, c: 0.7084182733990629d),
new NpgsqlTypes.NpgsqlLine(a: 0.31539590820054064d, b: 0.7150145663155699d, c: 0.006423909047882925d),
new NpgsqlTypes.NpgsqlLine(a: 0.8794918532824455d, b: 0.22648642487604054d, c: 0.6337251643726651d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7095702137769937d, b: 0.2168767041101345d, c: 0.23844353864408585d),
new NpgsqlTypes.NpgsqlLine(a: 0.7993774968364707d, b: 0.04974661959277582d, c: 0.4288966326381829d),
new NpgsqlTypes.NpgsqlLine(a: 0.048101038262646334d, b: 0.384032838860499d, c: 0.6204813253734385d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8419592684461071d, b: 0.02407685720243169d, c: 0.4187594862114524d),
new NpgsqlTypes.NpgsqlLine(a: 0.5626083938809984d, b: 0.5320397636619062d, c: 0.7309498018308768d),
new NpgsqlTypes.NpgsqlLine(a: 0.8406263007908186d, b: 0.8932043740601411d, c: 0.507020655300422d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11834571048979392d, b: 0.8434540202949194d, c: 0.4604353988206892d),
new NpgsqlTypes.NpgsqlLine(a: 0.6947000119044002d, b: 0.2168479615525164d, c: 0.8103375619351276d),
new NpgsqlTypes.NpgsqlLine(a: 0.3002013152804124d, b: 0.15953040502500027d, c: 0.7285640886273999d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4621094666693818d, b: 0.288765373156476d, c: 0.06204187658578908d),
new NpgsqlTypes.NpgsqlLine(a: 0.6489375459762808d, b: 0.09837787928938413d, c: 0.7885023449465405d),
new NpgsqlTypes.NpgsqlLine(a: 0.9129453564768082d, b: 0.6506506360065123d, c: 0.8840395109262728d),
new NpgsqlTypes.NpgsqlLine(a: 0.724609793963039d, b: 0.278428067586331d, c: 0.7516170606304178d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03249732074231826d, b: 0.3259190807740414d, c: 0.31819824448991074d),
new NpgsqlTypes.NpgsqlLine(a: 0.6247253879658594d, b: 0.20052891991765998d, c: 0.5892015172426771d),
new NpgsqlTypes.NpgsqlLine(a: 0.3156498089567712d, b: 0.5101394600354672d, c: 0.22346823385491188d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10567994135440206d, b: 0.6056801302830429d, c: 0.6933699819375169d),
new NpgsqlTypes.NpgsqlLine(a: 0.4804819566880889d, b: 0.5029901428083006d, c: 0.8010295488169256d),
new NpgsqlTypes.NpgsqlLine(a: 0.5615503611017066d, b: 0.16111877267900832d, c: 0.9108653269799606d),
new NpgsqlTypes.NpgsqlLine(a: 0.2966387311056313d, b: 0.11736091234259283d, c: 0.6734314606272315d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9766246941033901d, b: 0.021128863978140178d, c: 0.968482275583499d),
new NpgsqlTypes.NpgsqlLine(a: 0.7048697272852169d, b: 0.7288223913887021d, c: 0.8139324198565422d),
new NpgsqlTypes.NpgsqlLine(a: 0.6917130137869751d, b: 0.2603064574030791d, c: 0.4434327162819741d),
new NpgsqlTypes.NpgsqlLine(a: 0.7692760344750288d, b: 0.4139100570238363d, c: 0.30230641692252325d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.822310399569013d, b: 0.35682092397915977d, c: 0.5374337640736403d),
new NpgsqlTypes.NpgsqlLine(a: 0.500495088084229d, b: 0.3611707312717045d, c: 0.4393020689670316d),
new NpgsqlTypes.NpgsqlLine(a: 0.1843706125582999d, b: 0.6726583473000973d, c: 0.6759946003608496d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24945623078589352d, b: 0.31197839314246445d, c: 0.3911213671463051d),
new NpgsqlTypes.NpgsqlLine(a: 0.4242702383941027d, b: 0.08458279104609234d, c: 0.00336780343589671d),
new NpgsqlTypes.NpgsqlLine(a: 0.26110688582058805d, b: 0.4394958287836318d, c: 0.29107512934850677d),
new NpgsqlTypes.NpgsqlLine(a: 0.6297623606931972d, b: 0.6968895068351477d, c: 0.6222828420308091d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9811654449936551d, b: 0.3619366361947922d, c: 0.29174290526284863d),
new NpgsqlTypes.NpgsqlLine(a: 0.62903255092078d, b: 0.3958622547140115d, c: 0.2946167475067073d),
new NpgsqlTypes.NpgsqlLine(a: 0.18060299948727443d, b: 0.7029066083939624d, c: 0.32767796727574117d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7545495682706648d, b: 0.7966999965024887d, c: 0.19663092004879423d),
new NpgsqlTypes.NpgsqlLine(a: 0.4809842353358018d, b: 0.1683997374750248d, c: 0.21244754842101832d),
new NpgsqlTypes.NpgsqlLine(a: 0.8395521774954423d, b: 0.7225272545442708d, c: 0.5856560860996669d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8962760780910312d, b: 0.17985256272541572d, c: 0.17903221794578428d),
new NpgsqlTypes.NpgsqlLine(a: 0.7724149967964543d, b: 0.7149116653930133d, c: 0.19122139711036223d),
new NpgsqlTypes.NpgsqlLine(a: 0.919261523631828d, b: 0.5760909503019733d, c: 0.6473476943540115d),
new NpgsqlTypes.NpgsqlLine(a: 0.3852884354578161d, b: 0.7017629262410244d, c: 0.12035465062607742d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6184615834026325d, b: 0.551002201575705d, c: 0.978488506086005d),
new NpgsqlTypes.NpgsqlLine(a: 0.4191936540646861d, b: 0.472292827459744d, c: 0.1454147436938633d),
new NpgsqlTypes.NpgsqlLine(a: 0.02856577584367348d, b: 0.6806310789431042d, c: 0.2105361124897287d),
new NpgsqlTypes.NpgsqlLine(a: 0.19268869631196528d, b: 0.7835389042204972d, c: 0.500332822781693d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03627854389999452d, b: 0.9646717005908183d, c: 0.9279199088593474d),
new NpgsqlTypes.NpgsqlLine(a: 0.15229439800601785d, b: 0.5946155293296375d, c: 0.2045991052173871d),
new NpgsqlTypes.NpgsqlLine(a: 0.7315939443234281d, b: 0.2843618541928179d, c: 0.8181874947101074d),
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
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5238658170186467d, b: 0.29323498293418027d, c: 0.6200165422964111d),
new NpgsqlTypes.NpgsqlLine(a: 0.8636955896325093d, b: 0.853667760308038d, c: 0.24786342346891033d),
new NpgsqlTypes.NpgsqlLine(a: 0.944734732979514d, b: 0.6859795181155691d, c: 0.5103474609237595d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.712300743378132d, b: 0.2921657467824763d, c: 0.09236152357352323d),
new NpgsqlTypes.NpgsqlLine(a: 0.029604200311408646d, b: 0.03388320225062469d, c: 0.17571907224691574d),
new NpgsqlTypes.NpgsqlLine(a: 0.4940587557032837d, b: 0.9877859223441905d, c: 0.8417403012277618d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9075927762903742d, b: 0.029694225070181157d, c: 0.8369460540134077d),
new NpgsqlTypes.NpgsqlLine(a: 0.7358208030366297d, b: 0.7795284099201297d, c: 0.34191328600639503d),
new NpgsqlTypes.NpgsqlLine(a: 0.7812078960456277d, b: 0.031196713564427325d, c: 0.769956250676226d),
new NpgsqlTypes.NpgsqlLine(a: 0.20748486779752928d, b: 0.6022678239041304d, c: 0.29190963154556715d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05387743902979525d, b: 0.30363326517914024d, c: 0.6613635974570904d),
new NpgsqlTypes.NpgsqlLine(a: 0.43812970629989745d, b: 0.48854091844244385d, c: 0.9362562984140157d),
new NpgsqlTypes.NpgsqlLine(a: 0.2585096074672111d, b: 0.6439501226126181d, c: 0.1608002549006684d),
new NpgsqlTypes.NpgsqlLine(a: 0.7895307442152812d, b: 0.4568212940761791d, c: 0.6101181561054001d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8112353297298629d, b: 0.08975369907634723d, c: 0.3897214957217162d),
new NpgsqlTypes.NpgsqlLine(a: 0.07623420661779412d, b: 0.28754573385114457d, c: 0.8753115282654068d),
new NpgsqlTypes.NpgsqlLine(a: 0.36380301576637153d, b: 0.047059889544662115d, c: 0.5099283460841116d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 42, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 42, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 20, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 33, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 6, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 35, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

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
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

