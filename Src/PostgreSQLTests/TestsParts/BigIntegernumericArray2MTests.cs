

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region TestData

        private readonly BigIntegernumericArray2M[] _testData = new BigIntegernumericArray2M[]
        {
            new BigIntegernumericArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8622253496699407995L),

new System.Numerics.BigInteger(5331506531744309103L),

new System.Numerics.BigInteger(2971396313398007551L),

new System.Numerics.BigInteger(7510917406530744470L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4112231511928319832L),

new System.Numerics.BigInteger(1400064505534602255L),

new System.Numerics.BigInteger(8913438727575627974L),

new System.Numerics.BigInteger(1319291509210586321L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4466602130505562275L),

new System.Numerics.BigInteger(554940213542947608L),

new System.Numerics.BigInteger(3329139465445299954L),

new System.Numerics.BigInteger(3924435463501267382L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6528251690040846077L),

new System.Numerics.BigInteger(5639933003454801010L),

new System.Numerics.BigInteger(5013221255394011603L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4335736998650908882L),

new System.Numerics.BigInteger(7419280668556750482L),

new System.Numerics.BigInteger(8695053750705841382L),

new System.Numerics.BigInteger(649301439696481379L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4615669258061939168L),

new System.Numerics.BigInteger(8576522199343677527L),

new System.Numerics.BigInteger(1413425575382219678L),

new System.Numerics.BigInteger(69324182680882389L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4392033385536558951L),

new System.Numerics.BigInteger(7075744485469171880L),

new System.Numerics.BigInteger(8577482764703285239L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1018130421004294426L),

new System.Numerics.BigInteger(7509847015270558250L),

new System.Numerics.BigInteger(4894650785696633249L),

},
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7004208749725925267L),

new System.Numerics.BigInteger(7019422301700154038L),

new System.Numerics.BigInteger(1030793096982458673L),

new System.Numerics.BigInteger(3280829066146404326L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(655001124090975377L),

new System.Numerics.BigInteger(435893325164453267L),

new System.Numerics.BigInteger(6089358098018609813L),

new System.Numerics.BigInteger(5612120028763335150L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2648039925194537751L),

new System.Numerics.BigInteger(5110403513001628618L),

new System.Numerics.BigInteger(6738437162810610998L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2935887476330735274L),

new System.Numerics.BigInteger(8232090058599132537L),

new System.Numerics.BigInteger(2364666770712249409L),

new System.Numerics.BigInteger(9011611324190283551L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332170131437441294L),

new System.Numerics.BigInteger(194701757753365454L),

new System.Numerics.BigInteger(6936682121102620391L),

new System.Numerics.BigInteger(2859530247746304797L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6684852433788909150L),

new System.Numerics.BigInteger(2857664200370047419L),

new System.Numerics.BigInteger(5294871105998236176L),

new System.Numerics.BigInteger(954814876926584082L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8171793923737797174L),

new System.Numerics.BigInteger(4320076389648177942L),

new System.Numerics.BigInteger(8407011167216900361L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6380631757419124161L),

new System.Numerics.BigInteger(6584202320734086730L),

new System.Numerics.BigInteger(748004724432555187L),

new System.Numerics.BigInteger(2637706460355770351L),

},
},
            new BigIntegernumericArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7565030732026263917L),

new System.Numerics.BigInteger(367736454660388710L),

new System.Numerics.BigInteger(4252805193866139562L),

new System.Numerics.BigInteger(3895029709949035558L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8979286754200305087L),

new System.Numerics.BigInteger(8116162998106226968L),

new System.Numerics.BigInteger(3872442982598726929L),

new System.Numerics.BigInteger(5850975815514020423L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7100928398929911197L),

new System.Numerics.BigInteger(8637631337780707910L),

new System.Numerics.BigInteger(50329848655300640L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2205201212174710077L),

new System.Numerics.BigInteger(8404406868579753054L),

new System.Numerics.BigInteger(7421473197524366275L),

new System.Numerics.BigInteger(3457046094693535559L),

},
},
            new BigIntegernumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6510918070019871938L),

new System.Numerics.BigInteger(6970018429526586934L),

new System.Numerics.BigInteger(4875328694996154055L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7006230184586178463L),

new System.Numerics.BigInteger(4398477636696718270L),

new System.Numerics.BigInteger(8865975304083994761L),

