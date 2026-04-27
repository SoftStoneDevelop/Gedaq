

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6022543383947693d,right: 0.9661413220279573d,bottom: 0.08382249106348183d,left: 0.8817993083950577d),

new NpgsqlTypes.NpgsqlBox(top: 0.3825918702127016d,right: 0.3393398078677846d,bottom: 0.336976817727637d,left: 0.07123726542264508d),

new NpgsqlTypes.NpgsqlBox(top: 0.5711327621654488d,right: 0.7047965382305683d,bottom: 0.13661685336814677d,left: 0.31281083845153923d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9623630767483828d,right: 0.7839828355664175d,bottom: 0.1893143911578481d,left: 0.3943507310978386d),

new NpgsqlTypes.NpgsqlBox(top: 0.8785152055438747d,right: 0.6095419879130728d,bottom: 0.24384170090703916d,left: 0.5788503670551055d),

new NpgsqlTypes.NpgsqlBox(top: 0.9866841355207437d,right: 0.14231596470028285d,bottom: 0.012695213834519437d,left: 0.008408138990742664d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.10872658973010729d,right: 0.41454401621388537d,bottom: 0.1021456718355771d,left: 0.1438505737792629d),

new NpgsqlTypes.NpgsqlBox(top: 0.9691396654198845d,right: 0.38065579127764526d,bottom: 0.8870295989984219d,left: 0.06323460056294161d),

new NpgsqlTypes.NpgsqlBox(top: 0.7988945099654926d,right: 0.9427123684368645d,bottom: 0.06261833886745571d,left: 0.18400987207360586d),

new NpgsqlTypes.NpgsqlBox(top: 0.21348757307326294d,right: 0.7897219590357533d,bottom: 0.06934197426103605d,left: 0.41779454905394253d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.981119428839369d,right: 0.7655542493670555d,bottom: 0.12092467419799702d,left: 0.17611924767111709d),

new NpgsqlTypes.NpgsqlBox(top: 0.9027101022882194d,right: 0.9108708526276992d,bottom: 0.34571586850802816d,left: 0.4488456453794747d),

new NpgsqlTypes.NpgsqlBox(top: 0.8993448829262007d,right: 0.8572032183147621d,bottom: 0.4029048448812802d,left: 0.838512537236275d),

new NpgsqlTypes.NpgsqlBox(top: 0.7359666039932408d,right: 0.5462387566859005d,bottom: 0.16131685533019735d,left: 0.5340420640212038d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.14612479353996022d,right: 0.9030238408699616d,bottom: 0.10504404398010792d,left: 0.13068599037014383d),

new NpgsqlTypes.NpgsqlBox(top: 0.8990640011033959d,right: 0.20696571862079705d,bottom: 0.7702090717974901d,left: 0.021723119368136423d),

new NpgsqlTypes.NpgsqlBox(top: 0.9520046334639415d,right: 0.7106495081545097d,bottom: 0.10436733171844037d,left: 0.23066751843200517d),

new NpgsqlTypes.NpgsqlBox(top: 0.8112025485527686d,right: 0.8363977050949891d,bottom: 0.05440412330418931d,left: 0.7090567654140929d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9713666659137392d,right: 0.3303264524959115d,bottom: 0.38131722943132074d,left: 0.1263583058651918d),

new NpgsqlTypes.NpgsqlBox(top: 0.2589774176640932d,right: 0.951219128172104d,bottom: 0.11846525125294882d,left: 0.22003890095050316d),

new NpgsqlTypes.NpgsqlBox(top: 0.11981354494577978d,right: 0.8648662985231392d,bottom: 0.10951568889202745d,left: 0.32008830157251555d),

new NpgsqlTypes.NpgsqlBox(top: 0.44527122777467876d,right: 0.7795396611370855d,bottom: 0.4196577809098895d,left: 0.682882977514593d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7190860137407575d,right: 0.6828105511273456d,bottom: 0.4817655855401558d,left: 0.08082537337823281d),

new NpgsqlTypes.NpgsqlBox(top: 0.503752672848571d,right: 0.6913206890828851d,bottom: 0.3543539378550642d,left: 0.33235128137607794d),

new NpgsqlTypes.NpgsqlBox(top: 0.5243537354548835d,right: 0.9007783841313446d,bottom: 0.025894980450398286d,left: 0.5609597915800328d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.40922402323214835d,right: 0.9600446743523326d,bottom: 0.13829701603436229d,left: 0.7734774514158376d),

new NpgsqlTypes.NpgsqlBox(top: 0.9568596018651137d,right: 0.9057524537111756d,bottom: 0.15127294407542413d,left: 0.8432765852102613d),

new NpgsqlTypes.NpgsqlBox(top: 0.8602916026395669d,right: 0.46253822859217475d,bottom: 0.6106958191544114d,left: 0.14594283092819293d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.673846624712164d,right: 0.9442809311976245d,bottom: 0.1996543835949881d,left: 0.939445305466546d),

