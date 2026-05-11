

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
    internal partial interface INpgsqlLineMArraylineMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMArrayD2 : INpgsqlLineMArraylineMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMArrayD2E1M[] _testData = new NpgsqlLinelineMArrayD2E1M[]
        {
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3114675681913228d, b: 0.6437637498775773d, c: 0.4532213178798834d),
new NpgsqlTypes.NpgsqlLine(a: 0.0184942959466311d, b: 0.29218368645679926d, c: 0.9740399430104917d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5370736197409532d, b: 0.33573833889568205d, c: 0.9397975470225249d),
new NpgsqlTypes.NpgsqlLine(a: 0.8368316262719605d, b: 0.2084353119406156d, c: 0.8766197601515144d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4771600952223466d, b: 0.39401500478574514d, c: 0.15184835121340778d),
new NpgsqlTypes.NpgsqlLine(a: 0.8759692414294463d, b: 0.13632732496258737d, c: 0.2996260418174689d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.204381543993432d, b: 0.6943678312025399d, c: 0.41190125256658794d),
new NpgsqlTypes.NpgsqlLine(a: 0.7243833058191332d, b: 0.7457562062466d, c: 0.6155481282049629d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.16991927527050532d, b: 0.15381548382008747d, c: 0.8060398939003875d),
new NpgsqlTypes.NpgsqlLine(a: 0.10881773248434645d, b: 0.5073261046197813d, c: 0.666084773313241d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7408643051143796d, b: 0.6076035340767008d, c: 0.6210507915519294d),
new NpgsqlTypes.NpgsqlLine(a: 0.27353420785015803d, b: 0.0850009959445992d, c: 0.37462596851629015d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.25001603661449046d, b: 0.9076086551648318d, c: 0.6109847431669889d),
new NpgsqlTypes.NpgsqlLine(a: 0.7851732359406688d, b: 0.5162060254262956d, c: 0.158983550275839d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.40558715803440915d, b: 0.09453271767739191d, c: 0.3106625425967626d),
new NpgsqlTypes.NpgsqlLine(a: 0.9941860005685097d, b: 0.26515105563866925d, c: 0.6737151366221251d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.1263891687190204d, b: 0.5270832286943901d, c: 0.4811764157039009d),
new NpgsqlTypes.NpgsqlLine(a: 0.1564086508612158d, b: 0.11551962639243774d, c: 0.8573944254885483d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.42059782154098535d, b: 0.5893366952127829d, c: 0.9049986182728798d),
new NpgsqlTypes.NpgsqlLine(a: 0.16279255747831856d, b: 0.3126208089751209d, c: 0.38536660134687617d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.23235142309940215d, b: 0.808745687529583d, c: 0.42253986104347696d),
new NpgsqlTypes.NpgsqlLine(a: 0.7799691346283644d, b: 0.3434344753383286d, c: 0.07723947976427703d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.28222005264775374d, b: 0.568111186511999d, c: 0.7817416575265947d),
new NpgsqlTypes.NpgsqlLine(a: 0.08752610098490665d, b: 0.3446641566731178d, c: 0.6850900087690875d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9080214130077049d, b: 0.42313006078807036d, c: 0.8669155015944818d),
new NpgsqlTypes.NpgsqlLine(a: 0.07949370516038601d, b: 0.10755105473412951d, c: 0.4025734236149253d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.19773318862456035d, b: 0.5008709471944903d, c: 0.7653603795782882d),
new NpgsqlTypes.NpgsqlLine(a: 0.049698775176396426d, b: 0.339933729494717d, c: 0.11595607386222007d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5357306930220139d, b: 0.747786994823288d, c: 0.6335260823317213d),
new NpgsqlTypes.NpgsqlLine(a: 0.13000408904972127d, b: 0.4931467241282572d, c: 0.6849376180809177d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.2540755554626196d, b: 0.973394427733893d, c: 0.7936531800310762d),
new NpgsqlTypes.NpgsqlLine(a: 0.7712387382705154d, b: 0.08941441276476325d, c: 0.5537188154055769d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.8173581340881003d, b: 0.6351276564259282d, c: 0.5063117966541567d),
new NpgsqlTypes.NpgsqlLine(a: 0.18296385200066712d, b: 0.028169043706972263d, c: 0.6945412125356482d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5620858014357123d, b: 0.47892688132047d, c: 0.5005838951808387d),
new NpgsqlTypes.NpgsqlLine(a: 0.41804914016827455d, b: 0.904232469623908d, c: 0.9630429771559955d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.24034797676500486d, b: 0.8570340449259539d, c: 0.9626790521585851d),
new NpgsqlTypes.NpgsqlLine(a: 0.8954220442962545d, b: 0.598476752615281d, c: 0.362698463590164d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.8991764959103641d, b: 0.6790425668918914d, c: 0.27656953759431024d),
new NpgsqlTypes.NpgsqlLine(a: 0.8764366778070807d, b: 0.7088469874986414d, c: 0.501876358038614d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.14693444463390792d, b: 0.5659359170204721d, c: 0.13841940852516843d),
new NpgsqlTypes.NpgsqlLine(a: 0.2314835586860018d, b: 0.272209506614144d, c: 0.7455515153530521d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9566688369558587d, b: 0.38790295474213d, c: 0.6333737592100372d),
new NpgsqlTypes.NpgsqlLine(a: 0.27102764031315485d, b: 0.7706270374533373d, c: 0.527468940082522d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9714403995568189d, b: 0.5383782208242576d, c: 0.5741576942430525d),
new NpgsqlTypes.NpgsqlLine(a: 0.7910733196201504d, b: 0.7623089920180982d, c: 0.3835120026691021d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9779419275670274d, b: 0.5460351653998256d, c: 0.3673381704447435d),
new NpgsqlTypes.NpgsqlLine(a: 0.49281887588576856d, b: 0.6293563564027501d, c: 0.28124399331609307d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9381027728484357d, b: 0.2675959603617267d, c: 0.9330320601935599d),
new NpgsqlTypes.NpgsqlLine(a: 0.4941595411499339d, b: 0.1962908906848484d, c: 0.9550450067287457d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.8153368833523664d, b: 0.8513933571803635d, c: 0.13012191808138163d),
new NpgsqlTypes.NpgsqlLine(a: 0.29526701680875134d, b: 0.2500428095674303d, c: 0.2110279931368234d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.36269601264987905d, b: 0.03867686347578003d, c: 0.5961158605675103d),
new NpgsqlTypes.NpgsqlLine(a: 0.1734674636917498d, b: 0.18554617795228912d, c: 0.8226944361057246d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5702077680969089d, b: 0.6043158384262072d, c: 0.9296411712552924d),
new NpgsqlTypes.NpgsqlLine(a: 0.14112629726897719d, b: 0.2896755267016784d, c: 0.9651244137700605d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.38031534660158206d, b: 0.7352978433143056d, c: 0.45702418749478224d),
new NpgsqlTypes.NpgsqlLine(a: 0.5648040731640181d, b: 0.45175719397340264d, c: 0.942753027318853d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7481160424702051d, b: 0.8236447641249535d, c: 0.0497500345436207d),
new NpgsqlTypes.NpgsqlLine(a: 0.16167057886887748d, b: 0.2955599774350697d, c: 0.037194864240772674d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.12517316457603878d, b: 0.6348423291892207d, c: 0.8950898436810876d),
new NpgsqlTypes.NpgsqlLine(a: 0.9824406320213878d, b: 0.3264566333289973d, c: 0.08963684275110484d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9751654220031575d, b: 0.9800589480946664d, c: 0.017039352489687687d),
new NpgsqlTypes.NpgsqlLine(a: 0.7291134583725062d, b: 0.8854215496112509d, c: 0.9476371493172647d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.795101682679654d, b: 0.7259090044013162d, c: 0.8873677187723038d),
new NpgsqlTypes.NpgsqlLine(a: 0.8896392600347611d, b: 0.9074708638919178d, c: 0.8904913449434538d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9074167384878694d, b: 0.7756192406299607d, c: 0.509312238216858d),
new NpgsqlTypes.NpgsqlLine(a: 0.23904949944164777d, b: 0.7911813044365142d, c: 0.8021179664203181d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4072205040099701d, b: 0.7294307848461243d, c: 0.8098753999568353d),
new NpgsqlTypes.NpgsqlLine(a: 0.28759019532598273d, b: 0.5898519218317012d, c: 0.7136155434033071d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6728154697277509d, b: 0.20442017337088025d, c: 0.03615722803163113d),
new NpgsqlTypes.NpgsqlLine(a: 0.5710910096576878d, b: 0.07836540531687464d, c: 0.297786908666406d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6279689266657767d, b: 0.3449066932910455d, c: 0.8104564254640736d),
new NpgsqlTypes.NpgsqlLine(a: 0.7411429986507849d, b: 0.40346707179159713d, c: 0.3705245511221741d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.18705888762584943d, b: 0.6216986514288512d, c: 0.43961374456554314d),
new NpgsqlTypes.NpgsqlLine(a: 0.39809599707286847d, b: 0.15456695971014234d, c: 0.5583966607048229d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.15811360729018664d, b: 0.010271502853900771d, c: 0.4372156186035545d),
new NpgsqlTypes.NpgsqlLine(a: 0.03568382550782134d, b: 0.11859634748248193d, c: 0.8268346687688498d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5796016803791801d, b: 0.4069991645614589d, c: 0.7246327016102717d),
new NpgsqlTypes.NpgsqlLine(a: 0.9933032367300402d, b: 0.5106502292196842d, c: 0.7068293252642665d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.8628209706952604d, b: 0.7398610718731077d, c: 0.5490588643763662d),
new NpgsqlTypes.NpgsqlLine(a: 0.11540357677025415d, b: 0.014172970238348626d, c: 0.7883540545655817d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7716260650054526d, b: 0.3779128757067802d, c: 0.6823959021279948d),
new NpgsqlTypes.NpgsqlLine(a: 0.8928393009764068d, b: 0.4793589175692603d, c: 0.8780507501355558d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.22881614834394481d, b: 0.20708621544283712d, c: 0.5519872665832052d),
new NpgsqlTypes.NpgsqlLine(a: 0.5514796561814725d, b: 0.7653252733887177d, c: 0.36553519683153857d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3424200756398048d, b: 0.035036893248626244d, c: 0.8704948442874202d),
new NpgsqlTypes.NpgsqlLine(a: 0.48648997543154626d, b: 0.4121369094589473d, c: 0.6868471124495221d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.23178087130720237d, b: 0.992388058227204d, c: 0.18419238031762997d),
new NpgsqlTypes.NpgsqlLine(a: 0.813836935439579d, b: 0.3243905107479942d, c: 0.8102481555915969d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9753521015895315d, b: 0.3477653607684953d, c: 0.06890336036447109d),
new NpgsqlTypes.NpgsqlLine(a: 0.534320108199983d, b: 0.96282298423526d, c: 0.26446362555566105d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.008909211229811032d, b: 0.6197830831698881d, c: 0.3943048724179874d),
new NpgsqlTypes.NpgsqlLine(a: 0.320753580785998d, b: 0.8326099598668809d, c: 0.023498620333055276d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.08689379895699656d, b: 0.04028156537468852d, c: 0.8675261237672611d),
new NpgsqlTypes.NpgsqlLine(a: 0.9565382319057298d, b: 0.10500153452955463d, c: 0.855381129467157d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.34304529891595537d, b: 0.28331543990017116d, c: 0.06382888661431618d),
new NpgsqlTypes.NpgsqlLine(a: 0.26389365546482446d, b: 0.45348387959393277d, c: 0.27620035799423437d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.292253656853657d, b: 0.5715175349766464d, c: 0.4608980243178935d),
new NpgsqlTypes.NpgsqlLine(a: 0.1916343233240686d, b: 0.08775180940073779d, c: 0.20495937954906263d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5646541629635135d, b: 0.7479276463497778d, c: 0.3334454493981216d),
new NpgsqlTypes.NpgsqlLine(a: 0.7081219964294347d, b: 0.807131213428072d, c: 0.6359131888849414d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4606062103219717d, b: 0.5101261289451067d, c: 0.9274086877090559d),
new NpgsqlTypes.NpgsqlLine(a: 0.5514484323249431d, b: 0.7418766158956263d, c: 0.4787520142252608d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.2225655292801041d, b: 0.21565923459358816d, c: 0.5046565149902958d),
new NpgsqlTypes.NpgsqlLine(a: 0.7682207981018004d, b: 0.2860503900475617d, c: 0.5662406682166303d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9480479541165767d, b: 0.5447694663806667d, c: 0.9386264755121896d),
new NpgsqlTypes.NpgsqlLine(a: 0.9839382346130154d, b: 0.2191778511973771d, c: 0.7935736598434616d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3408419946062926d, b: 0.529680342680905d, c: 0.04586956301912004d),
new NpgsqlTypes.NpgsqlLine(a: 0.3132196345583601d, b: 0.7468643674640957d, c: 0.7306423425898068d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.965006324478081d, b: 0.825022316557329d, c: 0.14691167193214194d),
new NpgsqlTypes.NpgsqlLine(a: 0.14033640520377155d, b: 0.519635920541793d, c: 0.04987993209934016d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.04956157086802926d, b: 0.6433847491535863d, c: 0.7475597706169937d),
new NpgsqlTypes.NpgsqlLine(a: 0.8273692051154398d, b: 0.8150181933592949d, c: 0.1294015988217988d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.39426908330227184d, b: 0.12342086850858858d, c: 0.5398469221684323d),
new NpgsqlTypes.NpgsqlLine(a: 0.8713491414244896d, b: 0.1724951179829104d, c: 0.6467638954784208d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.696214221988284d, b: 0.8489622696345461d, c: 0.677005619943239d),
new NpgsqlTypes.NpgsqlLine(a: 0.8251232016424409d, b: 0.01840439748285949d, c: 0.8961459189243877d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.5398432498747452d, b: 0.14690464213682486d, c: 0.3278167461275552d),
new NpgsqlTypes.NpgsqlLine(a: 0.4382609250518257d, b: 0.8402023850739575d, c: 0.5401268891221747d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.2254575852971773d, b: 0.044782793951477995d, c: 0.9370655117094736d),
new NpgsqlTypes.NpgsqlLine(a: 0.8259907872855602d, b: 0.5297425885825128d, c: 0.04721761969057503d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.1604514000374443d, b: 0.13065440197735456d, c: 0.45466614100612723d),
new NpgsqlTypes.NpgsqlLine(a: 0.8861086133435502d, b: 0.6382034472883693d, c: 0.40620596057117353d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9365506927019024d, b: 0.5276904327227393d, c: 0.6626441677041638d),
new NpgsqlTypes.NpgsqlLine(a: 0.040768448156189296d, b: 0.9294365297209601d, c: 0.294577338215794d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.229235422492866d, b: 0.9904664294296954d, c: 0.27385606086545977d),
new NpgsqlTypes.NpgsqlLine(a: 0.28954904971118445d, b: 0.6923018963888272d, c: 0.4240344142851791d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7823068875592768d, b: 0.07317846337101808d, c: 0.09303733835660943d),
new NpgsqlTypes.NpgsqlLine(a: 0.33458354775365706d, b: 0.2780834901521141d, c: 0.15817333793996258d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.20866823202196882d, b: 0.3091001650736088d, c: 0.13652341110490862d),
new NpgsqlTypes.NpgsqlLine(a: 0.9217578271103976d, b: 0.2378532419226308d, c: 0.8915036738054557d), } },
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4699644075831835d, b: 0.4907466094274562d, c: 0.07823344267713506d),
new NpgsqlTypes.NpgsqlLine(a: 0.5653360732081801d, b: 0.538981774060447d, c: 0.33619879201566494d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.4437709405183431d, b: 0.015418077899272742d, c: 0.07252193854498468d),
new NpgsqlTypes.NpgsqlLine(a: 0.6579962007017164d, b: 0.6902503054878532d, c: 0.5323276930567551d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.9789442772394412d, b: 0.790091071860392d, c: 0.316962517161988d),
new NpgsqlTypes.NpgsqlLine(a: 0.47768106327371007d, b: 0.5871944051960738d, c: 0.5724340748258637d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.6554587226618134d, b: 0.12623630375352013d, c: 0.30586329007938473d),
new NpgsqlTypes.NpgsqlLine(a: 0.2697124060324345d, b: 0.3688241159243725d, c: 0.8324776908317871d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.35166386334371347d, b: 0.2217663284452066d, c: 0.514985638713203d),
new NpgsqlTypes.NpgsqlLine(a: 0.526084878422874d, b: 0.7763379596925895d, c: 0.2755523318075812d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.29609057150352935d, b: 0.48926456829142695d, c: 0.5960395878914571d),
new NpgsqlTypes.NpgsqlLine(a: 0.36366195303613724d, b: 0.12307700509833164d, c: 0.16832347248535917d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.49530304928361146d, b: 0.9155197687272824d, c: 0.5770229739534424d),
new NpgsqlTypes.NpgsqlLine(a: 0.8544473847024343d, b: 0.857983436322232d, c: 0.5159719380596696d), } },
    ModelInner = new NpgsqlLinelineMArrayD21MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.3300743988607714d, b: 0.021545057108616872d, c: 0.8601038763680157d),