new System.Numerics.BigInteger(6594046826480150426L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4335692389896009915L),

new System.Numerics.BigInteger(4020434103229734550L),

new System.Numerics.BigInteger(2287209346907091364L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4354182025528072720L),

new System.Numerics.BigInteger(67737323296619828L),

new System.Numerics.BigInteger(6165170604069797403L),

new System.Numerics.BigInteger(5839499700307811667L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1212073386545714198L),

new System.Numerics.BigInteger(7347244797470211820L),

new System.Numerics.BigInteger(8772029359332392909L),

new System.Numerics.BigInteger(8645330283128000196L),

},
},
            new BigIntegernumericArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8066671538559307991L),

new System.Numerics.BigInteger(7405407399471628072L),

new System.Numerics.BigInteger(2233695695138842585L),

new System.Numerics.BigInteger(3610221439903094497L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4766653109744422161L),

new System.Numerics.BigInteger(5961169315726699296L),

new System.Numerics.BigInteger(7662527981781986128L),

new System.Numerics.BigInteger(6414066232650972668L),

},
},
            new BigIntegernumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9184690640075209012L),

new System.Numerics.BigInteger(408067366000134688L),

new System.Numerics.BigInteger(7808295858386368552L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8951770728170214202L),

new System.Numerics.BigInteger(8805462822621271575L),

new System.Numerics.BigInteger(7940849970700718615L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5281012065167031782L),

new System.Numerics.BigInteger(4085237067294882764L),

new System.Numerics.BigInteger(9191603894941482815L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5413413886789975890L),

new System.Numerics.BigInteger(2569387212217513445L),

new System.Numerics.BigInteger(7591617404674946330L),

new System.Numerics.BigInteger(1415993108342654914L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6963666720566425081L),

new System.Numerics.BigInteger(8450135399101217064L),

new System.Numerics.BigInteger(3932101518657201001L),

new System.Numerics.BigInteger(6309206723426994221L),

},
},
            new BigIntegernumericArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2488284431934462090L),

new System.Numerics.BigInteger(3118849852262016857L),

new System.Numerics.BigInteger(5511572154956332184L),

new System.Numerics.BigInteger(1826244486544110006L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(598440759799478851L),

new System.Numerics.BigInteger(8289193289133552630L),

new System.Numerics.BigInteger(7715752761773046348L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7170508598915543875L),

new System.Numerics.BigInteger(6658581860584750728L),

new System.Numerics.BigInteger(612790807994671233L),

new System.Numerics.BigInteger(5594761508275882408L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4689177713128152086L),

new System.Numerics.BigInteger(5570813617230874091L),

new System.Numerics.BigInteger(840565280966355258L),

},
},
            new BigIntegernumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6833030723830160980L),

new System.Numerics.BigInteger(4603503721288391817L),

new System.Numerics.BigInteger(6742679140942672484L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3443043419817650250L),

new System.Numerics.BigInteger(2685811414160326462L),

new System.Numerics.BigInteger(6811801734787851437L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3663644725745850124L),

new System.Numerics.BigInteger(9169955846411392416L),

new System.Numerics.BigInteger(6449870832859168174L),

new System.Numerics.BigInteger(4122706456308028024L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3829097820000453341L),

new System.Numerics.BigInteger(313016128872492538L),

new System.Numerics.BigInteger(8654835586047418410L),

new System.Numerics.BigInteger(6888179480557300384L),

},
},
            new BigIntegernumericArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3257898669590606546L),

new System.Numerics.BigInteger(8245380534066726044L),

new System.Numerics.BigInteger(1650984092959797801L),

new System.Numerics.BigInteger(6237297463573825635L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3276674715393202802L),

new System.Numerics.BigInteger(5149581403945180905L),

new System.Numerics.BigInteger(5279985288617204667L),

new System.Numerics.BigInteger(3779307018066373463L),

},
},
            new BigIntegernumericArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(728623820032229588L),

new System.Numerics.BigInteger(565991731766721859L),

new System.Numerics.BigInteger(7575927596385416074L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4247743320454702838L),

new System.Numerics.BigInteger(4223399011253870810L),

new System.Numerics.BigInteger(6448717272518763141L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8780833272388168416L),

new System.Numerics.BigInteger(552482957237286310L),

new System.Numerics.BigInteger(6035234407546221540L),