new NpgsqlTypes.NpgsqlBox(top: 0.8952804240769491d,right: 0.871312735263908d,bottom: 0.4765006516547675d,left: 0.826661333860643d),

new NpgsqlTypes.NpgsqlBox(top: 0.5104561794029365d,right: 0.553024362314256d,bottom: 0.24133147557498402d,left: 0.4686401580943965d),

new NpgsqlTypes.NpgsqlBox(top: 0.4190971666580169d,right: 0.4693377654495213d,bottom: 0.20678186531537956d,left: 0.27625763913219237d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3514339475831285d,right: 0.7515416042387609d,bottom: 0.284669583474102d,left: 0.2945087006470277d),

new NpgsqlTypes.NpgsqlBox(top: 0.5162150619654059d,right: 0.5806168622153196d,bottom: 0.042369124065466224d,left: 0.3763610382115723d),

new NpgsqlTypes.NpgsqlBox(top: 0.7429332541412802d,right: 0.8160201480804161d,bottom: 0.6836676214237052d,left: 0.5815205582149894d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9147821836863109d,right: 0.2915236739874839d,bottom: 0.1184832626499801d,left: 0.22003486406142736d),

new NpgsqlTypes.NpgsqlBox(top: 0.9412414970618472d,right: 0.5101030054286396d,bottom: 0.552191699731656d,left: 0.31686144670020344d),

new NpgsqlTypes.NpgsqlBox(top: 0.33454843167007764d,right: 0.947251032186803d,bottom: 0.17827683966772745d,left: 0.07556704466286224d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.17472703709709003d,right: 0.32701062625011856d,bottom: 0.14302317728029523d,left: 0.3119127769055434d),

new NpgsqlTypes.NpgsqlBox(top: 0.9792174490149786d,right: 0.9516295001080926d,bottom: 0.013096037897020518d,left: 0.5151539022317041d),

new NpgsqlTypes.NpgsqlBox(top: 0.45354713849790396d,right: 0.3265836318877734d,bottom: 0.02938116308104266d,left: 0.03214837295962025d),

new NpgsqlTypes.NpgsqlBox(top: 0.6527573182232199d,right: 0.8792685452710732d,bottom: 0.19133753451957203d,left: 0.8670420229042853d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.12843259526066697d,right: 0.7324516718087162d,bottom: 0.02773275350120641d,left: 0.2847473171885513d),

new NpgsqlTypes.NpgsqlBox(top: 0.8389166324657218d,right: 0.5816600025191687d,bottom: 0.1255336471024664d,left: 0.46923408506937403d),

new NpgsqlTypes.NpgsqlBox(top: 0.463123538829462d,right: 0.622617657544389d,bottom: 0.3889028940895778d,left: 0.501897706496614d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9135318301659365d,right: 0.8470983385683258d,bottom: 0.6007330305273579d,left: 0.820217272338385d),

new NpgsqlTypes.NpgsqlBox(top: 0.6335575720556599d,right: 0.34360417670918497d,bottom: 0.13612954322121107d,left: 0.23309190101559818d),

new NpgsqlTypes.NpgsqlBox(top: 0.3286177413971919d,right: 0.3683954070371842d,bottom: 0.08674205637511445d,left: 0.11890764014142252d),

new NpgsqlTypes.NpgsqlBox(top: 0.949297676023639d,right: 0.8485967394105276d,bottom: 0.47661997280205426d,left: 0.5552234921531547d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6162033387498049d,right: 0.5271104257558522d,bottom: 0.004239860483871372d,left: 0.4327387378225602d),

new NpgsqlTypes.NpgsqlBox(top: 0.7341342621249639d,right: 0.41076444681523994d,bottom: 0.28016254197911705d,left: 0.056651437396188276d),

new NpgsqlTypes.NpgsqlBox(top: 0.8886077733793131d,right: 0.8836407342110731d,bottom: 0.09412829621295504d,left: 0.35483579452841063d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13414704081078d,right: 0.7383532080369126d,bottom: 0.09668124756610363d,left: 0.6275668453524587d),

new NpgsqlTypes.NpgsqlBox(top: 0.6940009283676193d,right: 0.7795938872886914d,bottom: 0.2974249035548914d,left: 0.2695829225153985d),

new NpgsqlTypes.NpgsqlBox(top: 0.5095619052271461d,right: 0.7518007139472956d,bottom: 0.31907009493064764d,left: 0.03876600455758439d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8303414920859816d,right: 0.8215309049607026d,bottom: 0.1624161307845743d,left: 0.7442218030748363d),

new NpgsqlTypes.NpgsqlBox(top: 0.8640231020206697d,right: 0.8047647862916674d,bottom: 0.1181049087561249d,left: 0.6411957854816338d),

new NpgsqlTypes.NpgsqlBox(top: 0.9368349248087792d,right: 0.8668893906509189d,bottom: 0.45973185203381184d,left: 0.5030378593345904d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32497104551910194d,right: 0.7302539819803868d,bottom: 0.07907455878184433d,left: 0.489777213020969d),