new NpgsqlTypes.NpgsqlLine(a: 0.6362492203318401d, b: 0.07145888764690345d, c: 0.45357350888252024d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.714431169619059d, b: 0.6912887782301308d, c: 0.15121194201040122d),
new NpgsqlTypes.NpgsqlLine(a: 0.7247710176729051d, b: 0.6503811457752499d, c: 0.8266002757325628d), } },
},
            new NpgsqlLinelineMArrayD2E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.7944787962709638d, b: 0.14172457333974475d, c: 0.15349286629917247d),
new NpgsqlTypes.NpgsqlLine(a: 0.7670608092097296d, b: 0.600478974487117d, c: 0.8129518716731013d), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd21mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
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

                changedRows =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemarrayd21mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd21mi_id
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
    npgsqllinelinemarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.19773318862456035d, b: 0.5008709471944903d, c: 0.7653603795782882d),
new NpgsqlTypes.NpgsqlLine(a: 0.049698775176396426d, b: 0.339933729494717d, c: 0.11595607386222007d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.24034797676500486d, b: 0.8570340449259539d, c: 0.9626790521585851d),
new NpgsqlTypes.NpgsqlLine(a: 0.8954220442962545d, b: 0.598476752615281d, c: 0.362698463590164d), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd21mi_id
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
    npgsqllinelinemarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemarrayd21mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.14693444463390792d, b: 0.5659359170204721d, c: 0.13841940852516843d),
