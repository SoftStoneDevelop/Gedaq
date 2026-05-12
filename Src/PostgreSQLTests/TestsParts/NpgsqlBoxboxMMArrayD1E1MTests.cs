

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD1
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD1 : INpgsqlBoxMArrayboxMMArrayD1
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD1E1M[] _testData = new NpgsqlBoxboxMMArrayD1E1M[]
        {
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8883808695710882d,right: 0.7234860098828542d,bottom: 0.5310344133556467d,left: 0.5974889954406091d),
new NpgsqlTypes.NpgsqlBox(top: 0.9572393277209852d,right: 0.6477538833519313d,bottom: 0.4819643370644242d,left: 0.3024246637343526d),
new NpgsqlTypes.NpgsqlBox(top: 0.9805892804908998d,right: 0.3868631099114803d,bottom: 0.25592953109348515d,left: 0.3192203956198507d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8821260046639019d,right: 0.6036729510882177d,bottom: 0.7730774681306736d,left: 0.38140975001458266d),
new NpgsqlTypes.NpgsqlBox(top: 0.7395267264783477d,right: 0.4706384607189884d,bottom: 0.6817544700282491d,left: 0.018878986129099218d),
new NpgsqlTypes.NpgsqlBox(top: 0.9885003201542615d,right: 0.9746454170920849d,bottom: 0.7337342850475689d,left: 0.7782987682406451d),
new NpgsqlTypes.NpgsqlBox(top: 0.8982334558124364d,right: 0.9812949606913103d,bottom: 0.14410121711024504d,left: 0.006542677542482722d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6967249918995418d,right: 0.7301676788886314d,bottom: 0.44912740459256517d,left: 0.27540539380114737d),
new NpgsqlTypes.NpgsqlBox(top: 0.8197545222314633d,right: 0.7551735653632465d,bottom: 0.3416358380414557d,left: 0.2406287176541767d),
new NpgsqlTypes.NpgsqlBox(top: 0.714077354335719d,right: 0.8556253390235935d,bottom: 0.17686629142578414d,left: 0.5754840465968143d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7921739015696282d,right: 0.7681262280586323d,bottom: 0.2306346324918087d,left: 0.3152961905463212d),
new NpgsqlTypes.NpgsqlBox(top: 0.5273597075353418d,right: 0.6847141955681413d,bottom: 0.10030149393618726d,left: 0.6076915620304504d),
new NpgsqlTypes.NpgsqlBox(top: 0.4248131424028182d,right: 0.7955639071993044d,bottom: 0.3189053829755508d,left: 0.40106036586244076d),
new NpgsqlTypes.NpgsqlBox(top: 0.703222613333896d,right: 0.9114929861944661d,bottom: 0.1933252037321871d,left: 0.5550143687138757d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9551912358404122d,right: 0.7784201383753163d,bottom: 0.02778123720221115d,left: 0.010796202072339445d),
new NpgsqlTypes.NpgsqlBox(top: 0.9724261326251388d,right: 0.997475138689998d,bottom: 0.9294114029344227d,left: 0.7817861613257504d),
new NpgsqlTypes.NpgsqlBox(top: 0.981006977737229d,right: 0.15113630465577277d,bottom: 0.7116540010149546d,left: 0.008311265898301112d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9417207553750482d,right: 0.17069613510761017d,bottom: 0.23897432900809568d,left: 0.08992204397545289d),
new NpgsqlTypes.NpgsqlBox(top: 0.4574025933481638d,right: 0.8220936208152588d,bottom: 0.05091442304071747d,left: 0.22265539745033236d),
new NpgsqlTypes.NpgsqlBox(top: 0.8978054601271462d,right: 0.9449076078923664d,bottom: 0.850864084874227d,left: 0.31275198626263434d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6010203681335132d,right: 0.9200563703737371d,bottom: 0.3015676083868256d,left: 0.5086672323728818d),
new NpgsqlTypes.NpgsqlBox(top: 0.8391453486258577d,right: 0.849594957695088d,bottom: 0.7733041228253332d,left: 0.3913099574985581d),
new NpgsqlTypes.NpgsqlBox(top: 0.9643321337297711d,right: 0.6768568940983855d,bottom: 0.7742969308746513d,left: 0.6766343584170904d),
new NpgsqlTypes.NpgsqlBox(top: 0.8821116768961995d,right: 0.6610685888503245d,bottom: 0.6861481700385184d,left: 0.2519887090234224d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8050243873339487d,right: 0.35030817541756876d,bottom: 0.5940377928326169d,left: 0.05995370288836821d),
new NpgsqlTypes.NpgsqlBox(top: 0.9942695285040685d,right: 0.28937870611509675d,bottom: 0.24979621715279554d,left: 0.18516776931287937d),
new NpgsqlTypes.NpgsqlBox(top: 0.12527442217166318d,right: 0.9317866701927703d,bottom: 0.0205136185041509d,left: 0.8327083510109314d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4903610800666456d,right: 0.2802009199653913d,bottom: 0.04754390123046248d,left: 0.017795009246849403d),
new NpgsqlTypes.NpgsqlBox(top: 0.8835276191943778d,right: 0.8852387440499142d,bottom: 0.049171971152156324d,left: 0.3163084037075582d),
new NpgsqlTypes.NpgsqlBox(top: 0.6953925186733962d,right: 0.731883617873683d,bottom: 0.4423559322664319d,left: 0.3995959016916174d),
new NpgsqlTypes.NpgsqlBox(top: 0.8936123940349977d,right: 0.8774689666783366d,bottom: 0.5330901080039512d,left: 0.14480857110484557d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5856426109372076d,right: 0.2639995055927633d,bottom: 0.5832174623301495d,left: 0.030614987615928735d),
new NpgsqlTypes.NpgsqlBox(top: 0.9416223913285298d,right: 0.7026735020590953d,bottom: 0.03984754589988937d,left: 0.06232765261123108d),
new NpgsqlTypes.NpgsqlBox(top: 0.354093426490551d,right: 0.989712406255876d,bottom: 0.24701998425015614d,left: 0.6052213237663426d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8857282173440404d,right: 0.2619275990484141d,bottom: 0.03252709710179014d,left: 0.2268738590406345d),
new NpgsqlTypes.NpgsqlBox(top: 0.8237024721387597d,right: 0.842254517558653d,bottom: 0.6314960578440194d,left: 0.09253728253163651d),
new NpgsqlTypes.NpgsqlBox(top: 0.24928719502355257d,right: 0.7254723994401306d,bottom: 0.16343717694937254d,left: 0.40572628468072913d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6055563246536415d,right: 0.9227346329984486d,bottom: 0.49930525289832384d,left: 0.6186739805428891d),
new NpgsqlTypes.NpgsqlBox(top: 0.7973742508815258d,right: 0.48167476000401155d,bottom: 0.4914459489668429d,left: 0.4248312895827393d),
new NpgsqlTypes.NpgsqlBox(top: 0.4543199801318766d,right: 0.6795635535308552d,bottom: 0.1442130436936364d,left: 0.1989055714867899d),
new NpgsqlTypes.NpgsqlBox(top: 0.8015679403197353d,right: 0.5203998697198154d,bottom: 0.596348384251957d,left: 0.2941080521567422d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7506555487225132d,right: 0.8890685897886629d,bottom: 0.6992604379377092d,left: 0.4040069770082656d),
new NpgsqlTypes.NpgsqlBox(top: 0.5752300882716415d,right: 0.4035308881744545d,bottom: 0.09161963735498657d,left: 0.11653150729397266d),
new NpgsqlTypes.NpgsqlBox(top: 0.7483191900366043d,right: 0.8092616986020362d,bottom: 0.29611806538678664d,left: 0.7494296451406305d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.18672879660360264d,right: 0.3474459517849726d,bottom: 0.1793067004729485d,left: 0.061970396639849934d),
new NpgsqlTypes.NpgsqlBox(top: 0.9325812397432193d,right: 0.9111967535258764d,bottom: 0.40185067985980216d,left: 0.8467687517771152d),
new NpgsqlTypes.NpgsqlBox(top: 0.8248070170950929d,right: 0.9436665523134364d,bottom: 0.7564086732982607d,left: 0.6124784500919948d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3860729444850217d,right: 0.4619725029774052d,bottom: 0.03647031013148583d,left: 0.15512013359320376d),
new NpgsqlTypes.NpgsqlBox(top: 0.9535161003674337d,right: 0.9114611238751487d,bottom: 0.17816663968331836d,left: 0.6443432543671452d),
new NpgsqlTypes.NpgsqlBox(top: 0.5535036446139987d,right: 0.6898805210580451d,bottom: 0.29618905592839184d,left: 0.11860478505141536d),
new NpgsqlTypes.NpgsqlBox(top: 0.7720825816680004d,right: 0.5929214308087358d,bottom: 0.7348856479532186d,left: 0.5488591156761529d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9995790799118498d,right: 0.7002904156876857d,bottom: 0.2300300472100053d,left: 0.3276379322295746d),
new NpgsqlTypes.NpgsqlBox(top: 0.6333307894924842d,right: 0.26151018645959845d,bottom: 0.2600815649509086d,left: 0.05662184678440463d),
new NpgsqlTypes.NpgsqlBox(top: 0.7906319735994365d,right: 0.7859997962692633d,bottom: 0.04026948238356243d,left: 0.16287312659467124d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42707262004444624d,right: 0.9183530195788097d,bottom: 0.11726215747560043d,left: 0.7218851943120203d),
new NpgsqlTypes.NpgsqlBox(top: 0.6927394057643597d,right: 0.6875326156504586d,bottom: 0.27410652864078844d,left: 0.06216032035336594d),
new NpgsqlTypes.NpgsqlBox(top: 0.9078378098554988d,right: 0.8432403865915646d,bottom: 0.6429537912855047d,left: 0.3346002680464053d),
new NpgsqlTypes.NpgsqlBox(top: 0.6986360740406975d,right: 0.4611916131653391d,bottom: 0.6191983836177657d,left: 0.400150382599046d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8188369802866394d,right: 0.194228255874063d,bottom: 0.7544013985965099d,left: 0.02722481536258492d),
new NpgsqlTypes.NpgsqlBox(top: 0.9023683295148905d,right: 0.4315401482712605d,bottom: 0.18836448926012384d,left: 0.04263161766982371d),
new NpgsqlTypes.NpgsqlBox(top: 0.9380553051024152d,right: 0.6240328985643583d,bottom: 0.13419179506530832d,left: 0.574636425774569d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9786022990204029d,right: 0.9571590450506924d,bottom: 0.15262221737048065d,left: 0.5624593950785517d),
new NpgsqlTypes.NpgsqlBox(top: 0.9771417850364709d,right: 0.47279597799490436d,bottom: 0.08328961340974395d,left: 0.1327457405945046d),
new NpgsqlTypes.NpgsqlBox(top: 0.5482485209322333d,right: 0.9256944906763925d,bottom: 0.22201997922379113d,left: 0.7443900895754023d),
new NpgsqlTypes.NpgsqlBox(top: 0.997986040511638d,right: 0.1115073762971559d,bottom: 0.26776453603338835d,left: 0.014919994442187612d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5015000791337395d,right: 0.5995042363439336d,bottom: 0.10706676507919599d,left: 0.08650078017190233d),
new NpgsqlTypes.NpgsqlBox(top: 0.8086635683253236d,right: 0.708050482350085d,bottom: 0.19249168253310467d,left: 0.05103428290676337d),
new NpgsqlTypes.NpgsqlBox(top: 0.9335803525190326d,right: 0.8409446540072653d,bottom: 0.27005540437291586d,left: 0.7846928668699787d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6757282559394787d,right: 0.7945890794375251d,bottom: 0.06924581203289593d,left: 0.36335047678525867d),
new NpgsqlTypes.NpgsqlBox(top: 0.7212414838217198d,right: 0.694148878564823d,bottom: 0.3747758778082074d,left: 0.19633251789063744d),
new NpgsqlTypes.NpgsqlBox(top: 0.7971539613883085d,right: 0.3924907503794216d,bottom: 0.7249466937004387d,left: 0.2856396556515465d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5933121106360015d,right: 0.8226850867569313d,bottom: 0.01714858586705359d,left: 0.3058730755990604d),
new NpgsqlTypes.NpgsqlBox(top: 0.8424973550449638d,right: 0.5163873538630799d,bottom: 0.13574561058949464d,left: 0.29228613344929855d),
new NpgsqlTypes.NpgsqlBox(top: 0.762922318362742d,right: 0.3715611773455274d,bottom: 0.39509532990492113d,left: 0.1600952623679578d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.504083930808092d,right: 0.9381553856718358d,bottom: 0.4912894379219753d,left: 0.057748034355543765d),
new NpgsqlTypes.NpgsqlBox(top: 0.7734754135963897d,right: 0.30778411702538244d,bottom: 0.38529672430909523d,left: 0.032056482681252274d),
new NpgsqlTypes.NpgsqlBox(top: 0.7170607059209758d,right: 0.9139791864923638d,bottom: 0.042875169881018915d,left: 0.6192993969767677d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9486546380920866d,right: 0.9126080257332101d,bottom: 0.3442718776398761d,left: 0.3270909670854424d),
new NpgsqlTypes.NpgsqlBox(top: 0.8009255465273788d,right: 0.9556287282142109d,bottom: 0.056094080146369074d,left: 0.6481559617932502d),
new NpgsqlTypes.NpgsqlBox(top: 0.5910061383561167d,right: 0.5670075277656408d,bottom: 0.3388489642182637d,left: 0.48503661801349895d),
new NpgsqlTypes.NpgsqlBox(top: 0.0946750993631521d,right: 0.6059028069881083d,bottom: 0.04538836031695215d,left: 0.49357899251473625d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3326172785463387d,right: 0.8114177154355121d,bottom: 0.29462865006120553d,left: 0.038034748956745856d),
new NpgsqlTypes.NpgsqlBox(top: 0.7804168593695441d,right: 0.8863265018674429d,bottom: 0.34562299785757655d,left: 0.4388803444313307d),
new NpgsqlTypes.NpgsqlBox(top: 0.5974173326939418d,right: 0.7825802048366931d,bottom: 0.24758368364579686d,left: 0.12673642793490525d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7591717384744168d,right: 0.8830661365469021d,bottom: 0.1713097774181589d,left: 0.030611157116649523d),
new NpgsqlTypes.NpgsqlBox(top: 0.5767834815956757d,right: 0.9685465586282801d,bottom: 0.3588453322152342d,left: 0.7430203039862171d),
new NpgsqlTypes.NpgsqlBox(top: 0.8000393322038165d,right: 0.6234359287455804d,bottom: 0.15337300706414325d,left: 0.46865650984643326d),
new NpgsqlTypes.NpgsqlBox(top: 0.9458040327379719d,right: 0.933207669609662d,bottom: 0.5066783448874795d,left: 0.4583587913575653d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9548873515138719d,right: 0.6791476169044455d,bottom: 0.46417791682802634d,left: 0.5701938852569352d),
new NpgsqlTypes.NpgsqlBox(top: 0.29111128233582806d,right: 0.7325429424779999d,bottom: 0.0368028768995311d,left: 0.31394006521352524d),
new NpgsqlTypes.NpgsqlBox(top: 0.8184551994007079d,right: 0.925154165896559d,bottom: 0.7903268813141207d,left: 0.6400673308896104d),
new NpgsqlTypes.NpgsqlBox(top: 0.6190273298045016d,right: 0.6601747147555943d,bottom: 0.3084110518830192d,left: 0.13367050226311938d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8751612427560617d,right: 0.7098023213781458d,bottom: 0.6249272231110768d,left: 0.18602042565048038d),
new NpgsqlTypes.NpgsqlBox(top: 0.9304639331966982d,right: 0.5046228171462559d,bottom: 0.7111246202698145d,left: 0.4642527206989451d),
new NpgsqlTypes.NpgsqlBox(top: 0.9965042613796411d,right: 0.9480742279879348d,bottom: 0.3294924891842729d,left: 0.5167456627501925d),
new NpgsqlTypes.NpgsqlBox(top: 0.7183080122700031d,right: 0.995226966444011d,bottom: 0.4149830034212938d,left: 0.8820543293584999d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8818344161300549d,right: 0.4868367652948963d,bottom: 0.2324402451712858d,left: 0.07938435623774209d),
new NpgsqlTypes.NpgsqlBox(top: 0.5602674186603559d,right: 0.6077984059291479d,bottom: 0.1665188653233064d,left: 0.5713022354679526d),
new NpgsqlTypes.NpgsqlBox(top: 0.635091039893881d,right: 0.8603276977159384d,bottom: 0.30496581561251435d,left: 0.5187809592991249d),
new NpgsqlTypes.NpgsqlBox(top: 0.5306795356260328d,right: 0.9823928504825521d,bottom: 0.1267531315024779d,left: 0.26867543040938724d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7210353669151142d,right: 0.5321178166940245d,bottom: 0.508551382968649d,left: 0.11191287524593574d),
new NpgsqlTypes.NpgsqlBox(top: 0.5220016093263552d,right: 0.8198833771526102d,bottom: 0.4818944713098433d,left: 0.7505098383615202d),
new NpgsqlTypes.NpgsqlBox(top: 0.679904525644052d,right: 0.784120792019238d,bottom: 0.0007736586822518765d,left: 0.6869833476844847d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7848910872252043d,right: 0.894720860097595d,bottom: 0.02017241744536935d,left: 0.8348672973972658d),
new NpgsqlTypes.NpgsqlBox(top: 0.557494860607627d,right: 0.9936361635968806d,bottom: 0.1129201666578118d,left: 0.31220031592929154d),
new NpgsqlTypes.NpgsqlBox(top: 0.9278730877838979d,right: 0.941043215294058d,bottom: 0.43933344693990406d,left: 0.04762262151151064d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6447233381041134d,right: 0.7883371989909459d,bottom: 0.5248549116239618d,left: 0.12127564369786292d),
new NpgsqlTypes.NpgsqlBox(top: 0.1904679505057073d,right: 0.6830213893434113d,bottom: 0.16832696800029945d,left: 0.24772639633172389d),
new NpgsqlTypes.NpgsqlBox(top: 0.9961851418947069d,right: 0.4331344068161489d,bottom: 0.5931709965203843d,left: 0.26902649020074276d),
new NpgsqlTypes.NpgsqlBox(top: 0.9900640195985343d,right: 0.43493480519402616d,bottom: 0.6235279871124914d,left: 0.044161317345612794d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5901272249361467d,right: 0.9962520020384313d,bottom: 0.33936515821428215d,left: 0.7834714945033061d),
new NpgsqlTypes.NpgsqlBox(top: 0.47391281325721446d,right: 0.6309989533486063d,bottom: 0.12359285229331807d,left: 0.0011669386970416529d),
new NpgsqlTypes.NpgsqlBox(top: 0.7673125900736879d,right: 0.6778389512720053d,bottom: 0.10018399447888449d,left: 0.2067105692997715d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6907256018167331d,right: 0.6359797683594938d,bottom: 0.2713285259160574d,left: 0.5675355453495236d),
new NpgsqlTypes.NpgsqlBox(top: 0.38686715593951626d,right: 0.9694738182737563d,bottom: 0.342936690010919d,left: 0.554269040893544d),
new NpgsqlTypes.NpgsqlBox(top: 0.3235574918118348d,right: 0.8904762032473174d,bottom: 0.17688990460714604d,left: 0.1570380696302257d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5739891442598513d,right: 0.6405716805140309d,bottom: 0.524727625442278d,left: 0.03617606455773603d),
new NpgsqlTypes.NpgsqlBox(top: 0.7548720703727705d,right: 0.9425187658207332d,bottom: 0.6129496280261303d,left: 0.5115314679520481d),
new NpgsqlTypes.NpgsqlBox(top: 0.9088532149085201d,right: 0.6637619960066892d,bottom: 0.5627671883407328d,left: 0.23098756813882204d),
new NpgsqlTypes.NpgsqlBox(top: 0.904056829820067d,right: 0.855841381453427d,bottom: 0.32161801118981037d,left: 0.6462324741844843d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.81601057069488d,right: 0.682843838173456d,bottom: 0.2050886844168096d,left: 0.35685193246522273d),
new NpgsqlTypes.NpgsqlBox(top: 0.6916570120797738d,right: 0.9274346836130227d,bottom: 0.07290874990133966d,left: 0.2667157762136181d),
new NpgsqlTypes.NpgsqlBox(top: 0.47945284755223005d,right: 0.6754321323074944d,bottom: 0.20577795630862616d,left: 0.3056084174162429d),
new NpgsqlTypes.NpgsqlBox(top: 0.9334560751875547d,right: 0.11259556293484696d,bottom: 0.5966936303039104d,left: 0.08045740812315916d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4185138396863509d,right: 0.8698961279070148d,bottom: 0.4176791048507157d,left: 0.19081411194043163d),
new NpgsqlTypes.NpgsqlBox(top: 0.82388089210233d,right: 0.9312355338224828d,bottom: 0.7004503867426962d,left: 0.20796897360410826d),
new NpgsqlTypes.NpgsqlBox(top: 0.5013809756226016d,right: 0.7907733829217226d,bottom: 0.3404368264139185d,left: 0.1367631117476782d),
new NpgsqlTypes.NpgsqlBox(top: 0.7436751839747867d,right: 0.5827638751060451d,bottom: 0.3639889449877197d,left: 0.03304995732789018d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.363908300227644d,right: 0.5901526615439449d,bottom: 0.29037441803770625d,left: 0.34937413918291516d),
new NpgsqlTypes.NpgsqlBox(top: 0.9663185299632682d,right: 0.953999490575362d,bottom: 0.37711535027315723d,left: 0.3231338751910935d),
new NpgsqlTypes.NpgsqlBox(top: 0.6287763995665955d,right: 0.6744234128985904d,bottom: 0.025467827655416664d,left: 0.2654774229506317d),
new NpgsqlTypes.NpgsqlBox(top: 0.9154777648708079d,right: 0.9402325089198804d,bottom: 0.22114995996432096d,left: 0.7376632869559974d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8960720900014676d,right: 0.8340500734423407d,bottom: 0.0197689249501114d,left: 0.1835760310139355d),
new NpgsqlTypes.NpgsqlBox(top: 0.38636813390657143d,right: 0.7002867708755668d,bottom: 0.15494195954010348d,left: 0.27054290289344174d),
new NpgsqlTypes.NpgsqlBox(top: 0.32321838800943026d,right: 0.8588733130170058d,bottom: 0.16328989929420257d,left: 0.11975008084208383d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8526682204529746d,right: 0.8423552395957137d,bottom: 0.6135849507671055d,left: 0.5735481490125913d),
new NpgsqlTypes.NpgsqlBox(top: 0.12614865420064825d,right: 0.5740503304099834d,bottom: 0.02185769939196791d,left: 0.22630611772555997d),
new NpgsqlTypes.NpgsqlBox(top: 0.6762421215048781d,right: 0.9546128036207174d,bottom: 0.4020166358048324d,left: 0.76081992191969d),
new NpgsqlTypes.NpgsqlBox(top: 0.39335698393754015d,right: 0.9371610658737665d,bottom: 0.3001436703508138d,left: 0.613402710941574d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5815690479160536d,right: 0.9830410787552584d,bottom: 0.4827613979090223d,left: 0.3516246718034276d),
new NpgsqlTypes.NpgsqlBox(top: 0.3294170126719299d,right: 0.826796335578945d,bottom: 0.24537130648602712d,left: 0.4650078947110734d),
new NpgsqlTypes.NpgsqlBox(top: 0.8082552182997209d,right: 0.7775693138930593d,bottom: 0.1167864874922897d,left: 0.6137024841043984d),
new NpgsqlTypes.NpgsqlBox(top: 0.5057815661513303d,right: 0.6028593392629359d,bottom: 0.2278722608787075d,left: 0.46875364402719766d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8754588159512083d,right: 0.3262326727367546d,bottom: 0.7766133914110394d,left: 0.19413074759456794d),
new NpgsqlTypes.NpgsqlBox(top: 0.8613970339860919d,right: 0.9191221729858332d,bottom: 0.25793608208372376d,left: 0.6102361298129676d),
new NpgsqlTypes.NpgsqlBox(top: 0.8771313828866082d,right: 0.6817135951922844d,bottom: 0.11841919541128643d,left: 0.18228227244745432d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8308765533255112d,right: 0.8142485997420038d,bottom: 0.5573039599813963d,left: 0.6384917898142801d),
new NpgsqlTypes.NpgsqlBox(top: 0.4658092532888244d,right: 0.3445072499762819d,bottom: 0.22282829457854947d,left: 0.1746083521205295d),
new NpgsqlTypes.NpgsqlBox(top: 0.981897996003673d,right: 0.8223584476542165d,bottom: 0.700444958181968d,left: 0.49994027432813726d),
new NpgsqlTypes.NpgsqlBox(top: 0.7193961464212123d,right: 0.9871416849768788d,bottom: 0.36624013182560133d,left: 0.6287817231845627d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.334599514438081d,right: 0.5754660886409101d,bottom: 0.12119805066748313d,left: 0.31680281523899145d),
new NpgsqlTypes.NpgsqlBox(top: 0.5903184152664518d,right: 0.6187655328280764d,bottom: 0.41126948524400975d,left: 0.5740879009235402d),
new NpgsqlTypes.NpgsqlBox(top: 0.6212055291954963d,right: 0.8263375078487374d,bottom: 0.188686738884432d,left: 0.7695904773003491d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8563277028338412d,right: 0.6065448288671275d,bottom: 0.6542417740000691d,left: 0.14740325801735188d),
new NpgsqlTypes.NpgsqlBox(top: 0.15611668252973254d,right: 0.7572918833314382d,bottom: 0.06377280181775558d,left: 0.10287419173265522d),
new NpgsqlTypes.NpgsqlBox(top: 0.869069565170642d,right: 0.6689200064623979d,bottom: 0.2002004758715149d,left: 0.35579891550234377d),
new NpgsqlTypes.NpgsqlBox(top: 0.9109470500763991d,right: 0.5007592500840392d,bottom: 0.23888688159501548d,left: 0.15713071978367332d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2678441657197126d,right: 0.626076814306652d,bottom: 0.02418413249973561d,left: 0.12238312405743201d),
new NpgsqlTypes.NpgsqlBox(top: 0.6431040015662529d,right: 0.762291405122014d,bottom: 0.24177914898625563d,left: 0.3245426943446008d),
new NpgsqlTypes.NpgsqlBox(top: 0.6200226603454222d,right: 0.5197424449517686d,bottom: 0.38181675293378914d,left: 0.03380560458905191d),
new NpgsqlTypes.NpgsqlBox(top: 0.7135351446542613d,right: 0.8652002571227889d,bottom: 0.32775121823064135d,left: 0.774871736143616d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8608793922592284d,right: 0.45953025815722437d,bottom: 0.11832945921656379d,left: 0.002052087851318274d),
new NpgsqlTypes.NpgsqlBox(top: 0.7438158066102091d,right: 0.814407292077149d,bottom: 0.10310591966965998d,left: 0.3218931908528305d),
new NpgsqlTypes.NpgsqlBox(top: 0.6937545100671436d,right: 0.4827500062585689d,bottom: 0.6834259461733189d,left: 0.38036265957623827d),
new NpgsqlTypes.NpgsqlBox(top: 0.9879783130058591d,right: 0.9399100286307239d,bottom: 0.7356430944312843d,left: 0.20407208982864633d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8111763253409059d,right: 0.5578321864070672d,bottom: 0.11365930331425644d,left: 0.06855602607673306d),
new NpgsqlTypes.NpgsqlBox(top: 0.5448692279934335d,right: 0.38107432803219776d,bottom: 0.5035058623846179d,left: 0.08588960558237213d),
new NpgsqlTypes.NpgsqlBox(top: 0.20020182915024665d,right: 0.2966762530234841d,bottom: 0.18563945610862376d,left: 0.23546109141891236d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.532313251969742d,right: 0.656233059344392d,bottom: 0.4531872767284221d,left: 0.4685164990675774d),
new NpgsqlTypes.NpgsqlBox(top: 0.6649340983881981d,right: 0.24076330256426315d,bottom: 0.6451297605182201d,left: 0.06536900854641481d),
new NpgsqlTypes.NpgsqlBox(top: 0.8945386057799979d,right: 0.9274287136227207d,bottom: 0.6934215801421652d,left: 0.054928288830719874d),
new NpgsqlTypes.NpgsqlBox(top: 0.9556672764126849d,right: 0.8110358664700963d,bottom: 0.606116970492508d,left: 0.17620037514775588d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49497916374923445d,right: 0.8128427888123115d,bottom: 0.43188355146623403d,left: 0.11356261440495574d),
new NpgsqlTypes.NpgsqlBox(top: 0.856094842780397d,right: 0.8009969074376071d,bottom: 0.3178394826556482d,left: 0.4218989908654813d),
new NpgsqlTypes.NpgsqlBox(top: 0.5231162835370926d,right: 0.5120312411500584d,bottom: 0.027622294557296367d,left: 0.1244188718364686d),
new NpgsqlTypes.NpgsqlBox(top: 0.7035491140037339d,right: 0.234634915002916d,bottom: 0.3501970330742489d,left: 0.19345285723021743d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5475839711526371d,right: 0.976344004719659d,bottom: 0.0030015361030500953d,left: 0.8692550914371633d),
new NpgsqlTypes.NpgsqlBox(top: 0.7667316339059334d,right: 0.7761422028721245d,bottom: 0.12537192065683023d,left: 0.37117734508816436d),
new NpgsqlTypes.NpgsqlBox(top: 0.6357289016625739d,right: 0.7242873462735168d,bottom: 0.6016675882462441d,left: 0.040617067457583866d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9766999120609648d,right: 0.46064175180456435d,bottom: 0.8871696603513759d,left: 0.14747983842354417d),
new NpgsqlTypes.NpgsqlBox(top: 0.6330843463049494d,right: 0.28797015469588605d,bottom: 0.024425031688920185d,left: 0.04059145481971371d),
new NpgsqlTypes.NpgsqlBox(top: 0.8627105746106422d,right: 0.7121225438460783d,bottom: 0.7029976299244634d,left: 0.4202986058083782d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6224347165204644d,right: 0.3864218465434528d,bottom: 0.06820204183948109d,left: 0.3827771845515503d),
new NpgsqlTypes.NpgsqlBox(top: 0.673886330386101d,right: 0.7955390292533703d,bottom: 0.030049700705799043d,left: 0.32819856857465446d),
new NpgsqlTypes.NpgsqlBox(top: 0.7195157822932023d,right: 0.6981335761189352d,bottom: 0.17593532849505555d,left: 0.5923014887078818d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5277382701858051d,right: 0.5996582275608733d,bottom: 0.21370330386005776d,left: 0.4507851224984478d),
new NpgsqlTypes.NpgsqlBox(top: 0.5566176164371446d,right: 0.4302363267228735d,bottom: 0.12367141165371054d,left: 0.04062958168468811d),
new NpgsqlTypes.NpgsqlBox(top: 0.8305410934338412d,right: 0.6915586686813462d,bottom: 0.5291375692575113d,left: 0.26340714561004486d),
new NpgsqlTypes.NpgsqlBox(top: 0.709674430547212d,right: 0.8405590610962084d,bottom: 0.5586725023894613d,left: 0.24801198209349962d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8587155309059588d,right: 0.5857255917520612d,bottom: 0.7507391104487473d,left: 0.15113617320151485d),
new NpgsqlTypes.NpgsqlBox(top: 0.5240399060584755d,right: 0.53802025855791d,bottom: 0.4157116407204282d,left: 0.4438243567226988d),
new NpgsqlTypes.NpgsqlBox(top: 0.9224957431820895d,right: 0.7999493555598302d,bottom: 0.8806149073777138d,left: 0.744816019872584d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34949029851408d,right: 0.7402166876455852d,bottom: 0.2797226128552419d,left: 0.7057124044712744d),
new NpgsqlTypes.NpgsqlBox(top: 0.3186009523433069d,right: 0.8844959381259276d,bottom: 0.18674669885943884d,left: 0.38471389136550826d),
new NpgsqlTypes.NpgsqlBox(top: 0.4182614853259461d,right: 0.46187962570517394d,bottom: 0.008032379606926598d,left: 0.351768000368874d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6041544798515538d,right: 0.8939443243095355d,bottom: 0.40452244680522154d,left: 0.13504556069135765d),
new NpgsqlTypes.NpgsqlBox(top: 0.6229328064889516d,right: 0.41823994287067345d,bottom: 0.23819699631811053d,left: 0.20282645694996537d),
new NpgsqlTypes.NpgsqlBox(top: 0.5456734737348985d,right: 0.9430608251932546d,bottom: 0.21703784586736996d,left: 0.0006136667293535902d),
new NpgsqlTypes.NpgsqlBox(top: 0.5405498943409972d,right: 0.7624986457105989d,bottom: 0.41553343959464395d,left: 0.4899178969463779d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9191199175439368d,right: 0.89815026639302d,bottom: 0.45018978079051997d,left: 0.594332656838393d),
new NpgsqlTypes.NpgsqlBox(top: 0.09288459523291026d,right: 0.5418954412770403d,bottom: 0.00906460789432395d,left: 0.3439948505091851d),
new NpgsqlTypes.NpgsqlBox(top: 0.8987005082156254d,right: 0.6894833394196858d,bottom: 0.6480576995622078d,left: 0.555195592874181d),
new NpgsqlTypes.NpgsqlBox(top: 0.7268020922971583d,right: 0.9996827382352594d,bottom: 0.32731013568850276d,left: 0.22216529230055193d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5037085987688845d,right: 0.9145939839312419d,bottom: 0.11061432919115965d,left: 0.2466670478322074d),
new NpgsqlTypes.NpgsqlBox(top: 0.7649212562601037d,right: 0.9576844119883199d,bottom: 0.09839660648630422d,left: 0.3056082562708863d),
new NpgsqlTypes.NpgsqlBox(top: 0.8255073038353405d,right: 0.3234488516614086d,bottom: 0.164349193000225d,left: 0.27161385939350713d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9284381312012909d,right: 0.982698416728302d,bottom: 0.5911542046202423d,left: 0.4440714901549023d),
new NpgsqlTypes.NpgsqlBox(top: 0.9205995664327281d,right: 0.5113538635320495d,bottom: 0.7303501565183949d,left: 0.07425575670777662d),
new NpgsqlTypes.NpgsqlBox(top: 0.5127603229619158d,right: 0.3935197660365938d,bottom: 0.21513900859554325d,left: 0.21555710596755007d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7607179199638443d,right: 0.9813307229934054d,bottom: 0.6257165892892678d,left: 0.42450655999428466d),
new NpgsqlTypes.NpgsqlBox(top: 0.3905442482886953d,right: 0.7971440083684314d,bottom: 0.27963170548195926d,left: 0.6322543121750264d),
new NpgsqlTypes.NpgsqlBox(top: 0.6275488795578535d,right: 0.5056729223516958d,bottom: 0.4770268006816325d,left: 0.11647278606156564d),
new NpgsqlTypes.NpgsqlBox(top: 0.6768578691627665d,right: 0.5526072993825076d,bottom: 0.6053270160188793d,left: 0.013275521484502506d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7851079623688867d,right: 0.43807546803018627d,bottom: 0.4684186251659215d,left: 0.30559611904573336d),
new NpgsqlTypes.NpgsqlBox(top: 0.5487514073347864d,right: 0.6062644029750782d,bottom: 0.4368938106886744d,left: 0.189757667209428d),
new NpgsqlTypes.NpgsqlBox(top: 0.9397062412918848d,right: 0.8410099076037157d,bottom: 0.6696763572769278d,left: 0.4775755083858202d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8518874305403887d,right: 0.6377609562442805d,bottom: 0.6824311193197532d,left: 0.01401594073284218d),
new NpgsqlTypes.NpgsqlBox(top: 0.8693648451999909d,right: 0.36831938796937225d,bottom: 0.48636167876010594d,left: 0.2933766091544464d),
new NpgsqlTypes.NpgsqlBox(top: 0.5748749371306691d,right: 0.2048152124096364d,bottom: 0.21064745212700775d,left: 0.0292014499490717d),
new NpgsqlTypes.NpgsqlBox(top: 0.8122619635671163d,right: 0.6844675234469142d,bottom: 0.5051776910894241d,left: 0.20208158317348257d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6130679308484671d,right: 0.7161385939638607d,bottom: 0.3659669674463808d,left: 0.16987944148012246d),
new NpgsqlTypes.NpgsqlBox(top: 0.9565657114368512d,right: 0.6026791432318813d,bottom: 0.20992644831097973d,left: 0.5139310027952343d),
new NpgsqlTypes.NpgsqlBox(top: 0.990093844376522d,right: 0.07127244654557963d,bottom: 0.5243079648200707d,left: 0.045174941316095896d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8638929824067844d,right: 0.5558321157947113d,bottom: 0.5215226807357424d,left: 0.44179819112247576d),
new NpgsqlTypes.NpgsqlBox(top: 0.8209653963245915d,right: 0.4104463367117238d,bottom: 0.6885701867455816d,left: 0.2529186670367589d),
new NpgsqlTypes.NpgsqlBox(top: 0.6365271333146261d,right: 0.7901083002718091d,bottom: 0.6056627164756847d,left: 0.670709399994359d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10198011051379419d,right: 0.42546509329127424d,bottom: 0.031301614618927d,left: 0.4017239260079084d),
new NpgsqlTypes.NpgsqlBox(top: 0.6378254858882172d,right: 0.9450893619270959d,bottom: 0.5713363632055074d,left: 0.48245394006521825d),
new NpgsqlTypes.NpgsqlBox(top: 0.824890693341029d,right: 0.8911091315465253d,bottom: 0.8017421816428236d,left: 0.8055296909152448d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8883168772758231d,right: 0.5983882115809918d,bottom: 0.44666450172085204d,left: 0.4524869983488926d),
new NpgsqlTypes.NpgsqlBox(top: 0.9179923696573357d,right: 0.6294512851375859d,bottom: 0.6669941029627975d,left: 0.18593305143133354d),
new NpgsqlTypes.NpgsqlBox(top: 0.8670680911786973d,right: 0.9339938002264516d,bottom: 0.1742558293507046d,left: 0.7298978309668046d),
new NpgsqlTypes.NpgsqlBox(top: 0.9596737734173025d,right: 0.6829943359205033d,bottom: 0.35562020897306323d,left: 0.5392727126949648d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4942448881069611d,right: 0.1053205090371554d,bottom: 0.33809177732492945d,left: 0.03725974754864292d),
new NpgsqlTypes.NpgsqlBox(top: 0.5080541967421904d,right: 0.06701660011938515d,bottom: 0.2343437705350152d,left: 0.04888624996719659d),
new NpgsqlTypes.NpgsqlBox(top: 0.8776132059437983d,right: 0.8969749124318064d,bottom: 0.2738920740143933d,left: 0.8547552891701026d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7070997314179642d,right: 0.16541626570147827d,bottom: 0.45215122160676524d,left: 0.04467972118778185d),
new NpgsqlTypes.NpgsqlBox(top: 0.9272697563293496d,right: 0.5720737613014212d,bottom: 0.5925040155742203d,left: 0.0423464353910179d),
new NpgsqlTypes.NpgsqlBox(top: 0.6742058394722805d,right: 0.27805063561748555d,bottom: 0.5951053842579838d,left: 0.022359260681958815d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6311441345070921d,right: 0.7984839344722565d,bottom: 0.5503140405342403d,left: 0.36175953988975695d),
new NpgsqlTypes.NpgsqlBox(top: 0.6053200228955361d,right: 0.7309640250108352d,bottom: 0.06378861360499566d,left: 0.025774802117808915d),
new NpgsqlTypes.NpgsqlBox(top: 0.7254348526776392d,right: 0.9057941741853613d,bottom: 0.1388553776010928d,left: 0.26719055585088936d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5384167138587292d,right: 0.5130479985017212d,bottom: 0.2525568309587948d,left: 0.3052472386585845d),
new NpgsqlTypes.NpgsqlBox(top: 0.6190416402976456d,right: 0.36150782480805876d,bottom: 0.43234857157062356d,left: 0.33002883327513943d),
new NpgsqlTypes.NpgsqlBox(top: 0.9241376384418107d,right: 0.6161013489258143d,bottom: 0.7656603729848944d,left: 0.35738861687744206d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9696451157182738d,right: 0.5080652271810266d,bottom: 0.635810819127479d,left: 0.3268583577520665d),
new NpgsqlTypes.NpgsqlBox(top: 0.7788560439013902d,right: 0.4071984614086238d,bottom: 0.6754339236809577d,left: 0.18093362709161842d),
new NpgsqlTypes.NpgsqlBox(top: 0.6954587880274775d,right: 0.8134577002415134d,bottom: 0.552875152487039d,left: 0.7882327592915532d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8493499744007168d,right: 0.7214674208806304d,bottom: 0.35797647266608124d,left: 0.6655881361271633d),
new NpgsqlTypes.NpgsqlBox(top: 0.8182485960409983d,right: 0.7866250406701669d,bottom: 0.7010999306060894d,left: 0.3448034876735212d),
new NpgsqlTypes.NpgsqlBox(top: 0.6826013756784659d,right: 0.578664286750592d,bottom: 0.3876799549470339d,left: 0.427019184434249d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5933662032415267d,right: 0.3821075327282675d,bottom: 0.4549388447477678d,left: 0.20032246630302308d),
new NpgsqlTypes.NpgsqlBox(top: 0.6864101871821429d,right: 0.574270318232054d,bottom: 0.6665028622687219d,left: 0.5178098275631592d),
new NpgsqlTypes.NpgsqlBox(top: 0.40443813804131334d,right: 0.5687122239469007d,bottom: 0.28331874591866424d,left: 0.08420649375335942d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.739736419675052d,right: 0.6711056724553986d,bottom: 0.6158953439096586d,left: 0.2992155112900493d),
new NpgsqlTypes.NpgsqlBox(top: 0.5703107515096653d,right: 0.34472874144067167d,bottom: 0.2957980174434298d,left: 0.0010971138852223783d),
new NpgsqlTypes.NpgsqlBox(top: 0.9535517340058768d,right: 0.5597198866800049d,bottom: 0.45728169717954514d,left: 0.41937690845352493d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7422760117295192d,right: 0.8327771750103623d,bottom: 0.317892072789396d,left: 0.26411093877248815d),
new NpgsqlTypes.NpgsqlBox(top: 0.9781239525997919d,right: 0.7634920623250268d,bottom: 0.3677264719053812d,left: 0.043749704931108635d),
new NpgsqlTypes.NpgsqlBox(top: 0.7759551773471064d,right: 0.8548536380702525d,bottom: 0.14196729459447954d,left: 0.27793303575198036d),
new NpgsqlTypes.NpgsqlBox(top: 0.8542441548552998d,right: 0.5588816476099259d,bottom: 0.03795071598705091d,left: 0.2311673995423934d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23593647930455441d,right: 0.7748257145696317d,bottom: 0.11625560731049223d,left: 0.22058548126484623d),
new NpgsqlTypes.NpgsqlBox(top: 0.1906635823820838d,right: 0.6597310200113714d,bottom: 0.06785761842997118d,left: 0.4671875816811244d),
new NpgsqlTypes.NpgsqlBox(top: 0.7677392572041456d,right: 0.6581347680582836d,bottom: 0.36014798318161945d,left: 0.3003994763275245d),
new NpgsqlTypes.NpgsqlBox(top: 0.7285356165205856d,right: 0.9109748134327118d,bottom: 0.4073474043263101d,left: 0.868051264055773d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9377195509430731d,right: 0.8409343492861914d,bottom: 0.07867413126356293d,left: 0.7989097632659833d),
new NpgsqlTypes.NpgsqlBox(top: 0.9880226816917743d,right: 0.9505856959275933d,bottom: 0.38485215959636976d,left: 0.17753093848377954d),
new NpgsqlTypes.NpgsqlBox(top: 0.7773770736736958d,right: 0.7265542110886203d,bottom: 0.13981811172642866d,left: 0.6263184225636154d),
new NpgsqlTypes.NpgsqlBox(top: 0.9307408307713688d,right: 0.6032092982158568d,bottom: 0.7598762307437991d,left: 0.09423104409385485d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6055563246536415d,right: 0.9227346329984486d,bottom: 0.49930525289832384d,left: 0.6186739805428891d),
new NpgsqlTypes.NpgsqlBox(top: 0.7973742508815258d,right: 0.48167476000401155d,bottom: 0.4914459489668429d,left: 0.4248312895827393d),
new NpgsqlTypes.NpgsqlBox(top: 0.4543199801318766d,right: 0.6795635535308552d,bottom: 0.1442130436936364d,left: 0.1989055714867899d),
new NpgsqlTypes.NpgsqlBox(top: 0.8015679403197353d,right: 0.5203998697198154d,bottom: 0.596348384251957d,left: 0.2941080521567422d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9995790799118498d,right: 0.7002904156876857d,bottom: 0.2300300472100053d,left: 0.3276379322295746d),
new NpgsqlTypes.NpgsqlBox(top: 0.6333307894924842d,right: 0.26151018645959845d,bottom: 0.2600815649509086d,left: 0.05662184678440463d),
new NpgsqlTypes.NpgsqlBox(top: 0.7906319735994365d,right: 0.7859997962692633d,bottom: 0.04026948238356243d,left: 0.16287312659467124d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6757282559394787d,right: 0.7945890794375251d,bottom: 0.06924581203289593d,left: 0.36335047678525867d),
new NpgsqlTypes.NpgsqlBox(top: 0.7212414838217198d,right: 0.694148878564823d,bottom: 0.3747758778082074d,left: 0.19633251789063744d),
new NpgsqlTypes.NpgsqlBox(top: 0.7971539613883085d,right: 0.3924907503794216d,bottom: 0.7249466937004387d,left: 0.2856396556515465d),
}));
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9486546380920866d,right: 0.9126080257332101d,bottom: 0.3442718776398761d,left: 0.3270909670854424d),
new NpgsqlTypes.NpgsqlBox(top: 0.8009255465273788d,right: 0.9556287282142109d,bottom: 0.056094080146369074d,left: 0.6481559617932502d),
new NpgsqlTypes.NpgsqlBox(top: 0.5910061383561167d,right: 0.5670075277656408d,bottom: 0.3388489642182637d,left: 0.48503661801349895d),
new NpgsqlTypes.NpgsqlBox(top: 0.0946750993631521d,right: 0.6059028069881083d,bottom: 0.04538836031695215d,left: 0.49357899251473625d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8751612427560617d,right: 0.7098023213781458d,bottom: 0.6249272231110768d,left: 0.18602042565048038d),
new NpgsqlTypes.NpgsqlBox(top: 0.9304639331966982d,right: 0.5046228171462559d,bottom: 0.7111246202698145d,left: 0.4642527206989451d),
new NpgsqlTypes.NpgsqlBox(top: 0.9965042613796411d,right: 0.9480742279879348d,bottom: 0.3294924891842729d,left: 0.5167456627501925d),
new NpgsqlTypes.NpgsqlBox(top: 0.7183080122700031d,right: 0.995226966444011d,bottom: 0.4149830034212938d,left: 0.8820543293584999d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 11;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 75, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 135, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
FROM public.binary_npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI), typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