new NpgsqlTypes.NpgsqlBox(top: 0.3193682834592243d,right: 0.6790818876967102d,bottom: 0.02657220832958762d,left: 0.17862879884637983d),

new NpgsqlTypes.NpgsqlBox(top: 0.7726425801583049d,right: 0.679550690759661d,bottom: 0.19818428624639517d,left: 0.590186973383095d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.678670782393218d,right: 0.8602298889526926d,bottom: 0.052765930554037d,left: 0.5749911522998431d),

new NpgsqlTypes.NpgsqlBox(top: 0.8027286297644577d,right: 0.334653682401579d,bottom: 0.7548766069140416d,left: 0.09594606244937676d),

new NpgsqlTypes.NpgsqlBox(top: 0.83936772825597d,right: 0.8233339509951836d,bottom: 0.6363480516375525d,left: 0.37022733869617275d),

new NpgsqlTypes.NpgsqlBox(top: 0.48674680737214904d,right: 0.9327784929645818d,bottom: 0.26205891417097216d,left: 0.5570572405973073d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3287671771881733d,right: 0.7965830013824949d,bottom: 0.06424838692587709d,left: 0.42668101774779377d),

new NpgsqlTypes.NpgsqlBox(top: 0.39674558818568906d,right: 0.22102562190907682d,bottom: 0.32114628949768154d,left: 0.04582337957329208d),

new NpgsqlTypes.NpgsqlBox(top: 0.475030038605727d,right: 0.39011648991170467d,bottom: 0.23171225132598972d,left: 0.22438877676057045d),

new NpgsqlTypes.NpgsqlBox(top: 0.8689068186937989d,right: 0.6950030802282624d,bottom: 0.571892147418257d,left: 0.16283455258628254d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.27018327133606035d,right: 0.4247432260312676d,bottom: 0.15781036455022512d,left: 0.04808504728737717d),

new NpgsqlTypes.NpgsqlBox(top: 0.7882391213736192d,right: 0.7784088834431586d,bottom: 0.34204211793428085d,left: 0.061718293933641144d),

new NpgsqlTypes.NpgsqlBox(top: 0.8321887247533587d,right: 0.4905506965922807d,bottom: 0.7876128734356549d,left: 0.04851997780996509d),

new NpgsqlTypes.NpgsqlBox(top: 0.6039226603137566d,right: 0.8353825547616524d,bottom: 0.3612318212392357d,left: 0.7184883702606066d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43811977588695994d,right: 0.6139548629131967d,bottom: 0.43451773005952665d,left: 0.38791174841593734d),

new NpgsqlTypes.NpgsqlBox(top: 0.8710845250281927d,right: 0.7999012493726128d,bottom: 0.23951101195875713d,left: 0.2272806555917909d),

new NpgsqlTypes.NpgsqlBox(top: 0.04019257055985692d,right: 0.31882861411760444d,bottom: 0.008892951602673449d,left: 0.049704955910214954d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41014134274816993d,right: 0.569731914721343d,bottom: 0.08834119998328338d,left: 0.021075920864774944d),

new NpgsqlTypes.NpgsqlBox(top: 0.47735140404085674d,right: 0.9772482769852344d,bottom: 0.2184719254747285d,left: 0.34793182223273733d),

new NpgsqlTypes.NpgsqlBox(top: 0.3697025669244267d,right: 0.9635078267098939d,bottom: 0.16441801526889188d,left: 0.893993431256318d),

new NpgsqlTypes.NpgsqlBox(top: 0.5076721898476527d,right: 0.8747047606372599d,bottom: 0.20885960259395808d,left: 0.4812990343149267d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.574016798946082d,right: 0.71701624290476d,bottom: 0.06634324995297713d,left: 0.19353194716916078d),

new NpgsqlTypes.NpgsqlBox(top: 0.6066269415231788d,right: 0.5910917601155772d,bottom: 0.17167660104085147d,left: 0.41047412158316643d),

new NpgsqlTypes.NpgsqlBox(top: 0.5016846661715809d,right: 0.5294681468042248d,bottom: 0.2844495999944461d,left: 0.3414474731860928d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6852450968009548d,right: 0.6031040142987091d,bottom: 0.08242583421681693d,left: 0.35795107048941077d),

new NpgsqlTypes.NpgsqlBox(top: 0.9226178338377001d,right: 0.680337391990244d,bottom: 0.41641428822766113d,left: 0.4809676506976609d),

new NpgsqlTypes.NpgsqlBox(top: 0.7474805473539416d,right: 0.12226817741069629d,bottom: 0.31945083455968437d,left: 0.08388185519413305d),

new NpgsqlTypes.NpgsqlBox(top: 0.5347169963316829d,right: 0.4562952172201683d,bottom: 0.2260432272613302d,left: 0.4009492730457713d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7360546873610586d,right: 0.5932343985936563d,bottom: 0.5053314289869804d,left: 0.4159059168399636d),