new NpgsqlTypes.NpgsqlLine(a: 0.2314835586860018d, b: 0.272209506614144d, c: 0.7455515153530521d), } }));
                nullable =  ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { {
new NpgsqlTypes.NpgsqlLine(a: 0.38031534660158206d, b: 0.7352978433143056d, c: 0.45702418749478224d),
new NpgsqlTypes.NpgsqlLine(a: 0.5648040731640181d, b: 0.45175719397340264d, c: 0.942753027318853d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M), typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
LEFT JOIN public.npgsqllinelinemarrayd21mi mi ON mi.id = m.npgsqllinelinemarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M), typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
LEFT JOIN public.npgsqllinelinemarrayd21mi mi ON mi.id = m.npgsqllinelinemarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M), typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
LEFT JOIN public.npgsqllinelinemarrayd21mi mi ON mi.id = m.npgsqllinelinemarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M), typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 165, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 5, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 33, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
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
FROM public.npgsqllinelinemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd2e1m m
LEFT JOIN public.npgsqllinelinemarrayd21mi mi ON mi.id = m.npgsqllinelinemarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 151, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 132, 165))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((INpgsqlLineMArraylineMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlLinelineMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlLinelineMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqllinelinemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
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
FROM public.binary_npgsqllinelinemarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemarrayd21mi mi ON mi.id = m.npgsqllinelinemarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models =  ((INpgsqlLineMArraylineMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA), typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
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
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
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
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA), typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
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
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemarrayd21mi
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
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MI), typeof(NpgsqlLinelineMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMArrayD21MI>();
                var models2 = new List<NpgsqlLinelineMArrayD21MI>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD21MI>();
                var models2 = new List<NpgsqlLinelineMArrayD21MI>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA), typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                await ((INpgsqlLineMArraylineMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD21MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD21MIWA>();
                ((INpgsqlLineMArraylineMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