new System.Numerics.BigInteger(2401138301556980877L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4282569720272245152L),

new System.Numerics.BigInteger(3957593841583798136L),

new System.Numerics.BigInteger(5194905410433373232L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1432664932053718892L),

new System.Numerics.BigInteger(2221329038042735395L),

new System.Numerics.BigInteger(7812707235316851669L),

},
},
            new BigIntegernumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4737581293557329486L),

new System.Numerics.BigInteger(5220960095627014953L),

new System.Numerics.BigInteger(5459934671131431408L),

new System.Numerics.BigInteger(1306364822966934997L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3110954277928408160L),

new System.Numerics.BigInteger(8686958859595944036L),

new System.Numerics.BigInteger(4455865506749622999L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1730251762759678304L),

new System.Numerics.BigInteger(1330958518484901667L),

new System.Numerics.BigInteger(5866455361026612600L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4686838701240280740L),

new System.Numerics.BigInteger(4430823868516235363L),

new System.Numerics.BigInteger(5192220205591228774L),

new System.Numerics.BigInteger(5310762438135282347L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9082942898295654306L),

new System.Numerics.BigInteger(4680359139536598835L),

new System.Numerics.BigInteger(2471766722404322460L),

new System.Numerics.BigInteger(8973048643983207806L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2565771907839195987L),

new System.Numerics.BigInteger(569188883426373643L),

new System.Numerics.BigInteger(922718074669167170L),

new System.Numerics.BigInteger(118094154155313899L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4073667260701047989L),

new System.Numerics.BigInteger(3948405180794143065L),

new System.Numerics.BigInteger(3914927709525830883L),

},
},
            new BigIntegernumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7270818226697981442L),

new System.Numerics.BigInteger(1855527730763137079L),

new System.Numerics.BigInteger(2709691302057811584L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4570772341497974281L),

new System.Numerics.BigInteger(7737846011772892964L),

new System.Numerics.BigInteger(6310824036053467294L),

new System.Numerics.BigInteger(2733706575560827372L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6372057222341730856L),

new System.Numerics.BigInteger(2827782542621829174L),

new System.Numerics.BigInteger(1011787954482969590L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8596360525331731593L),

new System.Numerics.BigInteger(3146552660132292921L),

new System.Numerics.BigInteger(6137886704442903494L),

new System.Numerics.BigInteger(4657289423470561324L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9045536827335316651L),

new System.Numerics.BigInteger(464783213060572200L),

new System.Numerics.BigInteger(5962771437345079375L),

new System.Numerics.BigInteger(1325866985842567411L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6318624862286519072L),

new System.Numerics.BigInteger(7808070872089466612L),

new System.Numerics.BigInteger(5296982115354738583L),

new System.Numerics.BigInteger(846538835800151441L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1516562956019152229L),

new System.Numerics.BigInteger(953750223910098746L),

new System.Numerics.BigInteger(4829476720011115447L),

new System.Numerics.BigInteger(3279878905167475886L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8084833486147598385L),

new System.Numerics.BigInteger(3384522508556676390L),

new System.Numerics.BigInteger(1623767842645499293L),

new System.Numerics.BigInteger(3658162759080454827L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(898486173645975207L),

new System.Numerics.BigInteger(3630942217099947631L),

new System.Numerics.BigInteger(2268122638741434553L),

new System.Numerics.BigInteger(4108501159221871151L),

},
},
            new BigIntegernumericArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1025816962788167567L),

new System.Numerics.BigInteger(2171396783128668230L),

new System.Numerics.BigInteger(6961141648677770074L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8159542131187261801L),

new System.Numerics.BigInteger(4916830616225776844L),

new System.Numerics.BigInteger(7498078314052623643L),

},
},
            new BigIntegernumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8181861911197643894L),

new System.Numerics.BigInteger(4575081006389890325L),

new System.Numerics.BigInteger(4233452577478267769L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6116543907936636310L),

new System.Numerics.BigInteger(1911536909321737424L),

new System.Numerics.BigInteger(5304838948905964780L),

new System.Numerics.BigInteger(1207898954506810847L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2076981642329402154L),

new System.Numerics.BigInteger(3035362612865011010L),

new System.Numerics.BigInteger(8154238521413881537L),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                List<BigIntegernumericArray2M> models = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 103;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 40, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
BigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2M>(15);

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
                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