new NpgsqlTypes.NpgsqlBox(top: 0.9620606311905269d,right: 0.1600050633230875d,bottom: 0.2514261786757457d,left: 0.11814957136539594d),

new NpgsqlTypes.NpgsqlBox(top: 0.7975713519213352d,right: 0.7963388686463413d,bottom: 0.29529260627047915d,left: 0.053747273200239976d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.846790233900133d,right: 0.7412383680690154d,bottom: 0.7419833003021742d,left: 0.6458024768768756d),

new NpgsqlTypes.NpgsqlBox(top: 0.8816182927668959d,right: 0.4820124775859488d,bottom: 0.7587441195255133d,left: 0.26892017182988515d),

new NpgsqlTypes.NpgsqlBox(top: 0.4289717172879586d,right: 0.940007581067722d,bottom: 0.1199242074961131d,left: 0.7688663255586495d),

new NpgsqlTypes.NpgsqlBox(top: 0.24608029821237465d,right: 0.7366267454397802d,bottom: 0.14038540679650724d,left: 0.5041520299395384d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8854480808512769d,right: 0.8851390990694711d,bottom: 0.8121075559224031d,left: 0.6639199287635068d),

new NpgsqlTypes.NpgsqlBox(top: 0.559882930560933d,right: 0.5096783125364693d,bottom: 0.29056322304599336d,left: 0.4428190927414757d),

new NpgsqlTypes.NpgsqlBox(top: 0.6081353466308653d,right: 0.9484331569521582d,bottom: 0.2236141418310551d,left: 0.15580031309652864d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9781183997784804d,right: 0.9475484420887245d,bottom: 0.7390258734924068d,left: 0.1349078112232055d),

new NpgsqlTypes.NpgsqlBox(top: 0.9539517836058617d,right: 0.6670953732677685d,bottom: 0.8465233891234476d,left: 0.568950203305109d),

new NpgsqlTypes.NpgsqlBox(top: 0.5524164610270332d,right: 0.9699572317339763d,bottom: 0.12762678439276864d,left: 0.7914844952084304d),

new NpgsqlTypes.NpgsqlBox(top: 0.782336784997417d,right: 0.5058977051038187d,bottom: 0.6202537741989473d,left: 0.10985000709781023d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6972671942179843d,right: 0.9282481670461289d,bottom: 0.5181044284174966d,left: 0.40753112675326786d),

new NpgsqlTypes.NpgsqlBox(top: 0.3053028774059977d,right: 0.3648288180197553d,bottom: 0.2327472565440697d,left: 0.15146678699131555d),

new NpgsqlTypes.NpgsqlBox(top: 0.1494594312637595d,right: 0.6016491304070042d,bottom: 0.05130756784087853d,left: 0.40409771445722475d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6896960260302661d,right: 0.043474610993143314d,bottom: 0.1899240784451275d,left: 0.004045578183156429d),

new NpgsqlTypes.NpgsqlBox(top: 0.973945281540531d,right: 0.5364334233417003d,bottom: 0.4320038347652717d,left: 0.2349953812665757d),

new NpgsqlTypes.NpgsqlBox(top: 0.952738011702466d,right: 0.48988269460506595d,bottom: 0.01093111082413678d,left: 0.08609389966126224d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9235343091712757d,right: 0.7538718422031929d,bottom: 0.031440183334041194d,left: 0.38542455214157756d),

new NpgsqlTypes.NpgsqlBox(top: 0.5181050409302623d,right: 0.4533074988997947d,bottom: 0.13308311141066176d,left: 0.1844168238124826d),

new NpgsqlTypes.NpgsqlBox(top: 0.5341307055047109d,right: 0.4505979001333681d,bottom: 0.477308966959507d,left: 0.20328737295278165d),

new NpgsqlTypes.NpgsqlBox(top: 0.5302763663630516d,right: 0.7854458178828254d,bottom: 0.13216164802889285d,left: 0.10647453345697555d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6127294436897557d,right: 0.89607929627d,bottom: 0.3821084432738826d,left: 0.4500457362513748d),

new NpgsqlTypes.NpgsqlBox(top: 0.55678787388108d,right: 0.6614605362373693d,bottom: 0.2677468710355948d,left: 0.26994557606171565d),

new NpgsqlTypes.NpgsqlBox(top: 0.6696572381439767d,right: 0.6456184756280375d,bottom: 0.5496566403954575d,left: 0.1078197181485464d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3310082646146765d,right: 0.6767507380743304d,bottom: 0.03153441167633764d,left: 0.14553737491254792d),

new NpgsqlTypes.NpgsqlBox(top: 0.7575901199765809d,right: 0.9682039397751786d,bottom: 0.36146333606202175d,left: 0.2707760919748875d),

new NpgsqlTypes.NpgsqlBox(top: 0.6239659850457475d,right: 0.7540033293638763d,bottom: 0.25997245503845035d,left: 0.012708043239038513d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8087074397937228d,right: 0.14595023561137777d,bottom: 0.6180443559816428d,left: 0.013654174730097557d),

