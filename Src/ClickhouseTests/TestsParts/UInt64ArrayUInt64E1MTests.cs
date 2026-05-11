

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64MArrayArrayUInt64
    {
    }
    
    internal partial class UInt64MArrayArrayUInt64 : IUInt64MArrayArrayUInt64
    {


#region TestData

        private readonly UInt64ArrayUInt64E1M[] _testData = new UInt64ArrayUInt64E1M[]
        {
            new UInt64ArrayUInt64E1M
{
    Id = 8,
    Value = 
new System.UInt64[3]
{
4229048122296705558L,
3076498203215915593L,
2023242960645880121L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 7,
    Value = 
new System.UInt64[4]
{
631670661079738083L,
5072945674725293917L,
1282469449045094969L,
8747416856496391110L,
},
    NullableValue = 
new System.UInt64[3]
{
1881940486939037638L,
4469887307577360490L,
3897514855958410729L,
},
},
    NullableValue = 
new System.UInt64[3]
{
5440016888155782772L,
5769541532015397254L,
3796823771457525937L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 16,
    Value = 
new System.UInt64[3]
{
74166711607124368L,
5655105235425005277L,
4098768627346494395L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 13,
    Value = 
new System.UInt64[4]
{
6534081388004679636L,
2074339608015344013L,
8058986628695759115L,
7430815264013695631L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8949615890193086816L,
959417303108220643L,
8526901873003576680L,
1547018704418714677L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 23,
    Value = 
new System.UInt64[3]
{
839662933339392651L,
5421420758063497813L,
1881006012935987081L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 20,
    Value = 
new System.UInt64[3]
{
8868610723264771746L,
5382213948474152105L,
5605507086639943862L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5543610729263604529L,
7213775136763117220L,
476851368385872034L,
1458972310309082416L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 30,
    Value = 
new System.UInt64[3]
{
4999205757006485235L,
7264695455467899158L,
4470395565663764304L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 25,
    Value = 
new System.UInt64[3]
{
4571914412460549379L,
8233252272498875596L,
1205186835039966859L,
},
    NullableValue = 
new System.UInt64[4]
{
650100734723575268L,
7179834396988764430L,
5049272735769882487L,
616189940837954511L,
},
},
    NullableValue = 
new System.UInt64[3]
{
6285941752883795522L,
8536965544028463535L,
2066029345334245922L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 32,
    Value = 
new System.UInt64[3]
{
8940892982209499882L,
7731547400579476285L,
1646226219618279276L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 31,
    Value = 
new System.UInt64[4]
{
4787059633662648916L,
5810593167786130620L,
4882275049950719070L,
6088774649581262120L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 41,
    Value = 
new System.UInt64[3]
{
6383604601517240772L,
5472821422884694626L,
9211180885714872478L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 33,
    Value = 
new System.UInt64[4]
{
8614196107607827905L,
5724900132188223890L,
128539575489506165L,
4429930827196159144L,
},
    NullableValue = 
new System.UInt64[4]
{
3557929747595465191L,
7350895351948577463L,
2116349305355741018L,
6368546133741987140L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5620704487673131608L,
8605655756128451953L,
9067714713553490995L,
451697502468898440L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 44,
    Value = 
new System.UInt64[4]
{
6179391505249011632L,
7645401716717372606L,
8232240627134592104L,
8506466961575631012L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
4572666755818542438L,
6972835163350282940L,
3907658510066332771L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 50,
    Value = 
new System.UInt64[3]
{
1544205275777721489L,
6491876559604434653L,
6546133507618883467L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 44,
    Value = 
new System.UInt64[3]
{
8238221969102034959L,
7365366676232862694L,
2743599388311869778L,
},
    NullableValue = 
new System.UInt64[3]
{
6986131406676772017L,
5983802036436718899L,
8687224905767864469L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 53,
    Value = 
new System.UInt64[3]
{
2575488325181816898L,
8568002168182707216L,
7606586225544430366L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 46,
    Value = 
new System.UInt64[4]
{
2126641685784696746L,
6357776874748266704L,
1966589573572082980L,
417246951967391012L,
},
    NullableValue = 
new System.UInt64[4]
{
4755065793079530946L,
395944001674081728L,
2225828692334318661L,
5956666529000919325L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 55,
    Value = 
new System.UInt64[4]
{
5905566079215540316L,
6424285178047200244L,
456002790964846744L,
3821281807318448877L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 53,
    Value = 
new System.UInt64[3]
{
4513301250045477157L,
9109886889053384410L,
5382339665272311665L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 60,
    Value = 
new System.UInt64[4]
{
6124923846788617998L,
1945564138868478891L,
8078864012587521715L,
5579258312331936542L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 62,
    Value = 
new System.UInt64[3]
{
4438813871803439399L,
2024290286712941551L,
4731198425261239537L,
},
    NullableValue = 
new System.UInt64[3]
{
2958125060675919438L,
5362526551153421711L,
2244308801725073390L,
},
},
    NullableValue = 
new System.UInt64[3]
{
5176770653982300366L,
2731730833654735997L,
2478128586107519336L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 65,
    Value = 
new System.UInt64[4]
{
3863938673299846172L,
3171636607060169066L,
8670543611451977837L,
5771415104372128534L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 66,
    Value = 
new System.UInt64[4]
{
6951449827201011023L,
4042833939695052189L,
3225442110362109086L,
2934948899447455955L,
},
    NullableValue = 
new System.UInt64[3]
{
560036279176999746L,
3419392269361200864L,
5353160129409502190L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6212388918097561007L,
2179563615838618932L,
5058154266028076152L,
3569521565748171327L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 70,
    Value = 
new System.UInt64[4]
{
6603958999890063085L,
5867627734994980892L,
4199989581315888972L,
1355316616755402666L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 69,
    Value = 
new System.UInt64[3]
{
4836674471891259759L,
6266920668730102366L,
6467160358106896331L,
},
    NullableValue = 
new System.UInt64[4]
{
2577641195455029291L,
294967828971977627L,
4283564242076606179L,
1137733365244286265L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 77,
    Value = 
new System.UInt64[4]
{
7444073039984370199L,
641816556623330156L,
6447760709540390950L,
247100866562465063L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 72,
    Value = 
new System.UInt64[4]
{
7127111354234671946L,
4611613802581123761L,
7350358231645218775L,
1840492507706321215L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7300192336001541764L,
4796285096538825515L,
4492988795170094537L,
8201086445687929693L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 79,
    Value = 
new System.UInt64[4]
{
401749521604611823L,
4827764936229883354L,
1865605319959850155L,
2909931265794334302L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 81,
    Value = 
new System.UInt64[3]
{
990676209600146250L,
7721693785876630911L,
7253588955164875339L,
},
    NullableValue = 
new System.UInt64[4]
{
4512375526726612461L,
7315607078277086911L,
8372413094546231626L,
8807911047433327991L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 83,
    Value = 
new System.UInt64[4]
{
7599388691237228464L,
4748028641194339923L,
4393167097026835660L,
8983685457869160420L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 85,
    Value = 
new System.UInt64[3]
{
7987129765987904139L,
5968076758164263658L,
1669203835352584982L,
},
    NullableValue = 
new System.UInt64[3]
{
1941197257768801118L,
5407391882064527687L,
2711339351801377126L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 84,
    Value = 
new System.UInt64[4]
{
48815570244397787L,
4590109220625021141L,
4838739185098650645L,
7832173418938022494L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 92,
    Value = 
new System.UInt64[3]
{
7874976803287143447L,
8618351704031107977L,
4889972325536053348L,
},
    NullableValue = 
new System.UInt64[4]
{
8043271116610976961L,
6053694512774752278L,
3837798579676590229L,
3345378289382323425L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 88,
    Value = 
new System.UInt64[4]
{
3283921997074195910L,
2114405690499629889L,
639239080432841267L,
1582184255348140735L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 98,
    Value = 
new System.UInt64[3]
{
28775508694371194L,
2593510199271659514L,
5770177531997540103L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 89,
    Value = 
new System.UInt64[3]
{
8039769579578503703L,
7376558864722209201L,
8171588849994370180L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 102,
    Value = 
new System.UInt64[3]
{
7569686222547142964L,
8938899824648441981L,
4843960710535957291L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7016294260910009804L,
2771507878224375433L,
8573152895046510821L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 93,
    Value = 
new System.UInt64[3]
{
6365113120780863220L,
5568657759938501200L,
5927036997371250660L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 110,
    Value = 
new System.UInt64[3]
{
4992806591660738022L,
4634185954637972278L,
2241683893077365538L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 94,
    Value = 
new System.UInt64[4]
{
5214800689019147420L,
2091617537876314661L,
3946004564671793867L,
7547689165425693797L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 112,
    Value = 
new System.UInt64[4]
{
3987741750279088495L,
4668062060341669067L,
3088639988453989872L,
7488812123832024507L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5107767024265111054L,
3574720927370443491L,
4214529043541471573L,
774253996654199310L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 98,
    Value = 
new System.UInt64[4]
{
7370445252940401924L,
697067468395849939L,
7823579999232761083L,
2917088266302417253L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 115,
    Value = 
new System.UInt64[3]
{
8937753588071342166L,
1019141004231149277L,
9032729132482793931L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
8276948414686146640L,
465799100512390524L,
3374400269652366925L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 103,
    Value = 
new System.UInt64[4]
{
1690952596647593521L,
752918000207045294L,
2494640630595976541L,
8423968984203528944L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 122,
    Value = 
new System.UInt64[4]
{
4901437627382882543L,
2864633565341130470L,
8716245814447814839L,
392836512969505061L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
3716961044625029124L,
7781972265563943922L,
9075095237220024252L,
2578303801404902984L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 104,
    Value = 
new System.UInt64[4]
{
1954863617814417712L,
5139688440014980120L,
7252195533822551547L,
8458499682295461164L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 130,
    Value = 
new System.UInt64[3]
{
6899052796486183111L,
7407862455649496641L,
1239944815226778779L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 106,
    Value = 
new System.UInt64[4]
{
4202141761034260239L,
3480081254474660851L,
8976081292336840486L,
2564731781306473473L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 134,
    Value = 
new System.UInt64[3]
{
1516209155383494013L,
5763012495454900954L,
3334319148554147293L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 115,
    Value = 
new System.UInt64[3]
{
2214612882157302087L,
8128358696575190176L,
1815263819032273682L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 135,
    Value = 
new System.UInt64[4]
{
2048893914315352633L,
3183496182325482801L,
5488705238637405545L,
5514494228367657562L,
},
    NullableValue = 
new System.UInt64[3]
{
7848258567649847307L,
6502462928143749717L,
9126638908039261327L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 123,
    Value = 
new System.UInt64[3]
{
5479986101320400982L,
6750596298305618381L,
223654644184654002L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 137,
    Value = 
new System.UInt64[3]
{
6878524078154813959L,
2566791329926713864L,
476324738522991379L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 129,
    Value = 
new System.UInt64[3]
{
7262221909444652269L,
589429890846029839L,
13533092832023512L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 145,
    Value = 
new System.UInt64[3]
{
4321051351001603187L,
8424954054592068912L,
7809313259415663505L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3748204505659569690L,
5120829913740552419L,
488870555492347429L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 136,
    Value = 
new System.UInt64[4]
{
121728505063521107L,
8288859332230713502L,
206430201603642721L,
936245951205659793L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 148,
    Value = 
new System.UInt64[3]
{
7444840516215191392L,
4807428609265929109L,
8667937103669475577L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3756403864097951223L,
557302105880566052L,
4213588098147071864L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 145,
    Value = 
new System.UInt64[4]
{
9207808891327827015L,
8925373869348609073L,
9174679919479655236L,
3507357764802799346L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 152,
    Value = 
new System.UInt64[3]
{
8837630023634597896L,
1978226786951433218L,
3242121802647467144L,
},
    NullableValue = 
new System.UInt64[3]
{
7535226083932628881L,
882214436709119396L,
3885164774825851137L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4411851846677961755L,
3915009343902247195L,
3695829490444002355L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 148,
    Value = 
new System.UInt64[4]
{
6042063281250442218L,
1759577131426426437L,
7808657033073865164L,
3597980996397676731L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 161,
    Value = 
new System.UInt64[4]
{
1059436296390085484L,
2878674546456582580L,
5279686748892768128L,
7635262555889372088L,
},
    NullableValue = 
new System.UInt64[3]
{
8940077084467412279L,
3856938039319156876L,
4101797288451435429L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4504738223298427661L,
7460574913581515362L,
7990477701430596277L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 154,
    Value = 
new System.UInt64[4]
{
8013219667943894020L,
5309680444684821403L,
8372363945566255013L,
6885963577558190846L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 167,
    Value = 
new System.UInt64[4]
{
7083722268133176699L,
5446061505578175523L,
8275993620645492109L,
189040413710817815L,
},
    NullableValue = 
new System.UInt64[3]
{
1710694135068508733L,
6845864035816278887L,
3104977003436562099L,
},
},
    NullableValue = 
new System.UInt64[3]
{
5680633691498184935L,
2394504778870471443L,
4045331995855117377L,
},
},
            new UInt64ArrayUInt64E1M
{
    Id = 162,
    Value = 
new System.UInt64[3]
{
2623050325144916476L,
5376924289300028291L,
1038129090184382491L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 172,
    Value = 
new System.UInt64[4]
{
2486220397459135594L,
5883056551777117169L,
5021774683623617582L,
5500350789782863917L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 168,
    Value = 
new System.UInt64[3]
{
5676639079524240631L,
8714336978584760125L,
2006508691731942501L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 181,
    Value = 
new System.UInt64[4]
{
3798168932938918796L,
5391060784522017225L,
4379506066283691254L,
5399631555603178539L,
},
    NullableValue = 
new System.UInt64[3]
{
5569082469198474033L,
145923045249015505L,
9081657552638194270L,
},
},
    NullableValue = null,
},
            new UInt64ArrayUInt64E1M
{
    Id = 173,
    Value = 
new System.UInt64[3]
{
5258550030076485335L,
1182168366194946043L,
1886929481990471919L,
},
    ModelInner = new UInt64ArrayUInt641MI
{
    Id = 185,
    Value = 
new System.UInt64[3]
{
5146938983887591175L,
6766680740355412273L,
6051983377144976508L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1971275059539864428L,
6966418197365078883L,
5931794877281309372L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64arrayuint64e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt64)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayArrayUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64MArrayArrayUInt64)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64MArrayArrayUInt64)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64arrayuint64e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64ArrayUInt64E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayArrayUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64MArrayArrayUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayUInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64MArrayArrayUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayUInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

