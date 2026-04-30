

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0249110208787392d, y: 0.999528074815729d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039202587949654d, y: 0.36862811234552273d), new NpgsqlTypes.NpgsqlPoint(x: 0.027553200028599845d, y: 0.2427457547088132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.121942023026679d, y: 0.24961303435739857d), new NpgsqlTypes.NpgsqlPoint(x: 0.43097279999455584d, y: 0.027556914755801354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094169662611579d, y: 0.2159744990420449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22507361226757217d, y: 0.09193730689375357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511986313763848d, y: 0.08741545336006062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7463469769159815d, y: 0.11466554953933161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6578894111010154d, y: 0.6245653284057324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665912157859139d, y: 0.615756631364071d), new NpgsqlTypes.NpgsqlPoint(x: 0.21169680936764435d, y: 0.3846486865053076d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08926259185001295d, y: 0.27031061077939433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753078322876972d, y: 0.7833932079529004d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921617186514238d, y: 0.4833617430755086d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8904101951640709d, y: 0.44023209473615066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770602057177427d, y: 0.4307590369098987d), new NpgsqlTypes.NpgsqlPoint(x: 0.849178163719534d, y: 0.07072279336800957d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07784771267006119d, y: 0.14943159449187216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401740677240191d, y: 0.9023467675039699d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087735312612654d, y: 0.8345097444651773d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029787941921208372d, y: 0.7400439650197402d), new NpgsqlTypes.NpgsqlPoint(x: 0.016321706409048176d, y: 0.47592795219089556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415768562772934d, y: 0.12958417806772637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7970278217396648d, y: 0.11924698880861939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491104779708696d, y: 0.11059509003112511d), new NpgsqlTypes.NpgsqlPoint(x: 0.19059405265437213d, y: 0.6596686176954902d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28988713826421686d, y: 0.05869486231625487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20159104684782359d, y: 0.5966498902502526d), new NpgsqlTypes.NpgsqlPoint(x: 0.17787363945481227d, y: 0.5385373434017322d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6008242058441624d, y: 0.8621985106289989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2428065487500538d, y: 0.6311868079112914d), new NpgsqlTypes.NpgsqlPoint(x: 0.11087954890000096d, y: 0.40195884097424317d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41027914586949443d, y: 0.23853203165430226d), new NpgsqlTypes.NpgsqlPoint(x: 0.43880719687706515d, y: 0.7492954373407398d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537421473381248d, y: 0.49145061646830246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6417173231992612d, y: 0.8413128685898617d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608258100735894d, y: 0.7392506812352385d), new NpgsqlTypes.NpgsqlPoint(x: 0.984047901798083d, y: 0.8998150683828122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220173746362214d, y: 0.23902574069181282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056590793673155d, y: 0.500403105149359d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488233667918994d, y: 0.4004804901316945d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.72758275396712E-05d, y: 0.27235346255201975d), new NpgsqlTypes.NpgsqlPoint(x: 0.29809166594152436d, y: 0.3947931254944227d), new NpgsqlTypes.NpgsqlPoint(x: 0.36327412513420965d, y: 0.09195386454406151d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.834511251361286d, y: 0.16082192905374293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301851095615497d, y: 0.8395058727408128d), new NpgsqlTypes.NpgsqlPoint(x: 0.43391327485872144d, y: 0.21153498652478464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5531062805360124d, y: 0.49289721610492176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782350819434412d, y: 0.33149502287414623d), new NpgsqlTypes.NpgsqlPoint(x: 0.1865573814432976d, y: 0.8402509835495706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026184372933999223d, y: 0.7575518218801266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573534804082555d, y: 0.9885194795505168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864245996367533d, y: 0.44940374804749894d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131929310017665d, y: 0.8845343551657356d), new NpgsqlTypes.NpgsqlPoint(x: 0.07585258330012323d, y: 0.8327477717821898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864276645709721d, y: 0.004106443912924473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004793681170752073d, y: 0.1406485950305607d), new NpgsqlTypes.NpgsqlPoint(x: 0.2914144340043261d, y: 0.042485748936650025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5918537441585363d, y: 0.7767258987318683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95797714345356d, y: 0.3750775413753721d), new NpgsqlTypes.NpgsqlPoint(x: 0.010482210748148146d, y: 0.7923188853789878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036561455170055d, y: 0.6218517532828512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9509055154337844d, y: 0.7966483902970539d), new NpgsqlTypes.NpgsqlPoint(x: 0.5569404232234312d, y: 0.4194616163925322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913670410400002d, y: 0.49132692205889383d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3894581717868033d, y: 0.6123756332634529d), new NpgsqlTypes.NpgsqlPoint(x: 0.28224836526050845d, y: 0.3680298572952294d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489139080001251d, y: 0.6740880927724423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4928239202316387d, y: 0.9561155507838791d), new NpgsqlTypes.NpgsqlPoint(x: 0.11715561484570636d, y: 0.41125519490600815d), new NpgsqlTypes.NpgsqlPoint(x: 0.29848605758540003d, y: 0.42395465294965884d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5563706160586986d, y: 0.6358307142555562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5228279399744368d, y: 0.30209854342500564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750287384570983d, y: 0.6846374927970202d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2817072017327016d, y: 0.16805547066606774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7181780947219075d, y: 0.7687636393636885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846090163776177d, y: 0.9463350300893568d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15511795483832924d, y: 0.5905619394136068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207191881758858d, y: 0.08913060257209571d), new NpgsqlTypes.NpgsqlPoint(x: 0.19019409126532616d, y: 0.1327559646739772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6042293789909498d, y: 0.5688967230410291d), new NpgsqlTypes.NpgsqlPoint(x: 0.940928107700014d, y: 0.458754648063347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662975434404391d, y: 0.33019578052067367d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33435820228790525d, y: 0.026499133670953134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394288276112037d, y: 0.8807185171204717d), new NpgsqlTypes.NpgsqlPoint(x: 0.23265612288749649d, y: 0.30523471537960234d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9566850375211676d, y: 0.4961614747968319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542045833217854d, y: 0.09838180029036148d), new NpgsqlTypes.NpgsqlPoint(x: 0.24652984946492051d, y: 0.22287634480523255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45625030096489727d, y: 0.1630097421273523d), new NpgsqlTypes.NpgsqlPoint(x: 0.49384069559220467d, y: 0.7781133576902941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081760354047163d, y: 0.21191387541583462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302223019641208d, y: 0.6248163898385927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23158079942701593d, y: 0.9873032202758875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654373382347188d, y: 0.09308120661701191d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10197256690919354d, y: 0.9585170941322549d), new NpgsqlTypes.NpgsqlPoint(x: 0.39460919509362435d, y: 0.9522710276310952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3526344863141355d, y: 0.5684348212526176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6083207046328678d, y: 0.8393107724373606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335790827268108d, y: 0.5656304100677886d), new NpgsqlTypes.NpgsqlPoint(x: 0.2318029348938102d, y: 0.5851758025162168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4822222587824522d, y: 0.48658785524679204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178060759021775d, y: 0.7273802203978338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3227629329722692d, y: 0.1584988837045227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7102900442820159d, y: 0.46233292367820544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535836297992992d, y: 0.2661839638511101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240025732943641d, y: 0.5333462102921741d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7142225497581716d, y: 0.03178991864780889d), new NpgsqlTypes.NpgsqlPoint(x: 0.17051575663272722d, y: 0.9412012173622023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742429770223297d, y: 0.7228045630266278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2657517229566959d, y: 0.49422370122193315d), new NpgsqlTypes.NpgsqlPoint(x: 0.40606278244795857d, y: 0.5576982094168442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211745230292562d, y: 0.11299309606461694d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.778253848337857d, y: 0.7436016436622445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416221643698542d, y: 0.3649252995691573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9898358488004183d, y: 0.6267669221303774d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06433851039510907d, y: 0.14672598330299436d), new NpgsqlTypes.NpgsqlPoint(x: 0.13928589372703715d, y: 0.6000183387780942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9892535681932171d, y: 0.8480579807031859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8017464983587144d, y: 0.4875447194187771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108392434759765d, y: 0.10734663790403509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282799407864971d, y: 0.8593645993041055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9056710186481873d, y: 0.12064448256555127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214487882595793d, y: 0.20650839093702356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258867843144012d, y: 0.05819156705021333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04875245868243705d, y: 0.2533286200824868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4432147983442868d, y: 0.8603303391648809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899969008503046d, y: 0.474853106559045d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3900479851451466d, y: 0.42345626456662155d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512978391487529d, y: 0.5566120570872715d), new NpgsqlTypes.NpgsqlPoint(x: 0.08298344769570398d, y: 0.3349431917753669d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7283603805015351d, y: 0.17324576960458404d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818516407267142d, y: 0.5351579988853147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4357670314448946d, y: 0.8679966144308503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6479018290202935d, y: 0.7716408578477931d), new NpgsqlTypes.NpgsqlPoint(x: 0.2505941299090385d, y: 0.805570586366966d), new NpgsqlTypes.NpgsqlPoint(x: 0.28854567642126827d, y: 0.8537216024989497d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16709438701714685d, y: 0.5845422926405529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947192795459983d, y: 0.5824356094000761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225916260719927d, y: 0.1941146202681059d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4896489946869311d, y: 0.6289555201477482d), new NpgsqlTypes.NpgsqlPoint(x: 0.25569720345140645d, y: 0.3041411503503261d), new NpgsqlTypes.NpgsqlPoint(x: 0.2926167257043165d, y: 0.01759128031808288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6563936250869382d, y: 0.8560068348948394d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028246157468977d, y: 0.20343931861277742d), new NpgsqlTypes.NpgsqlPoint(x: 0.41584903653190763d, y: 0.4251934548084071d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022801853454670562d, y: 0.7314382385889985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824112373994228d, y: 0.1520134108238882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871246518491805d, y: 0.4650308707107157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4501622234199967d, y: 0.2663069966132253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3985729521814566d, y: 0.5204754487718654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767682182869452d, y: 0.9407488414294795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5410574816508144d, y: 0.7729070356342732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396127484583953d, y: 0.7008739338593037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007315374454931d, y: 0.9312124003925788d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24410199163325486d, y: 0.8145707579467372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227606450176739d, y: 0.2933466862054175d), new NpgsqlTypes.NpgsqlPoint(x: 0.2456345956337771d, y: 0.6886564519430541d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8257070600536067d, y: 0.282704209078363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242778678516001d, y: 0.7191105860918863d), new NpgsqlTypes.NpgsqlPoint(x: 0.048419771558493085d, y: 0.4079646354078119d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04729645113929326d, y: 0.7907743074836393d), new NpgsqlTypes.NpgsqlPoint(x: 0.43308497851069017d, y: 0.9898845668715813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863429507439549d, y: 0.4265108927987057d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7140681332270393d, y: 0.6017775886804249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480566356774869d, y: 0.9840199646184182d), new NpgsqlTypes.NpgsqlPoint(x: 0.597415160706212d, y: 0.13803119878101056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00013537855669665255d, y: 0.5522134605861151d), new NpgsqlTypes.NpgsqlPoint(x: 0.1406687008851385d, y: 0.3661758758338036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755248148530201d, y: 0.6617088099087708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2948501161429574d, y: 0.7452807375976281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921721366022898d, y: 0.8765295745637328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523636638069612d, y: 0.2062424686602189d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40574903557346176d, y: 0.8089981150132395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930065530116495d, y: 0.4589458936565598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304298333117807d, y: 0.42741180493433273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10364140772123054d, y: 0.038268582363105486d), new NpgsqlTypes.NpgsqlPoint(x: 0.3858546417628611d, y: 0.165460969112735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175451000646504d, y: 0.02832445278304896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02374684724850984d, y: 0.6476353414469439d), new NpgsqlTypes.NpgsqlPoint(x: 0.4817272160867594d, y: 0.016316445642021837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829522332273275d, y: 0.808927392330684d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2821013035760289d, y: 0.4994794629353039d), new NpgsqlTypes.NpgsqlPoint(x: 0.257535843939418d, y: 0.9677118147593391d), new NpgsqlTypes.NpgsqlPoint(x: 0.612706470732847d, y: 0.5121116884457707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004722359531844d, y: 0.8521023002588103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249505977713842d, y: 0.7980858028772895d), new NpgsqlTypes.NpgsqlPoint(x: 0.09318252570398977d, y: 0.056170918198525155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382650839720592d, y: 0.35134791156252543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3507370799804239d, y: 0.13516342274549298d), new NpgsqlTypes.NpgsqlPoint(x: 0.08603185431515681d, y: 0.9820757369089539d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2520770723249576d, y: 0.3947363476717366d), new NpgsqlTypes.NpgsqlPoint(x: 0.19647638141378054d, y: 0.9024446806050966d), new NpgsqlTypes.NpgsqlPoint(x: 0.2939399672305414d, y: 0.48375462171647465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.417381569612022d, y: 0.7044256911414789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929745570484697d, y: 0.8845363773064756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7568036609791183d, y: 0.5574572588716988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20672633933583218d, y: 0.32179493380166857d), new NpgsqlTypes.NpgsqlPoint(x: 0.4241901185133259d, y: 0.808536619377748d), new NpgsqlTypes.NpgsqlPoint(x: 0.17331330376465537d, y: 0.6104160596575707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767076049455212d, y: 0.5587778178724614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213787663873061d, y: 0.04948710001292744d), new NpgsqlTypes.NpgsqlPoint(x: 0.459509497479232d, y: 0.4185321857476393d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.548256601668245d, y: 0.7886290099868861d), new NpgsqlTypes.NpgsqlPoint(x: 0.27943892055608677d, y: 0.33883805924046007d), new NpgsqlTypes.NpgsqlPoint(x: 0.05124718756603974d, y: 0.7809285063875353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9715062933918839d, y: 0.6712399265639545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515964621748397d, y: 0.8660189279101679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7336243350487065d, y: 0.2970298050004091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143462028281806d, y: 0.7696975447915749d), new NpgsqlTypes.NpgsqlPoint(x: 0.1937886769000855d, y: 0.3736989611609274d), new NpgsqlTypes.NpgsqlPoint(x: 0.45143954196296077d, y: 0.7940978526205369d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14782615312279412d, y: 0.9738572445129589d), new NpgsqlTypes.NpgsqlPoint(x: 0.14534000401795932d, y: 0.5366011940839994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292492859002114d, y: 0.6121940967210661d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03476153291894668d, y: 0.5194579057243591d), new NpgsqlTypes.NpgsqlPoint(x: 0.19384606792958659d, y: 0.6947727262058289d), new NpgsqlTypes.NpgsqlPoint(x: 0.039983626619763735d, y: 0.04737739564250609d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6802512799947378d, y: 0.6375483473626878d), new NpgsqlTypes.NpgsqlPoint(x: 0.11418184504665818d, y: 0.4499061539819018d), new NpgsqlTypes.NpgsqlPoint(x: 0.425647671340026d, y: 0.6960853291512584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3142427393862779d, y: 0.26688300887687355d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090328518378618d, y: 0.677564000299799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9549340153654841d, y: 0.35790202823756445d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07652925396039512d, y: 0.07356905631344668d), new NpgsqlTypes.NpgsqlPoint(x: 0.47989632721675957d, y: 0.3155457720566345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330131822946218d, y: 0.5931681166646214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649868280687162d, y: 0.03952721942445159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258085954339978d, y: 0.046501887725710844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175188438183941d, y: 0.6404371742243192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769472324410872d, y: 0.6004717144718273d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651177279963499d, y: 0.7668027969646257d), new NpgsqlTypes.NpgsqlPoint(x: 0.04061318105808687d, y: 0.2689224827651364d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419765397744935d, y: 0.7473397546389481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106427986418476d, y: 0.904392397584688d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265191873659493d, y: 0.2044053686480818d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19221613215074107d, y: 0.7366615536815674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043155288208583d, y: 0.5346891801910058d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082910868555782d, y: 0.8633711678804081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2846948902804539d, y: 0.7112441265596303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45836102596578143d, y: 0.936450953944431d), new NpgsqlTypes.NpgsqlPoint(x: 0.603080808407646d, y: 0.915455412133482d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2903095317108939d, y: 0.11454783786913425d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102589059606141d, y: 0.3825277041969871d), new NpgsqlTypes.NpgsqlPoint(x: 0.36371672824118684d, y: 0.1689026193926425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9452251569169293d, y: 0.289765566809122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070046246784414d, y: 0.22532755609077693d), new NpgsqlTypes.NpgsqlPoint(x: 0.46103012693023115d, y: 0.471348307868125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7113367715479229d, y: 0.038390131818414996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228173052861279d, y: 0.31798096368321604d), new NpgsqlTypes.NpgsqlPoint(x: 0.42316475978274315d, y: 0.788877105040685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0218382291423892d, y: 0.8765957685537731d), new NpgsqlTypes.NpgsqlPoint(x: 0.125494368805809d, y: 0.9618598342959621d), new NpgsqlTypes.NpgsqlPoint(x: 0.3155036729296241d, y: 0.7395854856637011d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8501901983980207d, y: 0.3285306415248652d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314244919162548d, y: 0.9916797480716056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416241768103802d, y: 0.6428401517485395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14098791267150812d, y: 0.36671640245721426d), new NpgsqlTypes.NpgsqlPoint(x: 0.2250656237427423d, y: 0.7766022537180297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972957650733131d, y: 0.6628215722572401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09368211869402088d, y: 0.13731150637986866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8399870570880824d, y: 0.4819767861422355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3823130195426866d, y: 0.3895474205481868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6099219938314472d, y: 0.5976612515572297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215665863770797d, y: 0.8398373714202587d), new NpgsqlTypes.NpgsqlPoint(x: 0.39113135553125356d, y: 0.17877879629085924d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5770665653166548d, y: 0.44145688816609396d), new NpgsqlTypes.NpgsqlPoint(x: 0.00996493748112115d, y: 0.5731202202594613d), new NpgsqlTypes.NpgsqlPoint(x: 0.393370942818543d, y: 0.5422519273547043d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508183403351586d, y: 0.4858951796668909d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898508770046252d, y: 0.6074473217547007d), new NpgsqlTypes.NpgsqlPoint(x: 0.36267292779754035d, y: 0.47590776062834284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.727125002821929d, y: 0.8430888119465165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694208709085423d, y: 0.205359855064442d), new NpgsqlTypes.NpgsqlPoint(x: 0.1618555677102561d, y: 0.5005317371627518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820861785869528d, y: 0.7048111272213547d), new NpgsqlTypes.NpgsqlPoint(x: 0.34367973383622563d, y: 0.21483016031729107d), new NpgsqlTypes.NpgsqlPoint(x: 0.24754129369422584d, y: 0.5567026632346153d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040018062792325004d, y: 0.4183412256360516d), new NpgsqlTypes.NpgsqlPoint(x: 0.22624765913486444d, y: 0.7687290424271541d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412011336620553d, y: 0.732100939221262d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4294601411958352d, y: 0.19514053426633216d), new NpgsqlTypes.NpgsqlPoint(x: 0.03303192866627058d, y: 0.07137631572623893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342677659023424d, y: 0.3247149328049026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7144884672910689d, y: 0.16207147149599976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593209298909418d, y: 0.2630868093667251d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057585433491372d, y: 0.009444445618258968d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7916305334641995d, y: 0.9473661005039727d), new NpgsqlTypes.NpgsqlPoint(x: 0.24106655295433077d, y: 0.9224307585739222d), new NpgsqlTypes.NpgsqlPoint(x: 0.3869531540602281d, y: 0.6255150228121039d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5679442158608514d, y: 0.2009590543176405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810703941800087d, y: 0.8614038723316254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745838732276271d, y: 0.06145693524958251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37944700350574356d, y: 0.10198337822206371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4373441077304805d, y: 0.15266825440154663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3840857246443202d, y: 0.9972857892589573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3166299219859041d, y: 0.22145295220490802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171969768125007d, y: 0.9223120371217081d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124963382325867d, y: 0.9355718893837632d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738988635761792d, y: 0.5475783652666928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6175729341926061d, y: 0.7006499462768242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293345181951034d, y: 0.3586678992820075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6468325384871706d, y: 0.5040400100397084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7349630585116497d, y: 0.1832763426932924d), new NpgsqlTypes.NpgsqlPoint(x: 0.685756261027714d, y: 0.397715321527106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6379971723584251d, y: 0.0060667983656816915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575958224663838d, y: 0.8239717733611543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173887053733551d, y: 0.16359555931977443d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19263567335463783d, y: 0.5786557767167153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378604964249796d, y: 0.10525782712761877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832512034975266d, y: 0.16440522336553287d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42744246282106635d, y: 0.7382270915265374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779989071385673d, y: 0.9345289855305668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3392838815855601d, y: 0.6722807858093766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6288649110999662d, y: 0.7706676820282738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880138573229037d, y: 0.8288324549429283d), new NpgsqlTypes.NpgsqlPoint(x: 0.0812885093544422d, y: 0.5334153879201321d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42153579646990647d, y: 0.8267105422561587d), new NpgsqlTypes.NpgsqlPoint(x: 0.0855150787985236d, y: 0.16698712890622103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7182112816305688d, y: 0.9445598122315695d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36402127482509683d, y: 0.7701664583834175d), new NpgsqlTypes.NpgsqlPoint(x: 0.19610394874865056d, y: 0.9903623610045749d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945527047708745d, y: 0.38123886270100105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1351388757394687d, y: 0.4449281032389646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235096232464107d, y: 0.029789840659943723d), new NpgsqlTypes.NpgsqlPoint(x: 0.059410478379127274d, y: 0.19576262508391917d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6493231725100186d, y: 0.0878151277967687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922236717181219d, y: 0.23880500069563548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3045818235557386d, y: 0.2792790225765952d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8741873705462424d, y: 0.4898352595382536d), new NpgsqlTypes.NpgsqlPoint(x: 0.819747658602629d, y: 0.34461416900171105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7901446350306883d, y: 0.22936103959130782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8402453907284431d, y: 0.316072665291421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4777746677271132d, y: 0.9928940910746892d), new NpgsqlTypes.NpgsqlPoint(x: 0.30104128788191287d, y: 0.8477956730032132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149654483604467d, y: 0.24545593587782d), new NpgsqlTypes.NpgsqlPoint(x: 0.4523564972946026d, y: 0.03478907562821487d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946734841757767d, y: 0.05323321782179857d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9056610122554459d, y: 0.27778434080708225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180203024998884d, y: 0.45620249110373734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314515940671588d, y: 0.22204836170688436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8775098584228593d, y: 0.13522394257729686d), new NpgsqlTypes.NpgsqlPoint(x: 0.812859185862186d, y: 0.03006531358631892d), new NpgsqlTypes.NpgsqlPoint(x: 0.010723038837563315d, y: 0.2514503059005968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9540811340910305d, y: 0.6324307178473938d), new NpgsqlTypes.NpgsqlPoint(x: 0.16979973044828833d, y: 0.9751669250651156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545065867641964d, y: 0.8784066539422507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4662819010174849d, y: 0.3894823919064675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752632507807865d, y: 0.49495950178799153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581374314312523d, y: 0.8308708968351805d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40748533597901715d, y: 0.13291432710694728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820958779804029d, y: 0.1964528888675785d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932981329479889d, y: 0.44915911656184515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8779118580874385d, y: 0.8062818255514687d), new NpgsqlTypes.NpgsqlPoint(x: 0.14839672706153773d, y: 0.7661304630729345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065257576025935d, y: 0.24216195895874126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6024565613619545d, y: 0.13983145352113868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611304400318807d, y: 0.9725938661840461d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274388351158102d, y: 0.04289146953172829d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5731868115053141d, y: 0.7962491839395486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260033270851957d, y: 0.8288112870761609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706350036856147d, y: 0.9205987299731058d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9197963475965985d, y: 0.6822893744805293d), new NpgsqlTypes.NpgsqlPoint(x: 0.395057863977578d, y: 0.41528088734972224d), new NpgsqlTypes.NpgsqlPoint(x: 0.20035904998354714d, y: 0.8274189538497061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7462565466759694d, y: 0.5398878976993781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065463475389981d, y: 0.8596475389369355d), new NpgsqlTypes.NpgsqlPoint(x: 0.08947174107099753d, y: 0.5341748255334037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45530880609660906d, y: 0.0399359981712929d), new NpgsqlTypes.NpgsqlPoint(x: 0.15654734480496946d, y: 0.8625996295663892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709866538819527d, y: 0.8252532925477474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2607979083208325d, y: 0.9504074603003393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7419899170610589d, y: 0.4230982490167733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4491852993854526d, y: 0.4035349230965166d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8264890863567929d, y: 0.13705455822597834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473731874202192d, y: 0.6236099716080075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057654393862085d, y: 0.7095983557152019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17970799799618165d, y: 0.9407875838722433d), new NpgsqlTypes.NpgsqlPoint(x: 0.11787059326477856d, y: 0.31017194928099645d), new NpgsqlTypes.NpgsqlPoint(x: 0.03975630593320145d, y: 0.3019917853817162d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8355932399396325d, y: 0.5926420296115644d), new NpgsqlTypes.NpgsqlPoint(x: 0.03569068687827892d, y: 0.13270413214921062d), new NpgsqlTypes.NpgsqlPoint(x: 0.23987922688483543d, y: 0.12303168982800361d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9639186272629446d, y: 0.12347887632665133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247522912436891d, y: 0.5308762093988162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442452172476899d, y: 0.11800459848019518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375117749869632d, y: 0.1294622871712212d), new NpgsqlTypes.NpgsqlPoint(x: 0.040388914861002934d, y: 0.7142358395752834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245004277603016d, y: 0.6780946832019034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5655255492568353d, y: 0.2341890859038951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22927313388654869d, y: 0.47358429113749523d), new NpgsqlTypes.NpgsqlPoint(x: 0.749685093750134d, y: 0.2168356978910455d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9781357955415304d, y: 0.025529602034149446d), new NpgsqlTypes.NpgsqlPoint(x: 0.21848559017227331d, y: 0.9697142432815707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875070765998239d, y: 0.36980773241541864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41525342336596904d, y: 0.0647480930637514d), new NpgsqlTypes.NpgsqlPoint(x: 0.462052100479017d, y: 0.15549239325787356d), new NpgsqlTypes.NpgsqlPoint(x: 0.37664924532817445d, y: 0.4482902235134286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5288792911795673d, y: 0.05142360342772623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193360862598209d, y: 0.3138268182637789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424147664972017d, y: 0.49926229255567567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4775267339598358d, y: 0.06562320160192381d), new NpgsqlTypes.NpgsqlPoint(x: 0.14417129328723077d, y: 0.7195343746022304d), new NpgsqlTypes.NpgsqlPoint(x: 0.07350458428101014d, y: 0.5219637513774784d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39014008765788066d, y: 0.40021762876756617d), new NpgsqlTypes.NpgsqlPoint(x: 0.33735276279371795d, y: 0.3617716303481989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411361379954469d, y: 0.6828424929708645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18615127096549822d, y: 0.5027066090640111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661050525993065d, y: 0.07373216830763163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630945232425229d, y: 0.5882224846041737d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42873256124550285d, y: 0.29974339528328486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9143578400720656d, y: 0.6007694198894566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939482513681547d, y: 0.4549416913124351d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21306711126158928d, y: 0.9706476371795985d), new NpgsqlTypes.NpgsqlPoint(x: 0.08199621307080263d, y: 0.8349548064751485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8037319420900938d, y: 0.1040508580886379d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30167681059884477d, y: 0.024173282741701163d), new NpgsqlTypes.NpgsqlPoint(x: 0.89120898078227d, y: 0.8316048799417796d), new NpgsqlTypes.NpgsqlPoint(x: 0.21308820025914366d, y: 0.5349250946847892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45779763585817657d, y: 0.6011714784355614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240796613419707d, y: 0.2766924273217254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648187550977193d, y: 0.8135921766234758d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2469157072192696d, y: 0.21751585876395407d), new NpgsqlTypes.NpgsqlPoint(x: 0.47620743350594275d, y: 0.6679528013217755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266815203396973d, y: 0.42053349490600356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698654019831225d, y: 0.3458285295466309d), new NpgsqlTypes.NpgsqlPoint(x: 0.030806584400628223d, y: 0.9653359643858787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271731371136098d, y: 0.3043743369550812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8097880457038307d, y: 0.05815148843046347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8684095709591082d, y: 0.8216308072180897d), new NpgsqlTypes.NpgsqlPoint(x: 0.30478539588372444d, y: 0.2767942133085519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3861995319174364d, y: 0.8174555393332372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3352176179229467d, y: 0.9741699391086838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738624815967045d, y: 0.04645428650146288d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2430212655710342d, y: 0.8395681570102108d), new NpgsqlTypes.NpgsqlPoint(x: 0.20153883760803626d, y: 0.12085265047628557d), new NpgsqlTypes.NpgsqlPoint(x: 0.24523907878868656d, y: 0.4889775121227089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5493648655978445d, y: 0.159707153587894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319374705289845d, y: 0.9536783905120535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569458174727294d, y: 0.7522992942476785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9111716140052271d, y: 0.10814393173795434d), new NpgsqlTypes.NpgsqlPoint(x: 0.33053975155743365d, y: 0.2660703770391597d), new NpgsqlTypes.NpgsqlPoint(x: 0.020517740981448762d, y: 0.7276122726966316d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25288079043298195d, y: 0.9498325994904482d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039022608915509d, y: 0.4993438495897956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896291971340325d, y: 0.15269070641963023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1623216016279494d, y: 0.7162878392195859d), new NpgsqlTypes.NpgsqlPoint(x: 0.3990210678735293d, y: 0.6813788126511559d), new NpgsqlTypes.NpgsqlPoint(x: 0.26580547778944497d, y: 0.7238403061761985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07833893954300608d, y: 0.06044671309622074d), new NpgsqlTypes.NpgsqlPoint(x: 0.26535373982554566d, y: 0.4542028398993949d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356308155150578d, y: 0.6469407854471817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197657759949985d, y: 0.7018524051077852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673069038830966d, y: 0.6875283419608583d), new NpgsqlTypes.NpgsqlPoint(x: 0.026740846455039047d, y: 0.8573571842292019d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4064750588383881d, y: 0.15075927685797397d), new NpgsqlTypes.NpgsqlPoint(x: 0.06463610521802465d, y: 0.04870205342631273d), new NpgsqlTypes.NpgsqlPoint(x: 0.15252920728992692d, y: 0.027110764103594476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5983172589301988d, y: 0.613471348454679d), new NpgsqlTypes.NpgsqlPoint(x: 0.34558393476006666d, y: 0.9481275653220353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6304440583177658d, y: 0.708346352285097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20663473062145854d, y: 0.24443106534369197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472700416631739d, y: 0.23863951565995245d), new NpgsqlTypes.NpgsqlPoint(x: 0.695005956372941d, y: 0.6925188684588476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12467301989944868d, y: 0.17336207055552333d), new NpgsqlTypes.NpgsqlPoint(x: 0.25867371131513084d, y: 0.6757499625980334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973923734037782d, y: 0.2105927425455809d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6989959966580568d, y: 0.8560917220573753d), new NpgsqlTypes.NpgsqlPoint(x: 0.545921551241846d, y: 0.8204682832815956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222105722314574d, y: 0.8342821636045253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536906645441636d, y: 0.44380668756453745d), new NpgsqlTypes.NpgsqlPoint(x: 0.930017837344978d, y: 0.7464370198546548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347795377295933d, y: 0.35808818796625674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3070537465640052d, y: 0.7935322231332816d), new NpgsqlTypes.NpgsqlPoint(x: 0.08305963766955626d, y: 0.3770336668727119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093516911785434d, y: 0.4969935182289672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5669017473479653d, y: 0.8219698474633258d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723920000890059d, y: 0.15693636108289288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827145119525011d, y: 0.8039897181258961d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4724086168285583d, y: 0.2657749475932423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844130498830397d, y: 0.10789821549664169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7669883071670399d, y: 0.17012286759489537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6548377429053097d, y: 0.19792777795161876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2402356677987152d, y: 0.8971051708256551d), new NpgsqlTypes.NpgsqlPoint(x: 0.10116587426235257d, y: 0.23301694609550805d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7959405324482037d, y: 0.7608730408671671d), new NpgsqlTypes.NpgsqlPoint(x: 0.20230693937458621d, y: 0.7619722020373636d), new NpgsqlTypes.NpgsqlPoint(x: 0.43041142153317213d, y: 0.18622222460891336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884375702805393d, y: 0.19976901367149247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06594406951079135d, y: 0.8716330519799658d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162821155914461d, y: 0.5694309420342851d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712508876261963d, y: 0.2771378726931526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238259551787047d, y: 0.9784290610916597d), new NpgsqlTypes.NpgsqlPoint(x: 0.27232289916031105d, y: 0.010744575988524074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3675667024429138d, y: 0.6731294501854644d), new NpgsqlTypes.NpgsqlPoint(x: 0.43705108334969645d, y: 0.20806814703088683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294764812006892d, y: 0.4585636065181654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41679204562990724d, y: 0.0952080425658568d), new NpgsqlTypes.NpgsqlPoint(x: 0.6316634144216758d, y: 0.74031508969557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463535765542871d, y: 0.16779615217530364d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.727107037563954d, y: 0.19778606889437922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168705527892775d, y: 0.011839884147438084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970674936342851d, y: 0.6362379884321273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.815331468774129d, y: 0.526737137599215d), new NpgsqlTypes.NpgsqlPoint(x: 0.885012928343812d, y: 0.7520541994927415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311824512310198d, y: 0.3564076797225093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41140022458046155d, y: 0.7668341150456822d), new NpgsqlTypes.NpgsqlPoint(x: 0.42010038656047555d, y: 0.7650051537341737d), new NpgsqlTypes.NpgsqlPoint(x: 0.03924871971289856d, y: 0.5027315665785018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26176166621214714d, y: 0.9737952455802077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396157715509504d, y: 0.9946676062412485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688439413704441d, y: 0.14165938836925485d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33102905489247325d, y: 0.6207678458516962d), new NpgsqlTypes.NpgsqlPoint(x: 0.13745126294312515d, y: 0.8973576969713732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560106869967025d, y: 0.9874042215581792d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5325748686604215d, y: 0.15068498670104524d), new NpgsqlTypes.NpgsqlPoint(x: 0.668426688527676d, y: 0.8230268346269768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9649994270061069d, y: 0.4392681521415053d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7080313968701536d, y: 0.7243566284115842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317210180429073d, y: 0.7773139431642792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175251522484623d, y: 0.768096286795445d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.917068296020537d, y: 0.6529489572829839d), new NpgsqlTypes.NpgsqlPoint(x: 0.24928124535095653d, y: 0.9699037623786185d), new NpgsqlTypes.NpgsqlPoint(x: 0.1699947124099388d, y: 0.3740822448797363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8716204339626082d, y: 0.25543613133267906d), new NpgsqlTypes.NpgsqlPoint(x: 0.18497547060591435d, y: 0.7237259202715606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050831286592248d, y: 0.7191831955919462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4433285117815311d, y: 0.43675087964894166d), new NpgsqlTypes.NpgsqlPoint(x: 0.06264030404764809d, y: 0.8307184856755638d), new NpgsqlTypes.NpgsqlPoint(x: 0.16233846842390165d, y: 0.11399983249490042d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3385154355682841d, y: 0.09551124569777758d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072016556522324d, y: 0.11022897541297116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337724605802225d, y: 0.35285532447566836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6571630805349257d, y: 0.2483773880802086d), new NpgsqlTypes.NpgsqlPoint(x: 0.49913385810025823d, y: 0.41363457472013365d), new NpgsqlTypes.NpgsqlPoint(x: 0.11110578849934616d, y: 0.16948310358875418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7152945032515141d, y: 0.5571286065017406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829105224206755d, y: 0.1825142221858751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080383271344486d, y: 0.9169507894303405d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25606264101639087d, y: 0.2498780809846326d), new NpgsqlTypes.NpgsqlPoint(x: 0.42408905852361745d, y: 0.4427697479604926d), new NpgsqlTypes.NpgsqlPoint(x: 0.2733252549540317d, y: 0.8036503880642192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9802055673003576d, y: 0.6601405217935411d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682672463588125d, y: 0.7951848821418028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189339934734496d, y: 0.23967587609958851d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8567832678583122d, y: 0.2769885088763244d), new NpgsqlTypes.NpgsqlPoint(x: 0.020666466997571464d, y: 0.5696559122519163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265982660947859d, y: 0.8807208068683527d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29528936495666347d, y: 0.2179909288079176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233991190633632d, y: 0.2146143480122017d), new NpgsqlTypes.NpgsqlPoint(x: 0.28215257795713655d, y: 0.022728666335302905d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8805665499555644d, y: 0.5032738618434511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1038634132776336d, y: 0.994919695952429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653638495501285d, y: 0.7589470116566059d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7887459588716619d, y: 0.135550723179367d), new NpgsqlTypes.NpgsqlPoint(x: 0.20686115409444494d, y: 0.6493133237743423d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129831618748545d, y: 0.6013804252243501d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3797533758154419d, y: 0.7601123323109611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721883606077775d, y: 0.1078994780259045d), new NpgsqlTypes.NpgsqlPoint(x: 0.939817435467d, y: 0.8407031701547699d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9940205661586157d, y: 0.8114931194935471d), new NpgsqlTypes.NpgsqlPoint(x: 0.007360816935453762d, y: 0.015075091070048563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249448085036173d, y: 0.6669827166477986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8498174820960643d, y: 0.9320347484994443d), new NpgsqlTypes.NpgsqlPoint(x: 0.49487248560481445d, y: 0.7251492947220812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940895551389902d, y: 0.010116639321222864d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9198974042838433d, y: 0.340315169035475d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173434667619821d, y: 0.7502847821437522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631095090525341d, y: 0.8761200973440894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25480851236029156d, y: 0.4055408506556406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916426663839d, y: 0.9901103466585446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544617214469785d, y: 0.7004624729766491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669993279130732d, y: 0.817859133800481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537647473768838d, y: 0.51184193098804d), new NpgsqlTypes.NpgsqlPoint(x: 0.09169238812231872d, y: 0.9490660677700602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11972879694528293d, y: 0.25439456618161993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853844740423013d, y: 0.1555963542567208d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879826530234318d, y: 0.6134539001024554d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8522884597356118d, y: 0.5785925214798028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648766795167988d, y: 0.818407762700525d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214624300950145d, y: 0.0956595274408758d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030780945394306536d, y: 0.8766874063408385d), new NpgsqlTypes.NpgsqlPoint(x: 0.37319563948901935d, y: 0.9177727455850619d), new NpgsqlTypes.NpgsqlPoint(x: 0.23312936662384975d, y: 0.4421314903712855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31466342563805727d, y: 0.09275200815690554d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560836159275917d, y: 0.4315571844575423d), new NpgsqlTypes.NpgsqlPoint(x: 0.19104394854209195d, y: 0.5285082240441366d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5093955894224644d, y: 0.219998535513374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505984183135454d, y: 0.33104069161579086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612577428138841d, y: 0.5494937556783841d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14654573465651055d, y: 0.3696830211556996d), new NpgsqlTypes.NpgsqlPoint(x: 0.1661195482815897d, y: 0.7033308115389718d), new NpgsqlTypes.NpgsqlPoint(x: 0.41596327575591374d, y: 0.5854912548655375d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09796629013240032d, y: 0.1436859764272157d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554509153115869d, y: 0.870726671913131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477232219580554d, y: 0.20759743685932064d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49044080127372036d, y: 0.3316474841143243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565354685947122d, y: 0.6441852790576854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850271875652856d, y: 0.05826600981608243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.898497294172667d, y: 0.8946652928648201d), new NpgsqlTypes.NpgsqlPoint(x: 0.09356190796111763d, y: 0.8415248456390529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906851428895196d, y: 0.608948886926708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03295666352628879d, y: 0.5044329343043376d), new NpgsqlTypes.NpgsqlPoint(x: 0.1293916079135139d, y: 0.0916032385921326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2115831840312986d, y: 0.7540523614099318d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7385989776904108d, y: 0.16146754927033835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595929572279897d, y: 0.32440394871265343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468395212260272d, y: 0.8718682579580456d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5971606900523045d, y: 0.8878409697048582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882870145817403d, y: 0.4801353261963053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074672433741729d, y: 0.2663844265160693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17983253528978993d, y: 0.5228416279854579d), new NpgsqlTypes.NpgsqlPoint(x: 0.2971058649331514d, y: 0.6278703065107769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9769389084077748d, y: 0.34020495662142025d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9942331734959285d, y: 0.22040888113207002d), new NpgsqlTypes.NpgsqlPoint(x: 0.916345411452011d, y: 0.9226731533095447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735378038416066d, y: 0.9922933135082657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9617542265247657d, y: 0.6482810901827086d), new NpgsqlTypes.NpgsqlPoint(x: 0.22625936064327978d, y: 0.9488802442327512d), new NpgsqlTypes.NpgsqlPoint(x: 0.41720049224711897d, y: 0.14425568030186098d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026096678178692545d, y: 0.7282856990555799d), new NpgsqlTypes.NpgsqlPoint(x: 0.014798332713537365d, y: 0.5827727886592842d), new NpgsqlTypes.NpgsqlPoint(x: 0.0327213347293932d, y: 0.47319647613148397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795919154195427d, y: 0.33461908033196275d), new NpgsqlTypes.NpgsqlPoint(x: 0.08373812510077794d, y: 0.3140462330002912d), new NpgsqlTypes.NpgsqlPoint(x: 0.46794882370043156d, y: 0.7772268660804963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6310763668293171d, y: 0.38904958543669044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988336548403919d, y: 0.17704668703377557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971215223442089d, y: 0.8887147695309066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415036023913257d, y: 0.12674827820002377d), new NpgsqlTypes.NpgsqlPoint(x: 0.042547447724939014d, y: 0.7275118369916828d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497630621362117d, y: 0.7576275932944148d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2642016724238856d, y: 0.8503198653091669d), new NpgsqlTypes.NpgsqlPoint(x: 0.21883686197503482d, y: 0.5049951656871513d), new NpgsqlTypes.NpgsqlPoint(x: 0.520277656742234d, y: 0.395618083667746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9783407014165749d, y: 0.08793611351183583d), new NpgsqlTypes.NpgsqlPoint(x: 0.910989885521283d, y: 0.496194119438663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714492277397262d, y: 0.5356830551402948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9045335122150707d, y: 0.7819849991980155d), new NpgsqlTypes.NpgsqlPoint(x: 0.944529116696466d, y: 0.5191602399444271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789153525482447d, y: 0.29427089685424546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22361563442477794d, y: 0.20603760429751294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288685128910168d, y: 0.19928024304015046d), new NpgsqlTypes.NpgsqlPoint(x: 0.018247343873669553d, y: 0.11371704939894522d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25364265705027456d, y: 0.9887274979019828d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921217163916264d, y: 0.06750676194047056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183720762198936d, y: 0.2533432649795575d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020585322937647255d, y: 0.6030905435595542d), new NpgsqlTypes.NpgsqlPoint(x: 0.17816775875428614d, y: 0.12179612040173238d), new NpgsqlTypes.NpgsqlPoint(x: 0.46423587942379285d, y: 0.09569012627941131d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072909170836854d, y: 0.4624304541960389d), new NpgsqlTypes.NpgsqlPoint(x: 0.1516594800960398d, y: 0.018208049412107297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137823246249943d, y: 0.27740867011001435d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057158638830765995d, y: 0.2537097678372108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219529386898345d, y: 0.8067495967764723d), new NpgsqlTypes.NpgsqlPoint(x: 0.31496307814197666d, y: 0.8184939759166923d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6496623389060963d, y: 0.33964423597004023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775243682756722d, y: 0.669141532246716d), new NpgsqlTypes.NpgsqlPoint(x: 0.20862714083029388d, y: 0.2564196179615975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5423907660155325d, y: 0.23477151840281152d), new NpgsqlTypes.NpgsqlPoint(x: 0.4082792831566253d, y: 0.7999254360709934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505350188275421d, y: 0.353237147251972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0056319491639117425d, y: 0.2731524397961377d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864519876509136d, y: 0.9714886730481782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119358829618972d, y: 0.6114245828001321d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9534340811286373d, y: 0.9926309201368991d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410053636881373d, y: 0.30297325050507484d), new NpgsqlTypes.NpgsqlPoint(x: 0.008762942762170378d, y: 0.010803939040496258d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1418785863456543d, y: 0.7543156454021216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645478141501d, y: 0.6038683573140899d), new NpgsqlTypes.NpgsqlPoint(x: 0.3738914334464818d, y: 0.17602589239063526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13297509393688522d, y: 0.0458605885212503d), new NpgsqlTypes.NpgsqlPoint(x: 0.19898487984689583d, y: 0.0012509964489948455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9452405000435252d, y: 0.5042270239204777d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3195274359540431d, y: 0.025747866998631963d), new NpgsqlTypes.NpgsqlPoint(x: 0.05474071931600921d, y: 0.772673514486814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521819992349486d, y: 0.32130303407286376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04339336719609055d, y: 0.9766809776650006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731012507022641d, y: 0.7716755769916891d), new NpgsqlTypes.NpgsqlPoint(x: 0.25423830527301927d, y: 0.663668210466271d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9521223021602193d, y: 0.4407117425430582d), new NpgsqlTypes.NpgsqlPoint(x: 0.41091144652307177d, y: 0.14555756646684426d), new NpgsqlTypes.NpgsqlPoint(x: 0.24792704024896572d, y: 0.40156057697376835d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04001918005358451d, y: 0.7094514435052712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044159356081291d, y: 0.014716799876291375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837141460343378d, y: 0.9906684489085363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895168383421468d, y: 0.9156741677635362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786327106513027d, y: 0.02277273941994773d), new NpgsqlTypes.NpgsqlPoint(x: 0.014475785879333625d, y: 0.6755951006378701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05426482384261766d, y: 0.5927020359348002d), new NpgsqlTypes.NpgsqlPoint(x: 0.12114214078051133d, y: 0.03966745952155504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2565055094850115d, y: 0.47131701060317444d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8121961123083572d, y: 0.3978649225730875d), new NpgsqlTypes.NpgsqlPoint(x: 0.1528330557239591d, y: 0.5710414962468752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3989932781233526d, y: 0.6160370673938941d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9566850375211676d, y: 0.4961614747968319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542045833217854d, y: 0.09838180029036148d), new NpgsqlTypes.NpgsqlPoint(x: 0.24652984946492051d, y: 0.22287634480523255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45625030096489727d, y: 0.1630097421273523d), new NpgsqlTypes.NpgsqlPoint(x: 0.49384069559220467d, y: 0.7781133576902941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081760354047163d, y: 0.21191387541583462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302223019641208d, y: 0.6248163898385927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23158079942701593d, y: 0.9873032202758875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654373382347188d, y: 0.09308120661701191d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022801853454670562d, y: 0.7314382385889985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824112373994228d, y: 0.1520134108238882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871246518491805d, y: 0.4650308707107157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4501622234199967d, y: 0.2663069966132253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3985729521814566d, y: 0.5204754487718654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767682182869452d, y: 0.9407488414294795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5410574816508144d, y: 0.7729070356342732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396127484583953d, y: 0.7008739338593037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007315374454931d, y: 0.9312124003925788d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2821013035760289d, y: 0.4994794629353039d), new NpgsqlTypes.NpgsqlPoint(x: 0.257535843939418d, y: 0.9677118147593391d), new NpgsqlTypes.NpgsqlPoint(x: 0.612706470732847d, y: 0.5121116884457707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004722359531844d, y: 0.8521023002588103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249505977713842d, y: 0.7980858028772895d), new NpgsqlTypes.NpgsqlPoint(x: 0.09318252570398977d, y: 0.056170918198525155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382650839720592d, y: 0.35134791156252543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3507370799804239d, y: 0.13516342274549298d), new NpgsqlTypes.NpgsqlPoint(x: 0.08603185431515681d, y: 0.9820757369089539d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419765397744935d, y: 0.7473397546389481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106427986418476d, y: 0.904392397584688d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265191873659493d, y: 0.2044053686480818d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19221613215074107d, y: 0.7366615536815674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043155288208583d, y: 0.5346891801910058d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082910868555782d, y: 0.8633711678804081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2846948902804539d, y: 0.7112441265596303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45836102596578143d, y: 0.936450953944431d), new NpgsqlTypes.NpgsqlPoint(x: 0.603080808407646d, y: 0.915455412133482d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 141, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 78, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