new NpgsqlTypes.NpgsqlBox(top: 0.3256894718974793d,right: 0.42935205410690347d,bottom: 0.121709668561923d,left: 0.19930723733444466d),

new NpgsqlTypes.NpgsqlBox(top: 0.8607692779186006d,right: 0.13956298709653003d,bottom: 0.7573858002167361d,left: 0.05328752356242705d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3922636895021022d,right: 0.8150551126639597d,bottom: 0.09682417396933429d,left: 0.44543855280755185d),

new NpgsqlTypes.NpgsqlBox(top: 0.63742831054866d,right: 0.45547416452697087d,bottom: 0.4028485862911272d,left: 0.25190245021425883d),

new NpgsqlTypes.NpgsqlBox(top: 0.8351191572135188d,right: 0.6707689296713981d,bottom: 0.3672779499591685d,left: 0.4730162503074846d),

new NpgsqlTypes.NpgsqlBox(top: 0.2981737360998329d,right: 0.9150939243861808d,bottom: 0.050583993823067996d,left: 0.3878355811408596d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9914227171245158d,right: 0.3225976480770164d,bottom: 0.6884718498500711d,left: 0.02845735711014674d),

new NpgsqlTypes.NpgsqlBox(top: 0.926540622758465d,right: 0.8384998829670158d,bottom: 0.21379782359282673d,left: 0.04493816499292347d),

new NpgsqlTypes.NpgsqlBox(top: 0.959748613120093d,right: 0.7297199308214661d,bottom: 0.5690396467538147d,left: 0.15994343780678788d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6129935987863558d,right: 0.3885649655120881d,bottom: 0.22913684440731386d,left: 0.2993133434166326d),

new NpgsqlTypes.NpgsqlBox(top: 0.49518685518196404d,right: 0.743881890193524d,bottom: 0.43775588127244447d,left: 0.3774638610844153d),

new NpgsqlTypes.NpgsqlBox(top: 0.6585858097712092d,right: 0.698894638334478d,bottom: 0.21690198623970902d,left: 0.1726993831722775d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.873135894910004d,right: 0.8069320802876206d,bottom: 0.04999477765071503d,left: 0.0006684059071148107d),

new NpgsqlTypes.NpgsqlBox(top: 0.5897117219348128d,right: 0.8487023520924675d,bottom: 0.5527199024332584d,left: 0.32432184367034456d),

new NpgsqlTypes.NpgsqlBox(top: 0.6562452580709031d,right: 0.5517531958648958d,bottom: 0.2082382611149245d,left: 0.09684786855806515d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7179812234520554d,right: 0.8642711693479588d,bottom: 0.5156494392677615d,left: 0.6404819599926006d),

new NpgsqlTypes.NpgsqlBox(top: 0.6792367980276234d,right: 0.4370598623022237d,bottom: 0.4884680709899336d,left: 0.03560636912041859d),

new NpgsqlTypes.NpgsqlBox(top: 0.9799532538007585d,right: 0.8747005435113001d,bottom: 0.6940995072449705d,left: 0.7629661392609616d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7273234162891729d,right: 0.6047505440627433d,bottom: 0.39793714511403355d,left: 0.27198177236730625d),

new NpgsqlTypes.NpgsqlBox(top: 0.9532469501110826d,right: 0.6282556723712512d,bottom: 0.05323195412047288d,left: 0.6055123622961982d),

new NpgsqlTypes.NpgsqlBox(top: 0.3997335892024704d,right: 0.5847993543133218d,bottom: 0.16206018552159718d,left: 0.5064040253148591d),

new NpgsqlTypes.NpgsqlBox(top: 0.4632475196912066d,right: 0.696143645625942d,bottom: 0.4272200259922214d,left: 0.1656197587415933d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5907462583954206d,right: 0.48951190402080336d,bottom: 0.1071549691850282d,left: 0.24000141407008013d),

new NpgsqlTypes.NpgsqlBox(top: 0.34265960923087113d,right: 0.42069489304310914d,bottom: 0.1166486889770384d,left: 0.12762994169520103d),

new NpgsqlTypes.NpgsqlBox(top: 0.7276526049471819d,right: 0.6019187321988801d,bottom: 0.07238564971958628d,left: 0.22968699346326105d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8783207749146444d,right: 0.866358640344396d,bottom: 0.3624001889555789d,left: 0.05802150504126469d),

new NpgsqlTypes.NpgsqlBox(top: 0.6984426936430206d,right: 0.5283529086488421d,bottom: 0.270979817660045d,left: 0.33595618264933813d),

new NpgsqlTypes.NpgsqlBox(top: 0.5946693700174492d,right: 0.4279675950775126d,bottom: 0.4251313997361098d,left: 0.2874623897254719d),

