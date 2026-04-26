

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17187442871610992d, y: 0.02434523061382521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379984132474926d, y: 0.9384088612107814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687812351669398d, y: 0.2573722489117295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9014958548602909d, y: 0.441111988215362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705311436197358d, y: 0.32042903013082547d), new NpgsqlTypes.NpgsqlPoint(x: 0.16466647941975188d, y: 0.07801646507382276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8153263258705049d, y: 0.7222240038646889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9990773001631394d, y: 0.7096831064444035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690341222362338d, y: 0.08418519197010244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9523219682433408d, y: 0.2645890437978743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920356001431505d, y: 0.5144571349747803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560511637936938d, y: 0.49226512918675125d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20331491613743446d, y: 0.36736806990980186d), new NpgsqlTypes.NpgsqlPoint(x: 0.21070494687610952d, y: 0.7890076823876926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593435976022453d, y: 0.713789995069323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816367215999211d, y: 0.5790980131442859d), new NpgsqlTypes.NpgsqlPoint(x: 0.04789715833239383d, y: 0.9106744026421832d), new NpgsqlTypes.NpgsqlPoint(x: 0.06165671732659317d, y: 0.87526735739909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284606198745612d, y: 0.8985346990986793d), new NpgsqlTypes.NpgsqlPoint(x: 0.1893370350167719d, y: 0.21425027601903424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045924614258253d, y: 0.8177331608553167d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878760928027452d, y: 0.8941691434989546d), new NpgsqlTypes.NpgsqlPoint(x: 0.19097457485550418d, y: 0.6740388115356469d), new NpgsqlTypes.NpgsqlPoint(x: 0.3743866474691533d, y: 0.9617314376650786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9508646287731646d, y: 0.8632845558836122d), new NpgsqlTypes.NpgsqlPoint(x: 0.09832574029486396d, y: 0.2894490905991579d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529756866484467d, y: 0.7297114259015746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6448896146316554d, y: 0.2517907219673914d), new NpgsqlTypes.NpgsqlPoint(x: 0.39052412426814287d, y: 0.6499236670670724d), new NpgsqlTypes.NpgsqlPoint(x: 0.02913053846239555d, y: 0.32045469362685075d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2352395806298353d, y: 0.4039362705116003d), new NpgsqlTypes.NpgsqlPoint(x: 0.12009294162754192d, y: 0.13648583534376268d), new NpgsqlTypes.NpgsqlPoint(x: 0.31762991874360735d, y: 0.7881214404878508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5561544562923463d, y: 0.4439351766732801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310755221238077d, y: 0.8345883284833592d), new NpgsqlTypes.NpgsqlPoint(x: 0.07172749387497956d, y: 0.8445266262187421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0744953579617893d, y: 0.10260748889667393d), new NpgsqlTypes.NpgsqlPoint(x: 0.32799799125516993d, y: 0.6522715779981894d), new NpgsqlTypes.NpgsqlPoint(x: 0.28791450866960233d, y: 0.3522445485879948d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1639299428801434d, y: 0.7282840795505191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964485560797757d, y: 0.8447679762920208d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969923218752249d, y: 0.14433609760274968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6840050288443702d, y: 0.18361267494067235d), new NpgsqlTypes.NpgsqlPoint(x: 0.08269832182573089d, y: 0.5058129544516179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242274455713752d, y: 0.7296218858854205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8669651727858427d, y: 0.9458328917687525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060648622924767d, y: 0.7840005486603356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6680121405549471d, y: 0.4748546596181651d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19848307536977916d, y: 0.2687069230067435d), new NpgsqlTypes.NpgsqlPoint(x: 0.993763214126029d, y: 0.969698616261145d), new NpgsqlTypes.NpgsqlPoint(x: 0.08659729850674758d, y: 0.8197699109506407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546419636483856d, y: 0.6932087801374894d), new NpgsqlTypes.NpgsqlPoint(x: 0.577415193746063d, y: 0.7167857857140602d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357289260256883d, y: 0.35039120717443883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.914738592101592d, y: 0.5280115241329625d), new NpgsqlTypes.NpgsqlPoint(x: 0.40229073604598153d, y: 0.21229251237547042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029746475536963d, y: 0.31291217498362245d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5328340090401356d, y: 0.7526015655616085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648229232273925d, y: 0.8351659829235826d), new NpgsqlTypes.NpgsqlPoint(x: 0.2787169182696704d, y: 0.8893083244490202d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7769552347558711d, y: 0.7962396281645886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034495679375258d, y: 0.8706087458063866d), new NpgsqlTypes.NpgsqlPoint(x: 0.007607694092738315d, y: 0.12912386281333088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7072473990907301d, y: 0.8588504303442481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104093313732187d, y: 0.2117039002233585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3407910231476674d, y: 0.8680033949069332d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7586473481764002d, y: 0.27736852983812066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3859230092182142d, y: 0.117643831397649d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528895100436912d, y: 0.12728226280113752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8888325463400354d, y: 0.8806882558397212d), new NpgsqlTypes.NpgsqlPoint(x: 0.03772026241276172d, y: 0.4381269599487768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377239562119513d, y: 0.23089447247292139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15359250126195467d, y: 0.9040181978269491d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523273459033333d, y: 0.43572102981098526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946988923430512d, y: 0.42237910183824856d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43962537393795653d, y: 0.2945980869340533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956786081965797d, y: 0.8023148589444329d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454804818819452d, y: 0.7820542788274036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6703032504217494d, y: 0.27030150718659474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091861395273295d, y: 0.11182944982020371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732085477668998d, y: 0.9187473894431307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.887940305517643d, y: 0.28922982560954125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733470648180578d, y: 0.41335295737126565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247680801975477d, y: 0.40168320483882736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07992601982642711d, y: 0.5721973086843533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798608904754578d, y: 0.7096552388135728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5458249547319032d, y: 0.5922674248696942d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16189096782174095d, y: 0.013252960663922564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748587051693074d, y: 0.11868105974390175d), new NpgsqlTypes.NpgsqlPoint(x: 0.1346073860134952d, y: 0.31932045626559424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7273343030597716d, y: 0.8453851118463754d), new NpgsqlTypes.NpgsqlPoint(x: 0.866808764538464d, y: 0.5289482543791436d), new NpgsqlTypes.NpgsqlPoint(x: 0.038802364215882346d, y: 0.2257735049643801d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04632935943297933d, y: 0.4599972365248225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645319823796559d, y: 0.3263876452316151d), new NpgsqlTypes.NpgsqlPoint(x: 0.1663901231742787d, y: 0.8164133310409148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.700000892691851d, y: 0.8183977333705443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252977287605588d, y: 0.7273673275187071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968451371597059d, y: 0.8772916977404868d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8617716205999489d, y: 0.6669841317875731d), new NpgsqlTypes.NpgsqlPoint(x: 0.13052809457277836d, y: 0.3214901569783656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639479336060465d, y: 0.6048283995168875d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31251477928386906d, y: 0.04387868995831068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136595967818205d, y: 0.6016399849395015d), new NpgsqlTypes.NpgsqlPoint(x: 0.625222738185233d, y: 0.008561198638171286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4826972236498377d, y: 0.5840737404406559d), new NpgsqlTypes.NpgsqlPoint(x: 0.46221660623130234d, y: 0.444286355988609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9950359026839288d, y: 0.5278480734127149d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51986786911029d, y: 0.8590587354428522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757656952489717d, y: 0.8118766386165898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4667015356935401d, y: 0.025530300773843217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.404507966402224d, y: 0.543214325718739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5791131642448217d, y: 0.1233018483993421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105636031116967d, y: 0.1829545111119799d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8673440380869288d, y: 0.39774594829174426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152861954595411d, y: 0.9527336716285764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904171198517827d, y: 0.9917240471088486d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6906112089606405d, y: 0.3817089003318016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086459380486421d, y: 0.7690216657819328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5787577687992002d, y: 0.823472396336242d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5140855688693212d, y: 0.9730123303882164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088238374755678d, y: 0.8356357065402885d), new NpgsqlTypes.NpgsqlPoint(x: 0.19050826782597796d, y: 0.8583758610683815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2793155595811756d, y: 0.17906842310050863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279473247338248d, y: 0.6450824172248947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984412880986578d, y: 0.1039207367844941d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7678106158019619d, y: 0.9828696590106177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799792580818222d, y: 0.35018372904213424d), new NpgsqlTypes.NpgsqlPoint(x: 0.35810750695966487d, y: 0.1627653340657339d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6790644550567568d, y: 0.041758154951087256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271184745901005d, y: 0.21043183758497297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483472242965707d, y: 0.6584281833643104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387733466074932d, y: 0.9952688399202515d), new NpgsqlTypes.NpgsqlPoint(x: 0.920448579055156d, y: 0.24977516673916078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432749831296253d, y: 0.1343049428261177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7279129932217269d, y: 0.7050664521110096d), new NpgsqlTypes.NpgsqlPoint(x: 0.24980583659558853d, y: 0.49796325821565646d), new NpgsqlTypes.NpgsqlPoint(x: 0.42412117287637097d, y: 0.5708932499451236d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21804094587954548d, y: 0.18027770233405338d), new NpgsqlTypes.NpgsqlPoint(x: 0.494386275747169d, y: 0.28885502389016704d), new NpgsqlTypes.NpgsqlPoint(x: 0.11481331600265166d, y: 0.3992821965292417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8046869927817175d, y: 0.5815664326303236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4655401771835611d, y: 0.05810568153815254d), new NpgsqlTypes.NpgsqlPoint(x: 0.21794736737867504d, y: 0.29270028390040626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21883332892807106d, y: 0.41028019235224467d), new NpgsqlTypes.NpgsqlPoint(x: 0.284948343022552d, y: 0.06171253665383436d), new NpgsqlTypes.NpgsqlPoint(x: 0.27965428535304737d, y: 0.5668414954844715d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11766233461621445d, y: 0.09773905715927689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2407044689721658d, y: 0.12340393367081237d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809687104687702d, y: 0.007744841614374054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9798846340195257d, y: 0.09697596021449373d), new NpgsqlTypes.NpgsqlPoint(x: 0.6942916131502712d, y: 0.5761492109536351d), new NpgsqlTypes.NpgsqlPoint(x: 0.17185695566097126d, y: 0.7235918261079604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32904547367298864d, y: 0.13563573656167538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5963474384775188d, y: 0.1077115301800522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045368753963815d, y: 0.0792893482375171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14563583004656167d, y: 0.8414237901274737d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814594968857618d, y: 0.285737282897237d), new NpgsqlTypes.NpgsqlPoint(x: 0.035715112898783374d, y: 0.3810658543342472d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12265592405631731d, y: 0.35768152710592127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916893070028245d, y: 0.09873803988678886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5736675243839167d, y: 0.00847215589154604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7587236021157477d, y: 0.6108083672658067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8862313915655363d, y: 0.9061619129841125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788175147628056d, y: 0.5738243522498444d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20640679815105156d, y: 0.2901556318291598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6188144363724744d, y: 0.17402058319918978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555244534661418d, y: 0.7652067212407392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8234505486743877d, y: 0.7992610522091397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513352067113633d, y: 0.7015200092102233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798987752195083d, y: 0.6397783391660636d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48656121765166205d, y: 0.695867114346477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618248213248543d, y: 0.23751586646850542d), new NpgsqlTypes.NpgsqlPoint(x: 0.39336994964506466d, y: 0.40579010284503814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5215841845922109d, y: 0.6120315656750861d), new NpgsqlTypes.NpgsqlPoint(x: 0.734244513217666d, y: 0.2894503293747709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025338756257254d, y: 0.5906449371389974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5856494876724585d, y: 0.8370604060599997d), new NpgsqlTypes.NpgsqlPoint(x: 0.36874373351882284d, y: 0.6071798030752894d), new NpgsqlTypes.NpgsqlPoint(x: 0.06685410971986905d, y: 0.7574177671127165d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9241282796928028d, y: 0.8317731584255644d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431678012511186d, y: 0.21137528206788792d), new NpgsqlTypes.NpgsqlPoint(x: 0.15510805780104742d, y: 0.9952077794621648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10490374990745599d, y: 0.2963469275498407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034036983677291d, y: 0.48552826059911125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033327170373524d, y: 0.2164431649652122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7157214254217251d, y: 0.13512777741024418d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800867390932631d, y: 0.707726259869318d), new NpgsqlTypes.NpgsqlPoint(x: 0.530509908313083d, y: 0.9047200069127426d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7063123880758255d, y: 0.911673831137876d), new NpgsqlTypes.NpgsqlPoint(x: 0.977309237848017d, y: 0.7917992105954504d), new NpgsqlTypes.NpgsqlPoint(x: 0.31942185189389816d, y: 0.3552318989681037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1533209885322001d, y: 0.9907797356681897d), new NpgsqlTypes.NpgsqlPoint(x: 0.18847465570364896d, y: 0.2925579534587507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199173199002117d, y: 0.2786898671759461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5457232217048926d, y: 0.8125418785113667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765815426550831d, y: 0.12694553130697017d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804869954616538d, y: 0.09410691571709695d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05895217488634874d, y: 0.08874989100248398d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891119546299994d, y: 0.31729076243234333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2169198682190826d, y: 0.44572463186258937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03686579634199649d, y: 0.38678046652428044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597359294465153d, y: 0.9141750225216283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8308078549108667d, y: 0.7534144006147736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8428948756400269d, y: 0.3686063349009391d), new NpgsqlTypes.NpgsqlPoint(x: 0.09301996374695576d, y: 0.5309450265452634d), new NpgsqlTypes.NpgsqlPoint(x: 0.962892165674534d, y: 0.25198343146794966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9408218025279023d, y: 0.8547721851067333d), new NpgsqlTypes.NpgsqlPoint(x: 0.06049119055875474d, y: 0.5062728688692326d), new NpgsqlTypes.NpgsqlPoint(x: 0.016594674798876996d, y: 0.278503331991922d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8637635099400918d, y: 0.9408920482998213d), new NpgsqlTypes.NpgsqlPoint(x: 0.25654048346711666d, y: 0.02518371659596952d), new NpgsqlTypes.NpgsqlPoint(x: 0.2119194607807411d, y: 0.8994257625211735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28770860928897146d, y: 0.17390920704796164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168638860560595d, y: 0.3286170902155796d), new NpgsqlTypes.NpgsqlPoint(x: 0.50788666091691d, y: 0.8887737456976575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29473321062279534d, y: 0.2770766538021596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159526632257891d, y: 0.21583746931058234d), new NpgsqlTypes.NpgsqlPoint(x: 0.45833655954353403d, y: 0.28023721520967326d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3821993707628981d, y: 0.26247466532848607d), new NpgsqlTypes.NpgsqlPoint(x: 0.16022978105205032d, y: 0.14079880473879147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023283783418093d, y: 0.7702710947176822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.530302496756781d, y: 0.7597220523753372d), new NpgsqlTypes.NpgsqlPoint(x: 0.2710956522255574d, y: 0.7455818078486594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4381559859597387d, y: 0.8124787865103755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07472774029869955d, y: 0.5277451132916845d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266694378086484d, y: 0.533577742198387d), new NpgsqlTypes.NpgsqlPoint(x: 0.58103481187199d, y: 0.4035205894283672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5228839296844059d, y: 0.39341062525283044d), new NpgsqlTypes.NpgsqlPoint(x: 0.22369111901602745d, y: 0.050647089248089805d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357748753344259d, y: 0.7211415074303564d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703905779514223d, y: 0.18489646911461632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376180422603359d, y: 0.6535252884753264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274640830689365d, y: 0.2605588289341527d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9212449331396318d, y: 0.9406610135122403d), new NpgsqlTypes.NpgsqlPoint(x: 0.25027497116227704d, y: 0.1959241523740316d), new NpgsqlTypes.NpgsqlPoint(x: 0.651149396554024d, y: 0.3725363951138093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4847863186416863d, y: 0.6767134053712073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270003331622816d, y: 0.521166462249463d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669546491930716d, y: 0.4691334370442872d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4820962729487407d, y: 0.45592756386851774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182533823489009d, y: 0.44470829416378843d), new NpgsqlTypes.NpgsqlPoint(x: 0.43383076556501854d, y: 0.9083918567276013d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3114265983513804d, y: 0.3780152196483457d), new NpgsqlTypes.NpgsqlPoint(x: 0.12763943954405066d, y: 0.8074348277833401d), new NpgsqlTypes.NpgsqlPoint(x: 0.65609118989818d, y: 0.09642944231735673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7579776302156424d, y: 0.29770032100220356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984237695538218d, y: 0.35855540886212034d), new NpgsqlTypes.NpgsqlPoint(x: 0.14670933897277216d, y: 0.1795936538605073d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4687051354682584d, y: 0.12399604034204625d), new NpgsqlTypes.NpgsqlPoint(x: 0.02986641105681931d, y: 0.8186868574953263d), new NpgsqlTypes.NpgsqlPoint(x: 0.02370254658389892d, y: 0.6158493951164051d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.658417369373999d, y: 0.7623098998740697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197140792159d, y: 0.682752385441082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004087167706529d, y: 0.5024892208188954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6063595444454368d, y: 0.3334933049213392d), new NpgsqlTypes.NpgsqlPoint(x: 0.05510847290427101d, y: 0.30529164142452303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760017388267823d, y: 0.6178487339740492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5140010097304816d, y: 0.8380533161100586d), new NpgsqlTypes.NpgsqlPoint(x: 0.006037474478287286d, y: 0.5839796015755447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690405732554665d, y: 0.0037044327878538175d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6815090785875402d, y: 0.740327272059736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101843123920673d, y: 0.11905017671112927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147692869043606d, y: 0.7324438058712326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313810857866764d, y: 0.6546031342022876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601572381398979d, y: 0.17825920959132435d), new NpgsqlTypes.NpgsqlPoint(x: 0.1936185514205797d, y: 0.48116819853320947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03798447035392982d, y: 0.838060562103254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223612506223002d, y: 0.7851516158606694d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131910797784069d, y: 0.8804140271330683d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.962067428742082d, y: 0.7167499462574394d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415770661646208d, y: 0.5404239628426412d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392111351515057d, y: 0.00773475173950966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1028041649271203d, y: 0.6632247539371917d), new NpgsqlTypes.NpgsqlPoint(x: 0.513189631815025d, y: 0.3552548531401827d), new NpgsqlTypes.NpgsqlPoint(x: 0.008422587163529505d, y: 0.4336569162879391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7057956072688018d, y: 0.38881521325882384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727366804541306d, y: 0.757746562253296d), new NpgsqlTypes.NpgsqlPoint(x: 0.40956715983404013d, y: 0.7561441802956488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14038025002851184d, y: 0.31110408880005147d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511975471871538d, y: 0.8175674995792879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037588247824763d, y: 0.3852606827035874d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2729007890018441d, y: 0.3584098427206166d), new NpgsqlTypes.NpgsqlPoint(x: 0.06048414524523216d, y: 0.1541835591096834d), new NpgsqlTypes.NpgsqlPoint(x: 0.43214028882206923d, y: 0.9099962309074172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051759148568583435d, y: 0.8418777114439546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967885834131764d, y: 0.554586866588998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151784829694889d, y: 0.9440392827823328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469754763515233d, y: 0.764544665017264d), new NpgsqlTypes.NpgsqlPoint(x: 0.35610393331977297d, y: 0.6789897469833834d), new NpgsqlTypes.NpgsqlPoint(x: 0.11652179111933714d, y: 0.8271219557940414d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17997686943406777d, y: 0.42736781626753084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192001576430017d, y: 0.8370739542071786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218624751325934d, y: 0.5092749553420569d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4882750188961603d, y: 0.5382984395000766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046865816310051d, y: 0.3547656682421326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126976013397303d, y: 0.15780688723603342d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7791294947264384d, y: 0.5942757935952441d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341257863770865d, y: 0.8737799769216785d), new NpgsqlTypes.NpgsqlPoint(x: 0.14168832657663766d, y: 0.4754182710130329d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9434892101429118d, y: 0.5623507465620496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8424193340596652d, y: 0.6541478499044747d), new NpgsqlTypes.NpgsqlPoint(x: 0.36621838870584633d, y: 0.1844585044078606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5740767453852736d, y: 0.007204598309895283d), new NpgsqlTypes.NpgsqlPoint(x: 0.12067699894285722d, y: 0.7165519859075442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309705061560776d, y: 0.8936803801573105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46552746324402194d, y: 0.25997530847474815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869561324926629d, y: 0.8523922620523771d), new NpgsqlTypes.NpgsqlPoint(x: 0.206516121614998d, y: 0.281166306247014d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07487795673722142d, y: 0.5228674636840916d), new NpgsqlTypes.NpgsqlPoint(x: 0.3535789171631515d, y: 0.05741805521837473d), new NpgsqlTypes.NpgsqlPoint(x: 0.37601877461764177d, y: 0.23766527562148665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5381134243467686d, y: 0.9094677945441759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874469310706514d, y: 0.7358858075299312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365295772256181d, y: 0.32998425157445554d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214514301501051d, y: 0.35356491255776d), new NpgsqlTypes.NpgsqlPoint(x: 0.35363510205843873d, y: 0.5114394310843949d), new NpgsqlTypes.NpgsqlPoint(x: 0.854165238089371d, y: 0.035658603017556634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04516522194334038d, y: 0.8689504798375391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738587706969821d, y: 0.09397553748521725d), new NpgsqlTypes.NpgsqlPoint(x: 0.013434468686158385d, y: 0.17718735712419442d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2598717581108575d, y: 0.3413437584368365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840454156926246d, y: 0.9983875709860679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689120975944978d, y: 0.3505777608933387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40979686134229065d, y: 0.8094174031960396d), new NpgsqlTypes.NpgsqlPoint(x: 0.2820172567775261d, y: 0.4135852558781473d), new NpgsqlTypes.NpgsqlPoint(x: 0.2952323478394995d, y: 0.8329393628876417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9030408243977129d, y: 0.7218706478178443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348467033666012d, y: 0.7281636135573458d), new NpgsqlTypes.NpgsqlPoint(x: 0.3356081949021803d, y: 0.2616277590442847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3434255576380575d, y: 0.9247098137078708d), new NpgsqlTypes.NpgsqlPoint(x: 0.17084610012507928d, y: 0.978085463542665d), new NpgsqlTypes.NpgsqlPoint(x: 0.05045416990092655d, y: 0.6156675437398209d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8555232895964264d, y: 0.9528082612759879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723090598712295d, y: 0.749881314447374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729990294708471d, y: 0.1734425672256633d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1389525661540567d, y: 0.4517257029102728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2585686239426227d, y: 0.08750878108489979d), new NpgsqlTypes.NpgsqlPoint(x: 0.31296279297040064d, y: 0.2042405737648233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5425826603919557d, y: 0.8811452158734896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440672474058848d, y: 0.347164412255647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937991534206966d, y: 0.39512526515204893d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2952963996041851d, y: 0.22004232218866826d), new NpgsqlTypes.NpgsqlPoint(x: 0.15351183955593217d, y: 0.5546413108953212d), new NpgsqlTypes.NpgsqlPoint(x: 0.32365734542425717d, y: 0.238778045758818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18225896681023068d, y: 0.8530989513372536d), new NpgsqlTypes.NpgsqlPoint(x: 0.18299361372116252d, y: 0.10089485386368358d), new NpgsqlTypes.NpgsqlPoint(x: 0.212971756765868d, y: 0.5394863290224025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22489537648027813d, y: 0.017134148276826466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6100063402478392d, y: 0.7468998409416907d), new NpgsqlTypes.NpgsqlPoint(x: 0.10509723885593969d, y: 0.017082155822326972d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8712872595008895d, y: 0.35834670154903836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3291814294848655d, y: 0.4806429896271306d), new NpgsqlTypes.NpgsqlPoint(x: 0.690053811451272d, y: 0.12010205580401323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3225973364200303d, y: 0.18957361695192732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7084884841862149d, y: 0.054866421114760144d), new NpgsqlTypes.NpgsqlPoint(x: 0.25929756595154774d, y: 0.535759558396353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.936839978662851d, y: 0.3984069492833363d), new NpgsqlTypes.NpgsqlPoint(x: 0.11930337306379402d, y: 0.25324451787884195d), new NpgsqlTypes.NpgsqlPoint(x: 0.011157227409413606d, y: 0.5910862790569616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3706939925113608d, y: 0.7356125117491467d), new NpgsqlTypes.NpgsqlPoint(x: 0.440997666662718d, y: 0.051796635379963485d), new NpgsqlTypes.NpgsqlPoint(x: 0.0472722244639211d, y: 0.09204995935909699d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39687813066817224d, y: 0.5364442506625291d), new NpgsqlTypes.NpgsqlPoint(x: 0.4278159637571688d, y: 0.8978466565787276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006657728601404d, y: 0.3941609031217327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4510066209525705d, y: 0.9371867342670505d), new NpgsqlTypes.NpgsqlPoint(x: 0.14183061163030564d, y: 0.6860973556092153d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894367085592753d, y: 0.8908019238484287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6802706211355489d, y: 0.44741861601297517d), new NpgsqlTypes.NpgsqlPoint(x: 0.32494313655549445d, y: 0.5021517293520837d), new NpgsqlTypes.NpgsqlPoint(x: 0.25540933620952355d, y: 0.42489200554929873d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36202937640638233d, y: 0.3057285546914308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2976586542102926d, y: 0.2734840194983079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337711398547736d, y: 0.6382054865292781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012462793527674432d, y: 0.1366899007437894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687107767402222d, y: 0.39318159821374155d), new NpgsqlTypes.NpgsqlPoint(x: 0.08253471654104239d, y: 0.4830316586427812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8691976100020695d, y: 0.6184950373944932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8186178604464799d, y: 0.21861230558582379d), new NpgsqlTypes.NpgsqlPoint(x: 0.10014441364703242d, y: 0.4813316287163759d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25829206360300894d, y: 0.149564715157117d), new NpgsqlTypes.NpgsqlPoint(x: 0.2940579386045007d, y: 0.8656169081943167d), new NpgsqlTypes.NpgsqlPoint(x: 0.670299639158852d, y: 0.9189603808766561d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21719025785774548d, y: 0.5935434338709584d), new NpgsqlTypes.NpgsqlPoint(x: 0.21041095294644097d, y: 0.7381731377573332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887038832572667d, y: 0.2305541030460222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2850966514247677d, y: 0.1418946897992277d), new NpgsqlTypes.NpgsqlPoint(x: 0.022213744020480153d, y: 0.3972129855428689d), new NpgsqlTypes.NpgsqlPoint(x: 0.21636018500579135d, y: 0.47621212451718686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056376469020846476d, y: 0.8048647511851308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257722413355441d, y: 0.5468128203900313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4891943689852858d, y: 0.4923631286356246d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6792886356590169d, y: 0.9787713226617731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065853757231029d, y: 0.7784280503180411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067466211970743d, y: 0.30483755131653845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43836556229358303d, y: 0.8118452571504264d), new NpgsqlTypes.NpgsqlPoint(x: 0.40185006935979517d, y: 0.8388865482676184d), new NpgsqlTypes.NpgsqlPoint(x: 0.02618794616155451d, y: 0.7329755690490686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7575426988955769d, y: 0.26228299733353555d), new NpgsqlTypes.NpgsqlPoint(x: 0.40132211441081656d, y: 0.30245537759662633d), new NpgsqlTypes.NpgsqlPoint(x: 0.14416946059922642d, y: 0.18281137304804562d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124734789502382d, y: 0.5674643537517284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978608921449861d, y: 0.09441706339027178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437717073058881d, y: 0.48353076054181365d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36236416324175513d, y: 0.8769732818205426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762094803369171d, y: 0.6921985555506922d), new NpgsqlTypes.NpgsqlPoint(x: 0.37056350969532337d, y: 0.2373633550963098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09231934041945355d, y: 0.7535259845083541d), new NpgsqlTypes.NpgsqlPoint(x: 0.11891183264181504d, y: 0.3123815692367634d), new NpgsqlTypes.NpgsqlPoint(x: 0.8181972380578473d, y: 0.15433262429581418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6762039598606268d, y: 0.6198253622674175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213870870165457d, y: 0.6904593200401965d), new NpgsqlTypes.NpgsqlPoint(x: 0.842055857961492d, y: 0.44443133395419865d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22885911118372948d, y: 0.6159784433310107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3155111307733147d, y: 0.07613329177097339d), new NpgsqlTypes.NpgsqlPoint(x: 0.526670266047552d, y: 0.1520768847339674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24478818526803092d, y: 0.23228610794927196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9114402753173071d, y: 0.6126286729477134d), new NpgsqlTypes.NpgsqlPoint(x: 0.1624664512217875d, y: 0.41606806022162246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6095924863769829d, y: 0.4359530187678212d), new NpgsqlTypes.NpgsqlPoint(x: 0.2881066160399216d, y: 0.43223971501994674d), new NpgsqlTypes.NpgsqlPoint(x: 0.12084645679594463d, y: 0.313635562634509d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35942513168344725d, y: 0.7340806918944507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089671845026404d, y: 0.3775834478354433d), new NpgsqlTypes.NpgsqlPoint(x: 0.2465621686885101d, y: 0.5542087793204217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4192747934343789d, y: 0.22864843587250439d), new NpgsqlTypes.NpgsqlPoint(x: 0.48502454785632676d, y: 0.4848147826641792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073389127031244d, y: 0.039038470835120465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45367255565216347d, y: 0.11288192607970049d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259080042482131d, y: 0.20011450798843655d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979798163990057d, y: 0.8104489980490834d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8609775155963123d, y: 0.438472287136655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9089209107859167d, y: 0.3370097653208921d), new NpgsqlTypes.NpgsqlPoint(x: 0.3783054226081025d, y: 0.9296547896426846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8691016255906926d, y: 0.5389001573707234d), new NpgsqlTypes.NpgsqlPoint(x: 0.21747976088082843d, y: 0.47947288915350694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703447216938649d, y: 0.12879233859091244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5797697408615292d, y: 0.23311959291833384d), new NpgsqlTypes.NpgsqlPoint(x: 0.16168278253428658d, y: 0.7078286723211017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813419245638488d, y: 0.4947968791406967d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.903867844986364d, y: 0.22995835985328772d), new NpgsqlTypes.NpgsqlPoint(x: 0.12988729650295938d, y: 0.7063328983873853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581620323872975d, y: 0.8397453240097645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.955748708816237d, y: 0.9410337447119568d), new NpgsqlTypes.NpgsqlPoint(x: 0.10276669847758857d, y: 0.1725158542351095d), new NpgsqlTypes.NpgsqlPoint(x: 0.03021380628118553d, y: 0.6584821982418397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7955886050120006d, y: 0.2715582217215946d), new NpgsqlTypes.NpgsqlPoint(x: 0.07562365979761565d, y: 0.9360741318135264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373534994152929d, y: 0.38271589233172854d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36535452897487064d, y: 0.9215890792903593d), new NpgsqlTypes.NpgsqlPoint(x: 0.16993938201344783d, y: 0.5785048396919289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993233812970797d, y: 0.4931947746683707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24711393384084035d, y: 0.5274217053078846d), new NpgsqlTypes.NpgsqlPoint(x: 0.18991984797041317d, y: 0.5394564105884976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579980785355818d, y: 0.2043566086355051d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46227381449813687d, y: 0.9905784018581929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559589002876504d, y: 0.3806325514711687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572347189055668d, y: 0.17338421205466326d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6606397056799737d, y: 0.3461112618413017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579728796675111d, y: 0.7611641219674264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259220353356171d, y: 0.9744306776653828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34143206474238497d, y: 0.7317223288176468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2084832781843513d, y: 0.6862164252418548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974276749120164d, y: 0.11700626056790953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6650764235068818d, y: 0.820248618884104d), new NpgsqlTypes.NpgsqlPoint(x: 0.18013011013743652d, y: 0.016666322500937247d), new NpgsqlTypes.NpgsqlPoint(x: 0.16599315590527086d, y: 0.3755217906056727d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6683311278595274d, y: 0.5958241735139421d), new NpgsqlTypes.NpgsqlPoint(x: 0.45170637749563225d, y: 0.6788551716600131d), new NpgsqlTypes.NpgsqlPoint(x: 0.35935814474314676d, y: 0.6360771732820991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5862647825613473d, y: 0.9974173250622713d), new NpgsqlTypes.NpgsqlPoint(x: 0.13657536533322123d, y: 0.4306982447630132d), new NpgsqlTypes.NpgsqlPoint(x: 0.530358212194803d, y: 0.4714744792492833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.883905319952604d, y: 0.010061425035399307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476146287914301d, y: 0.37352423060721296d), new NpgsqlTypes.NpgsqlPoint(x: 0.37038407051749334d, y: 0.16445844277144028d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01186694252586007d, y: 0.8493564613183003d), new NpgsqlTypes.NpgsqlPoint(x: 0.41220439865860414d, y: 0.8263981914078676d), new NpgsqlTypes.NpgsqlPoint(x: 0.707292821035427d, y: 0.976097287218101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8000272044060386d, y: 0.39451456639841653d), new NpgsqlTypes.NpgsqlPoint(x: 0.2910890651680039d, y: 0.7733016259248086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2804091832784388d, y: 0.018541887352932163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03953977015655097d, y: 0.44273737265561697d), new NpgsqlTypes.NpgsqlPoint(x: 0.40665534702084094d, y: 0.561328933706254d), new NpgsqlTypes.NpgsqlPoint(x: 0.15052103509177495d, y: 0.9582894892746744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.76278646657782d, y: 0.2696594993036979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059923168540551d, y: 0.7193130548160866d), new NpgsqlTypes.NpgsqlPoint(x: 0.017497046971915897d, y: 0.9046877541226428d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34009909583285236d, y: 0.09211379121115104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611837422691811d, y: 0.9438507692032773d), new NpgsqlTypes.NpgsqlPoint(x: 0.05678736507996662d, y: 0.27066424240745157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3088209986552459d, y: 0.143775237726818d), new NpgsqlTypes.NpgsqlPoint(x: 0.06209898273048098d, y: 0.5842465103339156d), new NpgsqlTypes.NpgsqlPoint(x: 0.011421470852643112d, y: 0.03572009873027249d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44112339357250585d, y: 0.7880819674327816d), new NpgsqlTypes.NpgsqlPoint(x: 0.03941955271221598d, y: 0.04465678832239339d), new NpgsqlTypes.NpgsqlPoint(x: 0.013563486989820794d, y: 0.4617626183890191d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45065814998523757d, y: 0.6722756351708228d), new NpgsqlTypes.NpgsqlPoint(x: 0.778084758393905d, y: 0.9883255467184925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219111962343956d, y: 0.8911791782539114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12666771068926708d, y: 0.997267748468759d), new NpgsqlTypes.NpgsqlPoint(x: 0.608088211760911d, y: 0.4298555522431565d), new NpgsqlTypes.NpgsqlPoint(x: 0.18297105929280688d, y: 0.279062332810159d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.682476315387862d, y: 0.06838265851264214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829521288884463d, y: 0.21204738982500837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256054033028418d, y: 0.8612399061084022d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5726088542354463d, y: 0.6632279197105586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372434330054568d, y: 0.07512526858224589d), new NpgsqlTypes.NpgsqlPoint(x: 0.28429621361309854d, y: 0.7514083465704545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18740624957218555d, y: 0.316161815894339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5755087973984798d, y: 0.37344224068053056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568670972220033d, y: 0.13241261702004736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3917551099854111d, y: 0.18967532070366133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4984601998708458d, y: 0.2389866263488586d), new NpgsqlTypes.NpgsqlPoint(x: 0.10577847037847554d, y: 0.961816675118962d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07137574299193072d, y: 0.7412415975632581d), new NpgsqlTypes.NpgsqlPoint(x: 0.006853273846808783d, y: 0.42715904436265884d), new NpgsqlTypes.NpgsqlPoint(x: 0.28848604951002d, y: 0.6062845088446635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8693634758171807d, y: 0.2599669858908549d), new NpgsqlTypes.NpgsqlPoint(x: 0.1453920423453543d, y: 0.3464359484988436d), new NpgsqlTypes.NpgsqlPoint(x: 0.20655547033817523d, y: 0.12023279844338597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.371267118694976d, y: 0.076546449617939d), new NpgsqlTypes.NpgsqlPoint(x: 0.48378016196634455d, y: 0.6848204424567811d), new NpgsqlTypes.NpgsqlPoint(x: 0.05145484543654699d, y: 0.39712787650378956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8974673097278903d, y: 0.6315150567405684d), new NpgsqlTypes.NpgsqlPoint(x: 0.22492936958754717d, y: 0.9392255212603631d), new NpgsqlTypes.NpgsqlPoint(x: 0.22319820061457918d, y: 0.3275866695253653d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5823739501714607d, y: 0.4733484109978515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520313967409165d, y: 0.10598474063288577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407157177670305d, y: 0.5689829680966307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3556988827447657d, y: 0.5721697282514123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693095897233339d, y: 0.3994282016289584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737655595286661d, y: 0.9635117391079495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06751762223690483d, y: 0.5089373786289577d), new NpgsqlTypes.NpgsqlPoint(x: 0.41293620670873665d, y: 0.590360418783688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774129575932971d, y: 0.9929467945186926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.122857815013794d, y: 0.25032585396111795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163735830235212d, y: 0.4600854516216696d), new NpgsqlTypes.NpgsqlPoint(x: 0.41973841203528406d, y: 0.4619019990838994d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009083478903406439d, y: 0.06795592383528692d), new NpgsqlTypes.NpgsqlPoint(x: 0.185779616511199d, y: 0.8195824657923223d), new NpgsqlTypes.NpgsqlPoint(x: 0.11171519899458515d, y: 0.9870150399128789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08578901312621712d, y: 0.6615701976767211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164452934332352d, y: 0.5349922945884021d), new NpgsqlTypes.NpgsqlPoint(x: 0.18983579759910196d, y: 0.7925447844063161d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.780381932544201d, y: 0.3337944007072221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6981432724529829d, y: 0.6592516242562892d), new NpgsqlTypes.NpgsqlPoint(x: 0.015248393817145045d, y: 0.5933097793755292d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30213397361851835d, y: 0.33275632645641195d), new NpgsqlTypes.NpgsqlPoint(x: 0.17562665379542086d, y: 0.9420207097725701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294129671836453d, y: 0.03435861658171713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.750490374046469d, y: 0.6878321313593796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640702573922262d, y: 0.4221730897522723d), new NpgsqlTypes.NpgsqlPoint(x: 0.40738172756594004d, y: 0.9445794985878642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7656213920383114d, y: 0.5187704727128253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796644848564854d, y: 0.3627464464716552d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178875742150206d, y: 0.3890653630159847d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28204806235929747d, y: 0.5479150795535472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645760861177322d, y: 0.6528314256688025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7248390784537955d, y: 0.3679033915112192d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6660401274126508d, y: 0.9088343486177513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584390857371231d, y: 0.6045263466382316d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599260549157081d, y: 0.5069706124446681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8804594336546345d, y: 0.6352095240960931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7965740997908679d, y: 0.7363820871397464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751244537358464d, y: 0.11985779462120116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01160873073838864d, y: 0.7587892220374841d), new NpgsqlTypes.NpgsqlPoint(x: 0.49878035084038974d, y: 0.2558349876287822d), new NpgsqlTypes.NpgsqlPoint(x: 0.028937088000132394d, y: 0.4644831985305088d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7005411608876239d, y: 0.31856695146588976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953779020691601d, y: 0.22902772917930825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080680623342678d, y: 0.6362039722943058d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.546198799827101d, y: 0.5111886860956718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863418817451627d, y: 0.2670931051816784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330065330802551d, y: 0.9190203888649363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2248554201853521d, y: 0.7276187136212011d), new NpgsqlTypes.NpgsqlPoint(x: 0.28778504674331173d, y: 0.3242013600200818d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990426989763391d, y: 0.6255597056672725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21680873712878868d, y: 0.18324149540586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6557212340771968d, y: 0.6740725894052118d), new NpgsqlTypes.NpgsqlPoint(x: 0.875551251937611d, y: 0.1616444201350825d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526862016818833d, y: 0.0205653182761526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8287375800653423d, y: 0.9035655642972463d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499180213642875d, y: 0.8892429787041658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7448574975488409d, y: 0.6763598419264627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001809581399769d, y: 0.20519170348769744d), new NpgsqlTypes.NpgsqlPoint(x: 0.431192469792137d, y: 0.25902511372258863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22562690128599883d, y: 0.741869769652003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240851636034326d, y: 0.4385240871537113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2906948240139686d, y: 0.8238011702619162d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8369831849725843d, y: 0.9227457345142062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511226625692635d, y: 0.8447376545037d), new NpgsqlTypes.NpgsqlPoint(x: 0.44769529789593043d, y: 0.5638568076409447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508117086846436d, y: 0.7820362508770291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317516564968815d, y: 0.6991650043168659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023675376560465d, y: 0.3639719441077265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15264719825265316d, y: 0.12462974285623041d), new NpgsqlTypes.NpgsqlPoint(x: 0.0010558622431092735d, y: 0.9720685060432239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401233459076992d, y: 0.7526454343389382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07899098625005241d, y: 0.5744324414492407d), new NpgsqlTypes.NpgsqlPoint(x: 0.55205628205687d, y: 0.41041197824867004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982311547310659d, y: 0.4394660571723392d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032132848288657256d, y: 0.7649311739602553d), new NpgsqlTypes.NpgsqlPoint(x: 0.49633138309135616d, y: 0.7560812242582912d), new NpgsqlTypes.NpgsqlPoint(x: 0.005716207461462841d, y: 0.4942820185136846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896573178021647d, y: 0.11255228974587195d), new NpgsqlTypes.NpgsqlPoint(x: 0.36544684892945656d, y: 0.8851224444502837d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159970958800772d, y: 0.38728171670189704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4741494919198638d, y: 0.6150352866172359d), new NpgsqlTypes.NpgsqlPoint(x: 0.353042532255616d, y: 0.328455927931372d), new NpgsqlTypes.NpgsqlPoint(x: 0.2725107184912341d, y: 0.2539697793693062d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4207234344755735d, y: 0.5261807343122946d), new NpgsqlTypes.NpgsqlPoint(x: 0.48914553154317053d, y: 0.12379012996190197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9960699722548564d, y: 0.270193279282664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3364418695420459d, y: 0.6031665258346732d), new NpgsqlTypes.NpgsqlPoint(x: 0.09719973395999826d, y: 0.05926512966266895d), new NpgsqlTypes.NpgsqlPoint(x: 0.09274772015326993d, y: 0.3946006198380728d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9707263196392987d, y: 0.09294039606784088d), new NpgsqlTypes.NpgsqlPoint(x: 0.08487667445623326d, y: 0.31182154292490927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421510054769442d, y: 0.34036557229745146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5197569805791394d, y: 0.5967902001786685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606085678003464d, y: 0.3966452610179987d), new NpgsqlTypes.NpgsqlPoint(x: 0.09206035050459116d, y: 0.4122017429784788d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8831378666855124d, y: 0.4051169759454988d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329889813370689d, y: 0.39014417248176836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219591813315851d, y: 0.8895498084722604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47670544217293853d, y: 0.1478170004529592d), new NpgsqlTypes.NpgsqlPoint(x: 0.10361695173098318d, y: 0.3289385293335687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904586326042595d, y: 0.17325923067120086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9224162805998625d, y: 0.44735539579686745d), new NpgsqlTypes.NpgsqlPoint(x: 0.942216378788917d, y: 0.20432783853600367d), new NpgsqlTypes.NpgsqlPoint(x: 0.4213556897443511d, y: 0.14535316441415214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7230668809189d, y: 0.6744548655258906d), new NpgsqlTypes.NpgsqlPoint(x: 0.512941653039352d, y: 0.7044676302897732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256317286571798d, y: 0.34454773179896503d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3348901571685109d, y: 0.3272198040254316d), new NpgsqlTypes.NpgsqlPoint(x: 0.37061626299676187d, y: 0.5825575154263408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123215112091073d, y: 0.24996684227973542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39760921198791754d, y: 0.09371635649380372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417179927371696d, y: 0.29955584081566244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4231492554549102d, y: 0.20427105041346283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09311683957965078d, y: 0.6181903346655501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065832833628478d, y: 0.9685984733854042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679341777383143d, y: 0.11934810479726843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9170631867510369d, y: 0.391804785538454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651295596295169d, y: 0.27844806167511005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254616595291655d, y: 0.4087007227875077d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4093764146712092d, y: 0.20849450658397684d), new NpgsqlTypes.NpgsqlPoint(x: 0.13272081123583745d, y: 0.21474021988050085d), new NpgsqlTypes.NpgsqlPoint(x: 0.34070454531626226d, y: 0.9016679887433691d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8517595879557461d, y: 0.5249070772876683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389738408478828d, y: 0.4482212762448816d), new NpgsqlTypes.NpgsqlPoint(x: 0.2926450765769194d, y: 0.6846525401728176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046538680771876395d, y: 0.5232736686204429d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341774302832655d, y: 0.6380554748475314d), new NpgsqlTypes.NpgsqlPoint(x: 0.723723018171575d, y: 0.8157923599372278d)),

},
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 64, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 45, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 98, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

