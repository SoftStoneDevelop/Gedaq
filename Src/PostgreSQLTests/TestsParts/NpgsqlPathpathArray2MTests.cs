

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.878989778124993d, y: 0.7221630744506332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176300004313315d, y: 0.005332564334192602d), new NpgsqlTypes.NpgsqlPoint(x: 0.23825296470651447d, y: 0.9784867227348047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9917526211097369d, y: 0.13592008196143646d), new NpgsqlTypes.NpgsqlPoint(x: 0.03965189845395356d, y: 0.2553813207657003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096178408620318d, y: 0.42775126526941787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7217113120099222d, y: 0.8120092618297268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009467137539143d, y: 0.7093238086875862d), new NpgsqlTypes.NpgsqlPoint(x: 0.11961104721426996d, y: 0.7918360341888396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7562672717119756d, y: 0.4944776480830101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136630622055171d, y: 0.2092551262096769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270922845041449d, y: 0.6267515479036145d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17022842524771464d, y: 0.6607147582301451d), new NpgsqlTypes.NpgsqlPoint(x: 0.21727348627987952d, y: 0.5833207868518638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179946862253947d, y: 0.9172010320081156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9239272497281061d, y: 0.5588072040323647d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633894888662138d, y: 0.278731174817612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907204801903022d, y: 0.13496293401221537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7462055896948172d, y: 0.5388114369941858d), new NpgsqlTypes.NpgsqlPoint(x: 0.39170099536810443d, y: 0.6112927885616057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091831429799825d, y: 0.9774106679131321d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763667023058121d, y: 0.4884975501529767d), new NpgsqlTypes.NpgsqlPoint(x: 0.1044916741463423d, y: 0.16373982047401747d), new NpgsqlTypes.NpgsqlPoint(x: 0.456837773515802d, y: 0.7594048606641323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43047495048062634d, y: 0.34372703394336146d), new NpgsqlTypes.NpgsqlPoint(x: 0.18884932295074652d, y: 0.8042151078734603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4245613858462366d, y: 0.4784316296614012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0028938304071656207d, y: 0.7336310455186077d), new NpgsqlTypes.NpgsqlPoint(x: 0.28294381376324074d, y: 0.7845696017690752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976691396964163d, y: 0.9043486471397048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8274008456972599d, y: 0.8309041129495522d), new NpgsqlTypes.NpgsqlPoint(x: 0.13327828573568212d, y: 0.1356866095890381d), new NpgsqlTypes.NpgsqlPoint(x: 0.4153019513219117d, y: 0.5666979503560685d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7036489903023583d, y: 0.35355495410225624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980086792905383d, y: 0.19617843977660532d), new NpgsqlTypes.NpgsqlPoint(x: 0.38907338820062487d, y: 0.4953272769206327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03704333575112373d, y: 0.9959010905548179d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756089475908323d, y: 0.9227109747687846d), new NpgsqlTypes.NpgsqlPoint(x: 0.1654645807059022d, y: 0.12122182042019836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5739629768568894d, y: 0.7829018909733156d), new NpgsqlTypes.NpgsqlPoint(x: 0.13853432523849896d, y: 0.6180882695077554d), new NpgsqlTypes.NpgsqlPoint(x: 0.055759998308774206d, y: 0.7642745116272326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5224173817087577d, y: 0.4795148843600552d), new NpgsqlTypes.NpgsqlPoint(x: 0.014952071196860928d, y: 0.4536990392230331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067108676174363d, y: 0.7157477151119461d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8129386335672616d, y: 0.20196108816014458d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937683649828229d, y: 0.5736121765661242d), new NpgsqlTypes.NpgsqlPoint(x: 0.38472250593751967d, y: 0.47250925621892115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18059598280979594d, y: 0.6584725106031548d), new NpgsqlTypes.NpgsqlPoint(x: 0.14760471919430307d, y: 0.23483385076968377d), new NpgsqlTypes.NpgsqlPoint(x: 0.978610041417612d, y: 0.0537512701598315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6811930716663819d, y: 0.5799661004373258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460230800018573d, y: 0.8325989114580333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8672990580125528d, y: 0.6993599768114723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.672648421984714d, y: 0.26852294015112d), new NpgsqlTypes.NpgsqlPoint(x: 0.47201313435920556d, y: 0.12618968817032084d), new NpgsqlTypes.NpgsqlPoint(x: 0.35574607836678684d, y: 0.4138711684223222d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22843066318377658d, y: 0.7739480448567414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9597813637906685d, y: 0.7195576504300302d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996937911122461d, y: 0.29229909341654914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8307510467140464d, y: 0.9343959746750724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227424718116364d, y: 0.9614889416422863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213115266884014d, y: 0.8863607827737472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26356834127303175d, y: 0.2732916071710899d), new NpgsqlTypes.NpgsqlPoint(x: 0.09025912177627748d, y: 0.5481091437725776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5902248339564488d, y: 0.5432368038322718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7875374523770281d, y: 0.4381186151759705d), new NpgsqlTypes.NpgsqlPoint(x: 0.04648772839103388d, y: 0.6058244489522876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798083990040247d, y: 0.6229807882173533d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3087981553848622d, y: 0.6081719632669421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388091256194618d, y: 0.4319462406270371d), new NpgsqlTypes.NpgsqlPoint(x: 0.10823476947144872d, y: 0.40422303514337943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5110961696321086d, y: 0.12446493256254754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4783350484268124d, y: 0.5630889565384293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282677512171047d, y: 0.3114969226050224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6557499199491347d, y: 0.31304333328163625d), new NpgsqlTypes.NpgsqlPoint(x: 0.765902520316796d, y: 0.24069434256032296d), new NpgsqlTypes.NpgsqlPoint(x: 0.1863836853967794d, y: 0.16641945099968014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9008106874590933d, y: 0.6759855686018745d), new NpgsqlTypes.NpgsqlPoint(x: 0.44400754217582883d, y: 0.44945714062306275d), new NpgsqlTypes.NpgsqlPoint(x: 0.40532488841622893d, y: 0.7044044846637464d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6886543016131036d, y: 0.8340393318514884d), new NpgsqlTypes.NpgsqlPoint(x: 0.08709930564453017d, y: 0.8321305979105591d), new NpgsqlTypes.NpgsqlPoint(x: 0.577181016019497d, y: 0.8398080648894479d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18781693049886627d, y: 0.1487963722525707d), new NpgsqlTypes.NpgsqlPoint(x: 0.894351763952257d, y: 0.9011148034411782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960457361501025d, y: 0.18333983659218078d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6336081558498108d, y: 0.7063504778966421d), new NpgsqlTypes.NpgsqlPoint(x: 0.21197387050106975d, y: 0.6644509331117779d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063286414890368d, y: 0.7325829173123517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06824658296092456d, y: 0.13449293704230547d), new NpgsqlTypes.NpgsqlPoint(x: 0.35230739969630886d, y: 0.5933743011044241d), new NpgsqlTypes.NpgsqlPoint(x: 0.708100472195153d, y: 0.1225964384835242d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2758662969784892d, y: 0.6230289353021671d), new NpgsqlTypes.NpgsqlPoint(x: 0.06793011259499693d, y: 0.4621863387265628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684861741472152d, y: 0.07096838507796999d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18009765430864733d, y: 0.3383310640844994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3606364120935639d, y: 0.02530166475355733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738545446918897d, y: 0.5021937024677376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9538240560642421d, y: 0.012931818848996635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068584680085616d, y: 0.633805601016656d), new NpgsqlTypes.NpgsqlPoint(x: 0.392679663547455d, y: 0.52068086444716d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9427953256061639d, y: 0.8484431768427813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187091798583064d, y: 0.3708411497620634d), new NpgsqlTypes.NpgsqlPoint(x: 0.21394887140687946d, y: 0.47132106741050406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8591500066527423d, y: 0.6667671452815765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4680895591805313d, y: 0.9502799065343829d), new NpgsqlTypes.NpgsqlPoint(x: 0.2273911056968232d, y: 0.9393638843496439d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5039418824407498d, y: 0.7096557505955017d), new NpgsqlTypes.NpgsqlPoint(x: 0.2959446839803853d, y: 0.002353031499889191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7743026005913232d, y: 0.3787003180224535d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29870222005957814d, y: 0.3873197916077994d), new NpgsqlTypes.NpgsqlPoint(x: 0.38592907832995826d, y: 0.9780939925856722d), new NpgsqlTypes.NpgsqlPoint(x: 0.16635634117035136d, y: 0.21193334071740666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11485073876303031d, y: 0.8584205912911687d), new NpgsqlTypes.NpgsqlPoint(x: 0.26279055930304507d, y: 0.8437313419204738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260539612428867d, y: 0.583099679403414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7114411167303443d, y: 0.46190075636650696d), new NpgsqlTypes.NpgsqlPoint(x: 0.720546674810271d, y: 0.6616622519026912d), new NpgsqlTypes.NpgsqlPoint(x: 0.039491932941383756d, y: 0.14121898325253923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34061534578480057d, y: 0.4023423862187079d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455192097271684d, y: 0.2520961265272197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573276143632997d, y: 0.979658201624114d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3803329323663994d, y: 0.5521153065869535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416720431622869d, y: 0.7416538401266158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816019549313914d, y: 0.7093722987067622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1891307551508553d, y: 0.9672963904367545d), new NpgsqlTypes.NpgsqlPoint(x: 0.10811963665278757d, y: 0.6727775971646797d), new NpgsqlTypes.NpgsqlPoint(x: 0.085476019919133d, y: 0.14043597800623064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5673668647060136d, y: 0.8278062316808342d), new NpgsqlTypes.NpgsqlPoint(x: 0.8007900606088703d, y: 0.2548733421663243d), new NpgsqlTypes.NpgsqlPoint(x: 0.046574535425525365d, y: 0.22738789391851244d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40598570528363576d, y: 0.11193564299975278d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027954691266171d, y: 0.07248885408532357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451511830812283d, y: 0.19989216998647863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5281440059055836d, y: 0.38245000290177045d), new NpgsqlTypes.NpgsqlPoint(x: 0.07293437864926544d, y: 0.6557400928203695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604156938480249d, y: 0.5957680436158204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8572554230781197d, y: 0.15811807215217788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634647032897687d, y: 0.4082325878928753d), new NpgsqlTypes.NpgsqlPoint(x: 0.30620588721680664d, y: 0.35825907525803746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531938209619766d, y: 0.8233466551371967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354364252254187d, y: 0.4169080055929756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385623637286489d, y: 0.3108763913506821d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14425065897326284d, y: 0.03530615331606324d), new NpgsqlTypes.NpgsqlPoint(x: 0.198281385236023d, y: 0.5717291955353396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849748240183097d, y: 0.12759134059304578d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4067880960929723d, y: 0.2763500019405888d), new NpgsqlTypes.NpgsqlPoint(x: 0.07377993313204556d, y: 0.1089883020579927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8246741163469369d, y: 0.49226663320858577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600757407893819d, y: 0.9511132916583189d), new NpgsqlTypes.NpgsqlPoint(x: 0.729779707693884d, y: 0.8824771576312654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606353857087268d, y: 0.735633539892546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8947964508487701d, y: 0.3451954760339073d), new NpgsqlTypes.NpgsqlPoint(x: 0.38550610601406166d, y: 0.21314239328758988d), new NpgsqlTypes.NpgsqlPoint(x: 0.09237039561524407d, y: 0.08889075681354563d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.329090279901997d, y: 0.8185619239433776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996605923466313d, y: 0.08139839601178189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858154412428315d, y: 0.5738872705980088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26580371478926845d, y: 0.8607938804113229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259300516606005d, y: 0.2607179331140026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622362161283634d, y: 0.5955139869683118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20892646639721824d, y: 0.3581518533694026d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346938473810745d, y: 0.2873245318400419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018009844260802d, y: 0.769354705221272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9185053101933963d, y: 0.47316715262657705d), new NpgsqlTypes.NpgsqlPoint(x: 0.29856250464419287d, y: 0.32175172978356426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8155822544527281d, y: 0.5046221504447931d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8290831510839781d, y: 0.318526446817359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943129412160987d, y: 0.22338237753179468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785386689882114d, y: 0.625596244708694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2567912578500985d, y: 0.4768841319614535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3328773478990328d, y: 0.1421632525683758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9596220675334969d, y: 0.47961324419603846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8561563258848403d, y: 0.4014135396020103d), new NpgsqlTypes.NpgsqlPoint(x: 0.40330115851334136d, y: 0.8883421302304125d), new NpgsqlTypes.NpgsqlPoint(x: 0.14400019024165323d, y: 0.2628931376825815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7098434862287497d, y: 0.3235365943910258d), new NpgsqlTypes.NpgsqlPoint(x: 0.12239626150624927d, y: 0.5891990649936688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609208913235712d, y: 0.37350326713755067d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.751608436084839d, y: 0.9643916925781763d), new NpgsqlTypes.NpgsqlPoint(x: 0.37059798407358246d, y: 0.0409613202247473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470641687225665d, y: 0.8979693436736039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8186193132533142d, y: 0.6692981915846636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059318112448332d, y: 0.056736162877187746d), new NpgsqlTypes.NpgsqlPoint(x: 0.3189376387801428d, y: 0.36791970995073475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.996860681574631d, y: 0.6600266841144601d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196750303915372d, y: 0.5900716007550776d), new NpgsqlTypes.NpgsqlPoint(x: 0.06445620856139156d, y: 0.9137698524688845d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10501893420101616d, y: 0.5280372169505342d), new NpgsqlTypes.NpgsqlPoint(x: 0.19504696205209726d, y: 0.6791278320749573d), new NpgsqlTypes.NpgsqlPoint(x: 0.14553843899080854d, y: 0.6236248668813075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8815204614544265d, y: 0.6138062726567086d), new NpgsqlTypes.NpgsqlPoint(x: 0.22549975448000814d, y: 0.3522261906640891d), new NpgsqlTypes.NpgsqlPoint(x: 0.27886940676222616d, y: 0.32618407904091984d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389897189030303d, y: 0.940347487933733d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311434068842916d, y: 0.5553274062109577d), new NpgsqlTypes.NpgsqlPoint(x: 0.00329485320273315d, y: 0.5661380677048392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247783119983407d, y: 0.03009576799990532d), new NpgsqlTypes.NpgsqlPoint(x: 0.06950372348274747d, y: 0.49464338765517013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069340340210364d, y: 0.6348258886124722d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49731677844787436d, y: 0.7010654487997019d), new NpgsqlTypes.NpgsqlPoint(x: 0.34427670879981276d, y: 0.34929796333838103d), new NpgsqlTypes.NpgsqlPoint(x: 0.14080642062987547d, y: 0.09048133283115045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8894226816241368d, y: 0.4173628660734565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375095521970717d, y: 0.6045554401574365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373650530982629d, y: 0.4445867404976803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5963220125032137d, y: 0.7326606096123561d), new NpgsqlTypes.NpgsqlPoint(x: 0.053188220154100074d, y: 0.801927614150148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561692246986214d, y: 0.20224310871358975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1808071755324293d, y: 0.5784965220062719d), new NpgsqlTypes.NpgsqlPoint(x: 0.19306398276843695d, y: 0.5583986124185898d), new NpgsqlTypes.NpgsqlPoint(x: 0.33367078049282317d, y: 0.1998772059455617d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7304001245664847d, y: 0.7970027631358283d), new NpgsqlTypes.NpgsqlPoint(x: 0.031846607605883204d, y: 0.6867781818132698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101248721296946d, y: 0.4884518934560229d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8292809111216066d, y: 0.946723344521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254933456836062d, y: 0.45826731413047317d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635821527564338d, y: 0.002627461453798108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05709973719729d, y: 0.1515798022202277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657580668628495d, y: 0.3155417297839386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281866793220264d, y: 0.08236535737896822d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5892645130043708d, y: 0.6663559353501103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176284468814988d, y: 0.14483671399643083d), new NpgsqlTypes.NpgsqlPoint(x: 0.64401183387093d, y: 0.5733119196351011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46687888608850214d, y: 0.746697637866908d), new NpgsqlTypes.NpgsqlPoint(x: 0.06868608225574901d, y: 0.5866350172381187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574061871507752d, y: 0.5461379381398876d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23151271278419527d, y: 0.15671214605212258d), new NpgsqlTypes.NpgsqlPoint(x: 0.1184596837428431d, y: 0.9180805473524094d), new NpgsqlTypes.NpgsqlPoint(x: 0.3257507194107184d, y: 0.7418619959518463d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649562620074196d, y: 0.42264695192886104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3468986968197669d, y: 0.9466665489377389d), new NpgsqlTypes.NpgsqlPoint(x: 0.631166042632125d, y: 0.1019481234524463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6693446752685187d, y: 0.6351641714018863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7945300495820897d, y: 0.47152019934227907d), new NpgsqlTypes.NpgsqlPoint(x: 0.07009834748361754d, y: 0.22110127393436585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326997870416467d, y: 0.12494083446584425d), new NpgsqlTypes.NpgsqlPoint(x: 0.08298759851818605d, y: 0.35826345087405054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175515845735857d, y: 0.13631631486775386d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4421148255920656d, y: 0.07861676049401889d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842693898276989d, y: 0.12709741948869568d), new NpgsqlTypes.NpgsqlPoint(x: 0.276346430694155d, y: 0.8492895732583934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.372931841007318d, y: 0.18945829398094993d), new NpgsqlTypes.NpgsqlPoint(x: 0.1239561545725355d, y: 0.030302743330575366d), new NpgsqlTypes.NpgsqlPoint(x: 0.22039665033593892d, y: 0.4673311514444993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0457309663298755d, y: 0.7509489720107673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6733207211366766d, y: 0.881658690942858d), new NpgsqlTypes.NpgsqlPoint(x: 0.8523071124152776d, y: 0.5840585655863751d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14659295218613722d, y: 0.8994128538803903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457265606878912d, y: 0.022968866983426706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273956611273048d, y: 0.6083859064909635d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9831095584959014d, y: 0.8096301931942629d), new NpgsqlTypes.NpgsqlPoint(x: 0.48256049474179163d, y: 0.11409610422490257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611324995435259d, y: 0.3531250805253917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1673956935547769d, y: 0.08996324811151823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744896157513306d, y: 0.9978235489307385d), new NpgsqlTypes.NpgsqlPoint(x: 0.27689523606480904d, y: 0.9782506915941844d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04318150688463662d, y: 0.2633275463157596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1308680802296176d, y: 0.9775414605451588d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991801479846809d, y: 0.5590772334232461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44126845130426207d, y: 0.2643177808967918d), new NpgsqlTypes.NpgsqlPoint(x: 0.09572058705986475d, y: 0.7619554509122085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680218100810593d, y: 0.376675388795892d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10909985226478724d, y: 0.5182964638349608d), new NpgsqlTypes.NpgsqlPoint(x: 0.39082544803403485d, y: 0.9938768415477527d), new NpgsqlTypes.NpgsqlPoint(x: 0.677568474342944d, y: 0.5112384892890764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197788228732438d, y: 0.7701404537837262d), new NpgsqlTypes.NpgsqlPoint(x: 0.036140055496413415d, y: 0.48775794977916154d), new NpgsqlTypes.NpgsqlPoint(x: 0.037159936683741956d, y: 0.8118578254793998d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4065114872583673d, y: 0.21659857755142498d), new NpgsqlTypes.NpgsqlPoint(x: 0.614201610266874d, y: 0.6688414766510764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418979582635156d, y: 0.40988177230525835d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5954666568805429d, y: 0.32163229338928645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393972116345791d, y: 0.26177326669418277d), new NpgsqlTypes.NpgsqlPoint(x: 0.39375537966952623d, y: 0.9642276012431003d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6107832799362938d, y: 0.6899495483925098d), new NpgsqlTypes.NpgsqlPoint(x: 0.33609017787300743d, y: 0.6340179646744835d), new NpgsqlTypes.NpgsqlPoint(x: 0.1529725081176202d, y: 0.3041448952960981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6836097466492471d, y: 0.5996253536194258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529027910957653d, y: 0.7942227989542857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9960964157488178d, y: 0.2792514926636467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6031284773327866d, y: 0.2787271903254437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418623597049544d, y: 0.23858708500002257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8532116716146385d, y: 0.9444230814694237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8068271060697437d, y: 0.6941220577758703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307845227099651d, y: 0.676878464561503d), new NpgsqlTypes.NpgsqlPoint(x: 0.48603326422915205d, y: 0.029419249936899705d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5800082364746151d, y: 0.7494629848641555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034101069974206d, y: 0.13036070528750066d), new NpgsqlTypes.NpgsqlPoint(x: 0.4415662232932198d, y: 0.093070533817596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29682189033891626d, y: 0.4904170249789205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764755391209881d, y: 0.11525979461835711d), new NpgsqlTypes.NpgsqlPoint(x: 0.47517902307042914d, y: 0.23869655418310054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545497467249379d, y: 0.43092572959633946d), new NpgsqlTypes.NpgsqlPoint(x: 0.363805840707492d, y: 0.019866250603760016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218142315466061d, y: 0.169216946828757d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3810650554485183d, y: 0.6483099848019686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316383531335823d, y: 0.6801611955838779d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610330945378765d, y: 0.3368363679179842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338448565533059d, y: 0.2779288658937462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776373173584006d, y: 0.5510194692973597d), new NpgsqlTypes.NpgsqlPoint(x: 0.11186333211562949d, y: 0.8354238226301206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03597771388882387d, y: 0.8756017820853879d), new NpgsqlTypes.NpgsqlPoint(x: 0.2426979394821288d, y: 0.8149836397192218d), new NpgsqlTypes.NpgsqlPoint(x: 0.40820756198215424d, y: 0.6071713049981406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21840861715727156d, y: 0.1868024521221845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798450884855396d, y: 0.29285019662128264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459160980199803d, y: 0.09700650327883531d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34390761981971585d, y: 0.4220860243377643d), new NpgsqlTypes.NpgsqlPoint(x: 0.2927694250297179d, y: 0.313618819652283d), new NpgsqlTypes.NpgsqlPoint(x: 0.1975618288715627d, y: 0.8576678475511734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4668665065016234d, y: 0.26170096030888546d), new NpgsqlTypes.NpgsqlPoint(x: 0.26228768515824596d, y: 0.6358344584530692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872269651674639d, y: 0.16525090098159223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3892271870382281d, y: 0.6822661814260543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7430716614701726d, y: 0.44603154309942517d), new NpgsqlTypes.NpgsqlPoint(x: 0.18867795996307324d, y: 0.4046835022693108d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.415334671857409d, y: 0.5920751468085322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129533391520197d, y: 0.06689774601957799d), new NpgsqlTypes.NpgsqlPoint(x: 0.494745507505154d, y: 0.5679180534848242d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34598309081914413d, y: 0.940867033840818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934380838800935d, y: 0.5706826164621894d), new NpgsqlTypes.NpgsqlPoint(x: 0.10456808308299037d, y: 0.9890265029892431d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6659001919353534d, y: 0.1756004508137815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8817231062621683d, y: 0.7958374653191818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7700279970204383d, y: 0.9657210295851943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6983334481248795d, y: 0.10590013733166725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886668659085307d, y: 0.3580005990681093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663645200817155d, y: 0.2722383930409138d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9336970024960979d, y: 0.5121608873830517d), new NpgsqlTypes.NpgsqlPoint(x: 0.37544507322727705d, y: 0.02112723458814869d), new NpgsqlTypes.NpgsqlPoint(x: 0.835582537592651d, y: 0.4619419148355973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9137355558756615d, y: 0.11434672750115893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089498405365211d, y: 0.5996060913247349d), new NpgsqlTypes.NpgsqlPoint(x: 0.14828382405037555d, y: 0.700716555013848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020913796132774887d, y: 0.08033415618212236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035040810548868d, y: 0.19726010993337395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818664490159618d, y: 0.34042423322505044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5263779206248272d, y: 0.5728878928189355d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881327213724922d, y: 0.18356476269056776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498583808925001d, y: 0.01669867786363366d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11285615330329546d, y: 0.07479246899659553d), new NpgsqlTypes.NpgsqlPoint(x: 0.43354077902643495d, y: 0.7647150641446915d), new NpgsqlTypes.NpgsqlPoint(x: 0.19212114880342102d, y: 0.008022892311301377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39516922185457604d, y: 0.5051905906067966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244229822413408d, y: 0.2705444787416743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295843496889237d, y: 0.6558198926764596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4022705620350252d, y: 0.7924912477267912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236578430796342d, y: 0.6739698259933846d), new NpgsqlTypes.NpgsqlPoint(x: 0.46913587526829403d, y: 0.35641965465227887d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4343867761405379d, y: 0.6989875080030462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682045170970597d, y: 0.8378562066683519d), new NpgsqlTypes.NpgsqlPoint(x: 0.10020069386425023d, y: 0.45459731141189996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07447229130437638d, y: 0.8346128091412262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8998973214273513d, y: 0.7972142630013782d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235201494561626d, y: 0.6732039892765451d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3000250963808878d, y: 0.6901873849018465d), new NpgsqlTypes.NpgsqlPoint(x: 0.694554864826972d, y: 0.38746644183363843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751828832825935d, y: 0.5469453675574011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2646626018820222d, y: 0.08488218840902839d), new NpgsqlTypes.NpgsqlPoint(x: 0.06907212734933166d, y: 0.7121153775922849d), new NpgsqlTypes.NpgsqlPoint(x: 0.29772683101800157d, y: 0.5645511437363342d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307327669908247d, y: 0.43516431289832125d), new NpgsqlTypes.NpgsqlPoint(x: 0.17184215110900514d, y: 0.39719676757164935d), new NpgsqlTypes.NpgsqlPoint(x: 0.38916109677100963d, y: 0.7770868547252446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11701028825090265d, y: 0.5737454235139424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476487307343981d, y: 0.1777065552373559d), new NpgsqlTypes.NpgsqlPoint(x: 0.32076064259989734d, y: 0.34593566020775157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3969877745941879d, y: 0.18662864924670552d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122801260357535d, y: 0.5559675243517578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8688141002537227d, y: 0.8514664126128045d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22876752766470698d, y: 0.9841804558617598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121233257028805d, y: 0.5965669913931714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176095450632472d, y: 0.43366528557171624d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7209227022620663d, y: 0.1602471131496792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888764314753347d, y: 0.18657262785668427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437371473058869d, y: 0.1677630135477941d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895494061432898d, y: 0.6495418125215656d), new NpgsqlTypes.NpgsqlPoint(x: 0.23788192668225838d, y: 0.1953801298889618d), new NpgsqlTypes.NpgsqlPoint(x: 0.37006089922385954d, y: 0.270510130045889d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0743910399991341d, y: 0.0022868858350729715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759301371362863d, y: 0.003281523232166794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594825601760135d, y: 0.9676068550864068d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9370656530313015d, y: 0.9467915807950856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9108492111689733d, y: 0.09600077129028617d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792747702378143d, y: 0.4646714468960692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9469798686760671d, y: 0.989410059043151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526686051319784d, y: 0.956103442632649d), new NpgsqlTypes.NpgsqlPoint(x: 0.3837852351544073d, y: 0.267967510391078d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9126072205195602d, y: 0.5325167873378471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478044688569749d, y: 0.5833524638464171d), new NpgsqlTypes.NpgsqlPoint(x: 0.467998241700356d, y: 0.6177299288728333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9628157955824175d, y: 0.14243560405844058d), new NpgsqlTypes.NpgsqlPoint(x: 0.09828607447000748d, y: 0.8478427391647378d), new NpgsqlTypes.NpgsqlPoint(x: 0.442286591659944d, y: 0.2841328273990025d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5732447431474106d, y: 0.17715967712749814d), new NpgsqlTypes.NpgsqlPoint(x: 0.45867600518064855d, y: 0.4449528297685854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154428575243405d, y: 0.27925120984215757d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8837751648716138d, y: 0.05883070809341839d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445002273540468d, y: 0.7307541593100958d), new NpgsqlTypes.NpgsqlPoint(x: 0.614813994915749d, y: 0.23748720563889836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7484757210219327d, y: 0.23819072152389098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697973928697457d, y: 0.24280895737720143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507910513457575d, y: 0.40959298733968885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4523803435226358d, y: 0.7629162894999326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113142852795568d, y: 0.94127104342567d), new NpgsqlTypes.NpgsqlPoint(x: 0.36850980939065303d, y: 0.8970872445484608d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18071510715531014d, y: 0.9243155062586815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3023022080681813d, y: 0.3046445503218532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622549605150835d, y: 0.1502084435302644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3654571894992801d, y: 0.9229179776470018d), new NpgsqlTypes.NpgsqlPoint(x: 0.26430702149314933d, y: 0.7456084122009545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887094316071381d, y: 0.6148658266300067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7862383828121865d, y: 0.034803238010482684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961384922914649d, y: 0.4661520657315248d), new NpgsqlTypes.NpgsqlPoint(x: 0.19778953857051795d, y: 0.4807848220475932d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4358428843803115d, y: 0.33938650307593066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387939365921006d, y: 0.8565174628284966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3166168800432885d, y: 0.32497099214316016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8413622483745389d, y: 0.5275498819602968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4364401278717973d, y: 0.5373550667055266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537133837031105d, y: 0.9771548718497005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11530551762830399d, y: 0.2799422646144999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541539308619595d, y: 0.9096891386606836d), new NpgsqlTypes.NpgsqlPoint(x: 0.996892599570835d, y: 0.7462070032149607d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8888943203620628d, y: 0.007844150526842508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389853625451279d, y: 0.26259538782999314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917381881262307d, y: 0.3884927296545273d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.392778361689763d, y: 0.41329339958103917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624488957394403d, y: 0.28573984646187744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371809708206769d, y: 0.1341395632822553d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.741234807565379d, y: 0.6082809628401193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3126637321049779d, y: 0.19018107801894335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449466967475717d, y: 0.33783366308864093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7006057354497003d, y: 0.5993003374564979d), new NpgsqlTypes.NpgsqlPoint(x: 0.738333614709055d, y: 0.2706709976013053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722188791419584d, y: 0.10262050485648155d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7277521746697194d, y: 0.824838664079597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068824735598533d, y: 0.5373708419459836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3357982994992744d, y: 0.6711713023968097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7004280211665901d, y: 0.7180271855939091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255105620927629d, y: 0.9856515002547951d), new NpgsqlTypes.NpgsqlPoint(x: 0.28020956274965425d, y: 0.8837192311252119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22870377732015812d, y: 0.6613213526559342d), new NpgsqlTypes.NpgsqlPoint(x: 0.0656798824361825d, y: 0.24806989104440558d), new NpgsqlTypes.NpgsqlPoint(x: 0.06254765066685941d, y: 0.10498738419489262d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15995750939922326d, y: 0.6926527087166565d), new NpgsqlTypes.NpgsqlPoint(x: 0.017551766715746875d, y: 0.7108183301240671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836767782775646d, y: 0.9304152773583421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36636780642091527d, y: 0.3424766098603349d), new NpgsqlTypes.NpgsqlPoint(x: 0.44967708190438227d, y: 0.2916209034094708d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617522776274421d, y: 0.5966923673934689d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04467641036522496d, y: 0.08809442990424787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093403016418141d, y: 0.4788973187018061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433733839646877d, y: 0.8358555460090334d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38469646810347324d, y: 0.10782680289288116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562368472610702d, y: 0.2236380777117979d), new NpgsqlTypes.NpgsqlPoint(x: 0.5995918141855834d, y: 0.48498508823548603d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.175334891798825d, y: 0.883294841957452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990382961994279d, y: 0.4350525328172714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6051100979939485d, y: 0.8076571835110632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22868431360191388d, y: 0.8596124138153715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4074075994136954d, y: 0.9670246747834087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918593715719394d, y: 0.02012318417479564d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9917067314189238d, y: 0.09464192164241969d), new NpgsqlTypes.NpgsqlPoint(x: 0.8212851135104028d, y: 0.5390066457614984d), new NpgsqlTypes.NpgsqlPoint(x: 0.48274096155672863d, y: 0.7057495809204417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33583175289518763d, y: 0.22409107648622928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858668468107433d, y: 0.7572143033232505d), new NpgsqlTypes.NpgsqlPoint(x: 0.10876689408666862d, y: 0.35780894964205867d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9425943476890837d, y: 0.5913433815184184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186415888387748d, y: 0.8200073439094903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225739108845492d, y: 0.4206659465577902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7298701093525143d, y: 0.39987578328757734d), new NpgsqlTypes.NpgsqlPoint(x: 0.22251022826172973d, y: 0.46694795479753826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815767135814031d, y: 0.2481433269780493d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7289476269475609d, y: 0.5314641847351016d), new NpgsqlTypes.NpgsqlPoint(x: 0.046383862807389264d, y: 0.8205209775583011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441827342956609d, y: 0.642099366256435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15775266673693644d, y: 0.8753070602257862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3059681578657837d, y: 0.5515449798152822d), new NpgsqlTypes.NpgsqlPoint(x: 0.04462080077461328d, y: 0.0941135583380609d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8923908484585775d, y: 0.018381018481962164d), new NpgsqlTypes.NpgsqlPoint(x: 0.17941248567356605d, y: 0.9262075736780251d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602903839660784d, y: 0.6189517607976579d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8325984921644782d, y: 0.5011337523111907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021060691023809d, y: 0.00877200234647646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2748700519432751d, y: 0.577524369472481d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.957135846452516d, y: 0.8098840567241323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435113392054144d, y: 0.09208442410673967d), new NpgsqlTypes.NpgsqlPoint(x: 0.24429722867510717d, y: 0.9160251018499644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8867994795558904d, y: 0.03686188671578139d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843171233615228d, y: 0.8576962549457484d), new NpgsqlTypes.NpgsqlPoint(x: 0.33339843937559466d, y: 0.2897723519396317d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4377252310831109d, y: 0.5175075208384357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470510835314362d, y: 0.9526122369418393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713064336633723d, y: 0.9688380124363333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5276345322714618d, y: 0.8761962924077166d), new NpgsqlTypes.NpgsqlPoint(x: 0.21410411934267026d, y: 0.7290729487355375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913704036918889d, y: 0.16548446575612885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769421193263839d, y: 0.2054158576865912d), new NpgsqlTypes.NpgsqlPoint(x: 0.04143307628894388d, y: 0.9975702803857751d), new NpgsqlTypes.NpgsqlPoint(x: 0.4800294315032033d, y: 0.9736599917604107d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5760750571505797d, y: 0.9739210414180248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4291856840146282d, y: 0.642892331413158d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393780551457042d, y: 0.7275429692025778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8217887006825835d, y: 0.878143053997808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637290533899226d, y: 0.19811714672352398d), new NpgsqlTypes.NpgsqlPoint(x: 0.38240947794228475d, y: 0.9399781561586072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040476039080087345d, y: 0.2962315822756689d), new NpgsqlTypes.NpgsqlPoint(x: 0.8514857017856367d, y: 0.787272304717111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620043370153414d, y: 0.025222192679141275d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9017538746217609d, y: 0.6056091931171712d), new NpgsqlTypes.NpgsqlPoint(x: 0.1093191179335552d, y: 0.5226543298280566d), new NpgsqlTypes.NpgsqlPoint(x: 0.19895480796793819d, y: 0.06400533527994345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9550645255935581d, y: 0.3115481606048621d), new NpgsqlTypes.NpgsqlPoint(x: 0.011045643153008267d, y: 0.0868415717894424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657909155513938d, y: 0.26250115839190236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9723308510114369d, y: 0.3597477999593185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301103592527715d, y: 0.28938141303535514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748534692776464d, y: 0.862767752714604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.372783623881191d, y: 0.44243490973270194d), new NpgsqlTypes.NpgsqlPoint(x: 0.49275863911198703d, y: 0.1364906392837265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954730161139804d, y: 0.026768528071432374d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7929749385234783d, y: 0.1045107740610659d), new NpgsqlTypes.NpgsqlPoint(x: 0.10880086981415982d, y: 0.3679392360316587d), new NpgsqlTypes.NpgsqlPoint(x: 0.892984897550517d, y: 0.8811048102347148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3889570648908731d, y: 0.47598877501452586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896292845619817d, y: 0.7026111786307645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180654580649198d, y: 0.8155842156566321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.179253950886625d, y: 0.8354223037495008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276892595209253d, y: 0.5213164291493478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151688659187325d, y: 0.3405305563963743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27255905945357384d, y: 0.37304316460273335d), new NpgsqlTypes.NpgsqlPoint(x: 0.14093146799514955d, y: 0.998235170074373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3397788608069382d, y: 0.7441395705645688d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24928851743944425d, y: 0.33614744802007124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463198796399578d, y: 0.08542674470864287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2602399211761002d, y: 0.2858811192746785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9556406143837567d, y: 0.6484496456200138d), new NpgsqlTypes.NpgsqlPoint(x: 0.125502844374752d, y: 0.14203543734479318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08052884242853509d, y: 0.13611735794679247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6884551320330876d, y: 0.2597806360768776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011571608381661d, y: 0.18348750769667233d), new NpgsqlTypes.NpgsqlPoint(x: 0.14785811517665115d, y: 0.8774510585909364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4511663861023971d, y: 0.36414847390924787d), new NpgsqlTypes.NpgsqlPoint(x: 0.4765634829932679d, y: 0.6395629644333233d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371320226824703d, y: 0.05158185571905127d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.053163821715903836d, y: 0.2716251065506291d), new NpgsqlTypes.NpgsqlPoint(x: 0.4551751082179747d, y: 0.11571289576248178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777862146934432d, y: 0.8936641310036038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7884375629393021d, y: 0.519067209058912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014528002235655d, y: 0.09010002518219218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761142161073542d, y: 0.340576793501559d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27877050448732543d, y: 0.9231986683443792d), new NpgsqlTypes.NpgsqlPoint(x: 0.20850164386825487d, y: 0.6899538399467908d), new NpgsqlTypes.NpgsqlPoint(x: 0.02223839674074013d, y: 0.6809291852853478d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01360323518611628d, y: 0.014406843392148594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373468743911733d, y: 0.34877835386926614d), new NpgsqlTypes.NpgsqlPoint(x: 0.11669530848781995d, y: 0.7662472733849321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699026519353604d, y: 0.01143643019681917d), new NpgsqlTypes.NpgsqlPoint(x: 0.1663487475048514d, y: 0.29551708215067685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349230417510827d, y: 0.0348546889617789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7905861357493167d, y: 0.7648896686592347d), new NpgsqlTypes.NpgsqlPoint(x: 0.12041552224353758d, y: 0.0705920098722509d), new NpgsqlTypes.NpgsqlPoint(x: 0.12221561011853954d, y: 0.6684010964549527d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20475556866946898d, y: 0.6272459735757888d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570492008991908d, y: 0.35019503839569854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3441926235324454d, y: 0.9465005708842854d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2719435998683897d, y: 0.3037279498860317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281283733313835d, y: 0.7712803906397333d), new NpgsqlTypes.NpgsqlPoint(x: 0.42511457836506816d, y: 0.7309797340564752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02872111451001913d, y: 0.3107864080518502d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498644509714852d, y: 0.031459625668933344d), new NpgsqlTypes.NpgsqlPoint(x: 0.645783916399325d, y: 0.6071959148030818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08600721852110538d, y: 0.14307125491692696d), new NpgsqlTypes.NpgsqlPoint(x: 0.07993485928621824d, y: 0.29310816058714784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729499562046396d, y: 0.278950768401356d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30578268784909013d, y: 0.09401277207481906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497924208809849d, y: 0.1221178555033946d), new NpgsqlTypes.NpgsqlPoint(x: 0.22407093274148004d, y: 0.2856254876690629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6362217769462161d, y: 0.25924079226993535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273744331493474d, y: 0.9500440133160046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487802891691801d, y: 0.960459854942653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7631184576482453d, y: 0.2514896383767895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5328483934065434d, y: 0.74312487684414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552270331999835d, y: 0.6283280723779975d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6748692270559435d, y: 0.7059555376643943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047771731914135d, y: 0.3631394420729247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746337654715001d, y: 0.7161501311906145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4866236409011353d, y: 0.45285636993823086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282225326768742d, y: 0.6115076836075457d), new NpgsqlTypes.NpgsqlPoint(x: 0.12116012131252851d, y: 0.7097608372071638d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21610929480030727d, y: 0.8414054860563813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049992998624812d, y: 0.3150734994674189d), new NpgsqlTypes.NpgsqlPoint(x: 0.36433654806366667d, y: 0.9421040790349701d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.266706580157444d, y: 0.9245504795926901d), new NpgsqlTypes.NpgsqlPoint(x: 0.06344738786271154d, y: 0.27203869374865364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898586958066628d, y: 0.7848768167273368d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43340986327343833d, y: 0.2355498098912443d), new NpgsqlTypes.NpgsqlPoint(x: 0.28420573874413113d, y: 0.12869848490282354d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610644361813111d, y: 0.5367437236209603d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.517097152629843d, y: 0.8979083129702011d), new NpgsqlTypes.NpgsqlPoint(x: 0.22135494537375955d, y: 0.7493868798949177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723986487790226d, y: 0.3377479361287158d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22253992492267993d, y: 0.44302450564919305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726556208416124d, y: 0.9217014274427352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972203478464605d, y: 0.961993473565816d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3927382749000281d, y: 0.5859722798797452d), new NpgsqlTypes.NpgsqlPoint(x: 0.00855931637315388d, y: 0.48075189306899024d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690458218273407d, y: 0.3349383786932504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8908130860012836d, y: 0.1563965699972074d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761046164420154d, y: 0.0750150103242394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9042445830200325d, y: 0.9275903377541604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8731700576136673d, y: 0.24218868936288895d), new NpgsqlTypes.NpgsqlPoint(x: 0.734101396720579d, y: 0.8308848821744922d), new NpgsqlTypes.NpgsqlPoint(x: 0.07242311592979922d, y: 0.4274204624125555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9317184716199098d, y: 0.7045505705689337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4931982849453763d, y: 0.7976466585392592d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764153486502934d, y: 0.3517281106105682d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6885388719189979d, y: 0.26264737146767025d), new NpgsqlTypes.NpgsqlPoint(x: 0.22754862001469334d, y: 0.18446850999975095d), new NpgsqlTypes.NpgsqlPoint(x: 0.01228882866236991d, y: 0.6691384737504279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5987797400423032d, y: 0.4079166975212506d), new NpgsqlTypes.NpgsqlPoint(x: 0.16498379226351478d, y: 0.9341473769097903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863216992948952d, y: 0.2829361846916544d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13312243307463356d, y: 0.365341281728193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341329848555548d, y: 0.8182832629863419d), new NpgsqlTypes.NpgsqlPoint(x: 0.18347773769265985d, y: 0.3916297473880296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40779574868417534d, y: 0.3169538118828288d), new NpgsqlTypes.NpgsqlPoint(x: 0.07232605735334685d, y: 0.038150992860834454d), new NpgsqlTypes.NpgsqlPoint(x: 0.02975686351833262d, y: 0.3025450899226072d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.757223252597438d, y: 0.6223343754533367d), new NpgsqlTypes.NpgsqlPoint(x: 0.19215453638178293d, y: 0.3972413473171149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3003880662732621d, y: 0.5543092883125037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9965501544121013d, y: 0.5503170885323903d), new NpgsqlTypes.NpgsqlPoint(x: 0.19673269382767078d, y: 0.14216432242834176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678718722000522d, y: 0.3144949920302771d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7831606492844693d, y: 0.6753301809563935d), new NpgsqlTypes.NpgsqlPoint(x: 0.34962704642719955d, y: 0.06877924122273316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313690796609038d, y: 0.2493332362833134d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77577889390639d, y: 0.9495600099041508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057337102102687d, y: 0.5364964530303814d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764049228315353d, y: 0.1450170257124065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5211057360969037d, y: 0.06518483486470583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6151991448444875d, y: 0.0979324986727017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267744460600586d, y: 0.42864680079415274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7473053187736557d, y: 0.1719808006139555d), new NpgsqlTypes.NpgsqlPoint(x: 0.48224023285529904d, y: 0.9502763714704612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5274228393337653d, y: 0.6474070924142632d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8747877855526278d, y: 0.3195849955317267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225046768907086d, y: 0.6290655378353522d), new NpgsqlTypes.NpgsqlPoint(x: 0.46886187446442684d, y: 0.12519669478762263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46180042109176145d, y: 0.9246332611310785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147516082112814d, y: 0.3639754146980878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281068786780188d, y: 0.7124472789497704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678796906065235d, y: 0.013331170717643337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759806891738364d, y: 0.8980338763420033d), new NpgsqlTypes.NpgsqlPoint(x: 0.07740105483764781d, y: 0.06115274178169394d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7597986084803375d, y: 0.7706003026323096d), new NpgsqlTypes.NpgsqlPoint(x: 0.04275062730416157d, y: 0.4665420401061158d), new NpgsqlTypes.NpgsqlPoint(x: 0.08605060915425922d, y: 0.8818012214672437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515149219141922d, y: 0.3620434936953246d), new NpgsqlTypes.NpgsqlPoint(x: 0.01718498427919013d, y: 0.5288547717218853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1547490250568303d, y: 0.39950433214723113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9342143629537754d, y: 0.7658320547050745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434751488905102d, y: 0.6953574743620203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468651832944453d, y: 0.2284775294669884d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6730135770317407d, y: 0.5341421675240408d), new NpgsqlTypes.NpgsqlPoint(x: 0.43287755964087127d, y: 0.22696325832945652d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057127785818006d, y: 0.8210631463283142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6497430789579459d, y: 0.28400353851561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5642735797595668d, y: 0.01857273286484451d), new NpgsqlTypes.NpgsqlPoint(x: 0.23485085673639694d, y: 0.11819336762368471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5748959539468741d, y: 0.7193399068049376d), new NpgsqlTypes.NpgsqlPoint(x: 0.0551021124453962d, y: 0.3701074115944627d), new NpgsqlTypes.NpgsqlPoint(x: 0.48533250785922044d, y: 0.37148642192349735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36981970097894334d, y: 0.5815872724680334d), new NpgsqlTypes.NpgsqlPoint(x: 0.23667207099566578d, y: 0.0763198961954733d), new NpgsqlTypes.NpgsqlPoint(x: 0.33956991725512653d, y: 0.39221732598349013d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48110289917263693d, y: 0.6263822384498461d), new NpgsqlTypes.NpgsqlPoint(x: 0.46963239849620664d, y: 0.009867384403726809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4562529258460214d, y: 0.103955067024049d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9358992096983939d, y: 0.5875042179496033d), new NpgsqlTypes.NpgsqlPoint(x: 0.11754866451480306d, y: 0.860985684088257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547638893485837d, y: 0.4467537279658014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281236644301664d, y: 0.9988686288919577d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412345690390152d, y: 0.612953889339565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082116731883059d, y: 0.6922013083797206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.329890970955212d, y: 0.4538042910950546d), new NpgsqlTypes.NpgsqlPoint(x: 0.019294508958681122d, y: 0.4820846839045051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319567490546275d, y: 0.2399636912770018d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8308797681218529d, y: 0.9816214532062139d), new NpgsqlTypes.NpgsqlPoint(x: 0.13769156011208405d, y: 0.12702539616277486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057226564195402d, y: 0.4759527134361554d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13271857107284635d, y: 0.20625626140234332d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045306161894301d, y: 0.8598621334022595d), new NpgsqlTypes.NpgsqlPoint(x: 0.42710122207369805d, y: 0.27840092654020243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031945893844584905d, y: 0.5909287345746863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722466407577709d, y: 0.7350815014947731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272934264490108d, y: 0.5377958701255576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12033884677167073d, y: 0.6261795751448399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001461985315205d, y: 0.18812420083278547d), new NpgsqlTypes.NpgsqlPoint(x: 0.32524596060878075d, y: 0.5738736592112683d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9013708976710317d, y: 0.3706630808452527d), new NpgsqlTypes.NpgsqlPoint(x: 0.24316202697143618d, y: 0.09278705226590889d), new NpgsqlTypes.NpgsqlPoint(x: 0.09045207196035665d, y: 0.1372607655710325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226140427147167d, y: 0.6222947317311223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852562906452488d, y: 0.6968856483796246d), new NpgsqlTypes.NpgsqlPoint(x: 0.09096298924969659d, y: 0.48676531728500383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6199838688971228d, y: 0.5102512952687644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9725027325451914d, y: 0.7715536375021472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657654677806769d, y: 0.7836169544379866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020081675862140824d, y: 0.7050783703192509d), new NpgsqlTypes.NpgsqlPoint(x: 0.12937482029063352d, y: 0.8756162375714149d), new NpgsqlTypes.NpgsqlPoint(x: 0.48758367616914955d, y: 0.2923705714535989d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8828095175693288d, y: 0.7218543798445476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7371808948474406d, y: 0.14269509374760048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558252194486982d, y: 0.3238800930589829d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665981628296655d, y: 0.1911492457456927d), new NpgsqlTypes.NpgsqlPoint(x: 0.2439891163097746d, y: 0.2525303800102937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191911597265133d, y: 0.8584891519457912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4435040594263804d, y: 0.908869411337768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935475080400707d, y: 0.4009209860449361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041618664394273d, y: 0.1338537554416055d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7204883367358812d, y: 0.6873511004027614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861513407869882d, y: 0.16007386898078046d), new NpgsqlTypes.NpgsqlPoint(x: 0.1075342350077837d, y: 0.4237364269357916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7466810032787242d, y: 0.3198935970376895d), new NpgsqlTypes.NpgsqlPoint(x: 0.20078975653240738d, y: 0.876434240988305d), new NpgsqlTypes.NpgsqlPoint(x: 0.42879600797781536d, y: 0.8995876483125631d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5139278441795089d, y: 0.9117916140043817d), new NpgsqlTypes.NpgsqlPoint(x: 0.05763534625670008d, y: 0.6329741344493981d), new NpgsqlTypes.NpgsqlPoint(x: 0.013350124192479162d, y: 0.45198042188882726d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6044280523108818d, y: 0.4512085462925798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423917847441823d, y: 0.10800988030086278d), new NpgsqlTypes.NpgsqlPoint(x: 0.527552943301783d, y: 0.5871240064048121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546475867938026d, y: 0.9624021773942725d), new NpgsqlTypes.NpgsqlPoint(x: 0.274093828039788d, y: 0.9378027131663352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270571703875206d, y: 0.24873275668920325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41008687907885333d, y: 0.258894886311979d), new NpgsqlTypes.NpgsqlPoint(x: 0.28128164968926406d, y: 0.43907439073023236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166956241079653d, y: 0.3252830333684884d)),

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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 75, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatchAsync(connection, 43, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatch(connection, 67, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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