new NpgsqlTypes.NpgsqlBox(top: 0.37458245152286795d,right: 0.6043474581012679d,bottom: 0.2080844370395859d,left: 0.17714879609295164d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8727541841361187d,right: 0.5537236251786963d,bottom: 0.3253621078655189d,left: 0.39165977824024767d),

new NpgsqlTypes.NpgsqlBox(top: 0.8228650640779328d,right: 0.3116046729988199d,bottom: 0.5896604599892302d,left: 0.06603633123963448d),

new NpgsqlTypes.NpgsqlBox(top: 0.7420133451030021d,right: 0.8617969426621405d,bottom: 0.05884458070705334d,left: 0.34228991646032736d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37965071989364385d,right: 0.6818106935819642d,bottom: 0.20110149547126588d,left: 0.48783760805680254d),

new NpgsqlTypes.NpgsqlBox(top: 0.8374569915279686d,right: 0.35813959896533454d,bottom: 0.73336281119003d,left: 0.18530145924059893d),

new NpgsqlTypes.NpgsqlBox(top: 0.6540406350509121d,right: 0.778926788834854d,bottom: 0.12050917487358226d,left: 0.0181427302542706d),

new NpgsqlTypes.NpgsqlBox(top: 0.738590264588152d,right: 0.6455792379750722d,bottom: 0.1119731088583722d,left: 0.07747815771459954d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6798303425443409d,right: 0.45494904565131755d,bottom: 0.17239303001904827d,left: 0.40894184558297464d),

new NpgsqlTypes.NpgsqlBox(top: 0.35965716211293d,right: 0.3409123880084136d,bottom: 0.17967349917267206d,left: 0.2169552966914703d),

new NpgsqlTypes.NpgsqlBox(top: 0.8441489758697902d,right: 0.3161175072859157d,bottom: 0.7648758945533318d,left: 0.301387665568723d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8446368841736186d,right: 0.7970463979077523d,bottom: 0.6171975072436245d,left: 0.6527471859641518d),

new NpgsqlTypes.NpgsqlBox(top: 0.4465791783498748d,right: 0.9460782782915372d,bottom: 0.24375335379125584d,left: 0.3208626299512014d),

new NpgsqlTypes.NpgsqlBox(top: 0.7610544045492803d,right: 0.8998829611277419d,bottom: 0.2062837133026072d,left: 0.15240036158369097d),

new NpgsqlTypes.NpgsqlBox(top: 0.3502531928831336d,right: 0.4884836376191587d,bottom: 0.31667457601650306d,left: 0.4068692575587981d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9582224490274537d,right: 0.8242027840325412d,bottom: 0.22284839934376433d,left: 0.23112063268149807d),

new NpgsqlTypes.NpgsqlBox(top: 0.992131409779787d,right: 0.9269274522469471d,bottom: 0.4810796421718526d,left: 0.8975933886412862d),

new NpgsqlTypes.NpgsqlBox(top: 0.6073709841161216d,right: 0.672230584987958d,bottom: 0.5024513852894334d,left: 0.17752211916087257d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8278892714871608d,right: 0.8483224423801502d,bottom: 0.41296919687793d,left: 0.4163866608109641d),

new NpgsqlTypes.NpgsqlBox(top: 0.91322849698494d,right: 0.6277179965781947d,bottom: 0.6300593202442947d,left: 0.1457455849241085d),

new NpgsqlTypes.NpgsqlBox(top: 0.7021571342353512d,right: 0.5463071375314746d,bottom: 0.04920627481954387d,left: 0.2540668808337522d),

new NpgsqlTypes.NpgsqlBox(top: 0.8353984894071924d,right: 0.8169791094248001d,bottom: 0.093069088093506d,left: 0.7681987480970307d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7156134921461256d,right: 0.682021183556759d,bottom: 0.5202516265016204d,left: 0.3008103433684307d),

new NpgsqlTypes.NpgsqlBox(top: 0.6189000361765534d,right: 0.8783260717015662d,bottom: 0.48767123102314636d,left: 0.4394739197724714d),

new NpgsqlTypes.NpgsqlBox(top: 0.7368405713804297d,right: 0.7225787026978417d,bottom: 0.1291912325729877d,left: 0.10780186356809818d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.648987642692541d,right: 0.5500475414580103d,bottom: 0.1623796538407941d,left: 0.22855726320644543d),

new NpgsqlTypes.NpgsqlBox(top: 0.8081005047696791d,right: 0.9515640526550694d,bottom: 0.3713165063453334d,left: 0.4890546046065437d),

new NpgsqlTypes.NpgsqlBox(top: 0.7482363892778943d,right: 0.7312601317039021d,bottom: 0.5706309616652327d,left: 0.32764582261499753d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43341385059357074d,right: 0.40305897124437196d,bottom: 0.22534892158310782d,left: 0.20718697382447726d),

new NpgsqlTypes.NpgsqlBox(top: 0.751265711278581d,right: 0.8738177287201513d,bottom: 0.16783278055754913d,left: 0.008477221740774254d),

new NpgsqlTypes.NpgsqlBox(top: 0.9717086447771058d,right: 0.34555492750219063d,bottom: 0.6223724197346993d,left: 0.1118197470093687d),

new NpgsqlTypes.NpgsqlBox(top: 0.9261313332036228d,right: 0.8491844341557966d,bottom: 0.09428446144922953d,left: 0.640635538108295d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29827505590062375d,right: 0.5532026491039113d,bottom: 0.1601152717394405d,left: 0.23098311041462705d),

new NpgsqlTypes.NpgsqlBox(top: 0.9680569787028541d,right: 0.7721367039977018d,bottom: 0.417820289301884d,left: 0.6444562575874566d),

new NpgsqlTypes.NpgsqlBox(top: 0.9070034447057537d,right: 0.8675629023931412d,bottom: 0.8828252846521358d,left: 0.1833768642216712d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9097833477729258d,right: 0.6654639078907091d,bottom: 0.1955201611896984d,left: 0.5225466106566308d),

new NpgsqlTypes.NpgsqlBox(top: 0.5454071776989411d,right: 0.6447024355630429d,bottom: 0.0886639847510442d,left: 0.6403916218972856d),

new NpgsqlTypes.NpgsqlBox(top: 0.971617848317111d,right: 0.21022430021711347d,bottom: 0.2718222858115753d,left: 0.10713303647217909d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5537760941809535d,right: 0.5431942089762218d,bottom: 0.4982659928758413d,left: 0.09008383521043051d),

new NpgsqlTypes.NpgsqlBox(top: 0.9137823859305341d,right: 0.7855789408796862d,bottom: 0.40514319385155595d,left: 0.3872704769929921d),

new NpgsqlTypes.NpgsqlBox(top: 0.6436531477051617d,right: 0.9439901603938307d,bottom: 0.3570706792277909d,left: 0.4599186323958847d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.665652222795571d,right: 0.9346947405233418d,bottom: 0.11388529205534614d,left: 0.3595411275164214d),

new NpgsqlTypes.NpgsqlBox(top: 0.3829754468048173d,right: 0.20090395630741253d,bottom: 0.05093328940766606d,left: 0.11466968816621037d),

new NpgsqlTypes.NpgsqlBox(top: 0.592207306465478d,right: 0.510915982174471d,bottom: 0.05441234464348499d,left: 0.1052696423959103d),

new NpgsqlTypes.NpgsqlBox(top: 0.3360316717138522d,right: 0.7545833139090259d,bottom: 0.038760067362996975d,left: 0.7285975537443902d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9196679613723394d,right: 0.8247177100233709d,bottom: 0.37066347854140946d,left: 0.6505476051811157d),

new NpgsqlTypes.NpgsqlBox(top: 0.9222605519948331d,right: 0.3809840514335312d,bottom: 0.055783428731608686d,left: 0.21665867709719278d),

new NpgsqlTypes.NpgsqlBox(top: 0.31510471445075716d,right: 0.9067436128317483d,bottom: 0.10554587544975946d,left: 0.18730279510297754d),

new NpgsqlTypes.NpgsqlBox(top: 0.854195130349228d,right: 0.6211614942759971d,bottom: 0.07151886842917521d,left: 0.2340820922813358d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8622537385024354d,right: 0.5139418570752333d,bottom: 0.8427265643373748d,left: 0.11477688228402316d),

new NpgsqlTypes.NpgsqlBox(top: 0.9747434898058329d,right: 0.3467259302627429d,bottom: 0.35616039434288393d,left: 0.07067933184821618d),

new NpgsqlTypes.NpgsqlBox(top: 0.23414320255826904d,right: 0.7153795866857982d,bottom: 0.05764063776684525d,left: 0.30207730411068423d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9618536495540218d,right: 0.9224852769834148d,bottom: 0.07187717880102218d,left: 0.2624993167275004d),

new NpgsqlTypes.NpgsqlBox(top: 0.3426407167872818d,right: 0.6648715055410446d,bottom: 0.2015492430560506d,left: 0.6567483547332224d),

new NpgsqlTypes.NpgsqlBox(top: 0.21248131101489165d,right: 0.5676214737792252d,bottom: 0.0430682893990465d,left: 0.19103882710913245d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.907083773616627d,right: 0.9382938310259895d,bottom: 0.658829568608765d,left: 0.305954024952772d),

new NpgsqlTypes.NpgsqlBox(top: 0.9030123463437979d,right: 0.9276457098826123d,bottom: 0.7109943831070101d,left: 0.8261660101961322d),

new NpgsqlTypes.NpgsqlBox(top: 0.9757212013194164d,right: 0.9599612511866387d,bottom: 0.272201451857099d,left: 0.6911574356525766d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.857765756412017d,right: 0.3489278528088632d,bottom: 0.28242000057365935d,left: 0.3120908943495263d),

new NpgsqlTypes.NpgsqlBox(top: 0.5517800527982265d,right: 0.35888535749867945d,bottom: 0.2791954590350575d,left: 0.0595465788543722d),

new NpgsqlTypes.NpgsqlBox(top: 0.5821831764516076d,right: 0.6658433512339185d,bottom: 0.33722121899196933d,left: 0.6628796226234586d),

new NpgsqlTypes.NpgsqlBox(top: 0.7328876621004934d,right: 0.5314434325532582d,bottom: 0.32484839983731184d,left: 0.28074018680705914d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7207348044807831d,right: 0.9030726822298988d,bottom: 0.09601101352691765d,left: 0.6853768023654185d),

new NpgsqlTypes.NpgsqlBox(top: 0.9557389637553674d,right: 0.7798106874381739d,bottom: 0.8329613438834415d,left: 0.12147829612090244d),

new NpgsqlTypes.NpgsqlBox(top: 0.7931503735837654d,right: 0.3259936140212556d,bottom: 0.3372077032612937d,left: 0.21902582055266562d),

new NpgsqlTypes.NpgsqlBox(top: 0.966082458923087d,right: 0.27800364399132094d,bottom: 0.36844593447204166d,left: 0.25640716296775834d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6584950807277696d,right: 0.8520117758171655d,bottom: 0.12074527673347712d,left: 0.5304630878571631d),

new NpgsqlTypes.NpgsqlBox(top: 0.25066629701439935d,right: 0.7542620555721492d,bottom: 0.053491414382409785d,left: 0.4077931065402485d),

new NpgsqlTypes.NpgsqlBox(top: 0.5323436916008056d,right: 0.40794021144679204d,bottom: 0.08507206964179448d,left: 0.3500351046738398d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8584209833948737d,right: 0.8344387044072878d,bottom: 0.7003250103390976d,left: 0.4669044221846248d),

new NpgsqlTypes.NpgsqlBox(top: 0.6602051550607477d,right: 0.6543651122546317d,bottom: 0.660062205792891d,left: 0.3296766094884005d),

new NpgsqlTypes.NpgsqlBox(top: 0.6430711464001106d,right: 0.5008607150389655d,bottom: 0.5132761044865612d,left: 0.016299374394997956d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5329911504262703d,right: 0.42444548345386834d,bottom: 0.2816969751819921d,left: 0.08815424083348722d),

new NpgsqlTypes.NpgsqlBox(top: 0.16434444869324616d,right: 0.8024063156354463d,bottom: 0.09109940872442335d,left: 0.6065114939280694d),

new NpgsqlTypes.NpgsqlBox(top: 0.9239720793627264d,right: 0.7019869319134868d,bottom: 0.17907786314974394d,left: 0.054631400193396185d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7409934855713394d,right: 0.4602265441801672d,bottom: 0.5129457441364182d,left: 0.415686620978473d),

new NpgsqlTypes.NpgsqlBox(top: 0.6089854885346925d,right: 0.7408629139341802d,bottom: 0.035429735840869836d,left: 0.48796540553321555d),

new NpgsqlTypes.NpgsqlBox(top: 0.8183559369032233d,right: 0.7907357564544212d,bottom: 0.7307429409685493d,left: 0.43930206573205666d),

new NpgsqlTypes.NpgsqlBox(top: 0.8867479644737014d,right: 0.747072002785115d,bottom: 0.11482771302909d,left: 0.7124708193132989d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7988421729618804d,right: 0.9883133649299287d,bottom: 0.002056722183365167d,left: 0.04062573231507749d),

new NpgsqlTypes.NpgsqlBox(top: 0.7952923238434666d,right: 0.3768782476685052d,bottom: 0.5717295376698043d,left: 0.19682404123698016d),

new NpgsqlTypes.NpgsqlBox(top: 0.9770097796149381d,right: 0.9661556180744776d,bottom: 0.824907647876446d,left: 0.666413814303544d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9029105868983442d,right: 0.18425377272460441d,bottom: 0.8100649812728474d,left: 0.01687067152034505d),

new NpgsqlTypes.NpgsqlBox(top: 0.3872137052173671d,right: 0.8987088492377764d,bottom: 0.29421964904551134d,left: 0.18603817653106858d),

new NpgsqlTypes.NpgsqlBox(top: 0.8068716675295924d,right: 0.8552529154406522d,bottom: 0.5311281605177642d,left: 0.5866423768331289d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.24101437642699808d,right: 0.8537179450461686d,bottom: 0.13658530787649792d,left: 0.25163275123739204d),

new NpgsqlTypes.NpgsqlBox(top: 0.12036404162296654d,right: 0.9445558766226289d,bottom: 0.061171493067268545d,left: 0.49366234648099594d),

new NpgsqlTypes.NpgsqlBox(top: 0.9088094603760527d,right: 0.6819284241032779d,bottom: 0.49900023576360264d,left: 0.4932052531270362d),

new NpgsqlTypes.NpgsqlBox(top: 0.8416441695566484d,right: 0.32794091926312074d,bottom: 0.4544919566537543d,left: 0.04505294056844966d),

},
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 94, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 123, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

