

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
    internal partial interface IInt64MArrayMArrayD1
    {
    }
    
    internal partial class Int64MArrayMArrayD1 : IInt64MArrayMArrayD1
    {


#region TestData

        private readonly Int64MArrayD1E1M[] _testData = new Int64MArrayD1E1M[]
        {
            new Int64MArrayD1E1M
{
    Id = 3,
    Value = 
new System.Int64[3]
{
8129074624429509052L,
4140017403859788389L,
1399346322792974509L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Int64[3]
{
4528035748346094174L,
2480790175415919964L,
1983223371082810433L,
},
    NullableValue = 
new System.Int64[3]
{
956194744179854311L,
470675679494863506L,
3947833098493203523L,
},
},
    NullableValue = 
new System.Int64[3]
{
3957291944358107020L,
6884135679351996777L,
4791061594651377900L,
},
},
            new Int64MArrayD1E1M
{
    Id = 11,
    Value = 
new System.Int64[4]
{
6002199127127986561L,
4556157032214084916L,
9216337616736345315L,
1184202351037943470L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int64[4]
{
1432537772950219720L,
5159946501426037632L,
8637619603335754628L,
3077386235918604812L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 16,
    Value = 
new System.Int64[4]
{
4074664780999852266L,
7361459602087475355L,
6512659077079884582L,
5275249932977219129L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int64[3]
{
2655839210974592945L,
1387474431918013861L,
3791778483959145607L,
},
    NullableValue = 
new System.Int64[4]
{
5010157373075975667L,
6342598518907566000L,
569526127575963591L,
6098955873646888860L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 23,
    Value = 
new System.Int64[4]
{
8218347501295432140L,
6307578726463340326L,
9218915783675162264L,
3903965504838630389L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int64[4]
{
6005607202714427034L,
7416194702774258597L,
3901080979468232555L,
4141045909006409009L,
},
    NullableValue = 
new System.Int64[4]
{
3482571154314138168L,
4018371159072051418L,
8721275995227877615L,
3485150655227271406L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int64[3]
{
2778003157786889318L,
7479112381126017113L,
4329091887206791748L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int64[4]
{
7180101965863228231L,
882208659209115007L,
4542266610745120858L,
880893483144514465L,
},
    NullableValue = 
new System.Int64[4]
{
1671295232887319130L,
6340488775091725402L,
7382602301775840202L,
4502293056059034548L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
8198419856227354380L,
5205088867840221120L,
1649981216130019019L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
1997747991954211413L,
6622654900375638946L,
6138640159999863716L,
2354021996477509460L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1208145274520468063L,
1660192365307340948L,
2480042172043960573L,
4004490274632096488L,
},
},
            new Int64MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
7623213456117155404L,
2187277463615412269L,
7894869676947951378L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
2672855321980807349L,
1114136185453913393L,
8124536386154045525L,
6178125319362641344L,
},
    NullableValue = 
new System.Int64[4]
{
4272852150986453427L,
9198301847308704112L,
990624034485700575L,
2514369934964904274L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
3685637392812544981L,
3549785367149262878L,
15757559752548255L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int64[4]
{
5264754926026157642L,
896288404489868282L,
6765991751536241803L,
2663156373050879532L,
},
    NullableValue = 
new System.Int64[3]
{
2352982411129212152L,
7115219002426931895L,
5527303955563453301L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int64[3]
{
5708566085112998885L,
1515843269541601389L,
3963280368928048473L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int64[3]
{
3553253133935266190L,
3633769959686709016L,
7918459782053281607L,
},
    NullableValue = 
new System.Int64[4]
{
4658043536363219862L,
4777955974792316031L,
5878834456868938197L,
5865640427730419114L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 53,
    Value = 
new System.Int64[3]
{
864319544773734956L,
5116409536044065462L,
5780434499934066868L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
1161295306435183692L,
4412158053801910536L,
5796767007684477760L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[3]
{
4596342594477618568L,
680123684660009126L,
5978152354613614727L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Int64[4]
{
6178335770757042709L,
5595451747547284243L,
7036456497033807412L,
4498035689508260499L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8335102153846617625L,
436431923324959126L,
6476246549851082810L,
240448449439331544L,
},
},
            new Int64MArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int64[3]
{
1063356413885032374L,
861849734399079788L,
1740291095651178250L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
3918621678904161304L,
5742253927754127842L,
2063243813231529807L,
2371054365431037480L,
},
    NullableValue = 
new System.Int64[4]
{
5296469372394325385L,
7365635452075421274L,
587355103711672888L,
1336574586618872800L,
},
},
    NullableValue = 
new System.Int64[4]
{
563116078508568466L,
5014922980291032506L,
422482410253714148L,
5117853747605539305L,
},
},
            new Int64MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int64[4]
{
7084083719403152111L,
2986385667849612617L,
5663305436489313880L,
4993351495562879690L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
3020488073179122364L,
3885254003579436726L,
5106664072529953014L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int64[4]
{
5076676328818022954L,
7783248547181784006L,
5421174207522037216L,
8438464335838931326L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int64[3]
{
895085952310004507L,
5570891577888187998L,
2063880163773960764L,
},
    NullableValue = 
new System.Int64[3]
{
6860368761116150871L,
214092782870144626L,
4680186115101543233L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
4934371340104999273L,
2278341353524719597L,
2101210588865953171L,
890418351262834959L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Int64[4]
{
2273283287160108348L,
837583251055932314L,
5482615471255513970L,
3789069318999549337L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int64[4]
{
5153669147291059422L,
1996647499340064413L,
4213833906258404100L,
864237094408624446L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int64[4]
{
4839996855838483649L,
4102453440413789670L,
2859993939907294868L,
7867274499004025715L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int64[4]
{
5536760226960196101L,
7780159492019469535L,
6955861494702827747L,
1627349531609974799L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int64[4]
{
6075490560936867695L,
1970407818918223590L,
2477620344123522714L,
8631798560418574670L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
4330653160313036376L,
6547088188812356186L,
8606734203203338902L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Int64[3]
{
2220403769523509446L,
7461510337189166574L,
4332510765827906496L,
},
    NullableValue = 
new System.Int64[4]
{
6310294215586653672L,
6201588401049843326L,
3724053768760433781L,
5611639562569330366L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
588306245461465954L,
9005545453698854586L,
5642086354611693669L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int64[4]
{
8038458311388204123L,
2044435426398322872L,
7517954639058734750L,
5023659949324235963L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6912253948256909840L,
2832751437521662016L,
7079674058403569268L,
999061583217551680L,
},
},
            new Int64MArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int64[4]
{
5228883926228301390L,
1938999566908148521L,
3132393957177816373L,
676864033717794826L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Int64[4]
{
4621723834900727528L,
8475864755937259794L,
8224269664227049918L,
8609381770377141428L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
1417615006606316743L,
4103736018849655261L,
2099812936668281605L,
7276941531740810548L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int64[3]
{
738204349920996375L,
7157585604399974284L,
574392991291051630L,
},
    NullableValue = 
new System.Int64[3]
{
4595330863376895958L,
5183890438022365330L,
1404226241980951381L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int64[4]
{
9128770602865346075L,
9177534405640719528L,
4855340087277232221L,
5838349417442547581L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int64[3]
{
9043416519613899389L,
1455355389823856785L,
6104311837513845916L,
},
    NullableValue = 
new System.Int64[4]
{
4640547613334296851L,
873487129043129653L,
539757379518658864L,
7720579204607595932L,
},
},
    NullableValue = 
new System.Int64[3]
{
271994016105211741L,
7129966356080411177L,
6121926286050931097L,
},
},
            new Int64MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int64[3]
{
8843452173779837908L,
6338353014980453554L,
4278507193515630099L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int64[4]
{
4270214229789017093L,
3815313825868032472L,
763191601059558991L,
4105031380080798201L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6194489110298512572L,
5067707933027869444L,
8517891132603200148L,
4109378662391287146L,
},
},
            new Int64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
2296466229296423593L,
1171053286656337824L,
3079417612347207860L,
864626375865702355L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Int64[4]
{
1990390844143495839L,
4007520177268807690L,
947348394457134873L,
7747275236457437917L,
},
    NullableValue = 
new System.Int64[4]
{
8509353864064969056L,
5919883265407974715L,
4206354318923281059L,
6863286839733620753L,
},
},
    NullableValue = 
new System.Int64[3]
{
7037654252157911288L,
7363846288679382017L,
7128795130510322984L,
},
},
            new Int64MArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int64[4]
{
5531734949804547855L,
5583911990640623120L,
6158488636686547529L,
1019267038140847409L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int64[4]
{
8954447008942716984L,
4588083291039947416L,
5259348089807639495L,
7880959680775665578L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int64[3]
{
8388742545090346678L,
3197729542186572287L,
4882238775096857188L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Int64[3]
{
374467337273063063L,
3798704674401306096L,
6506505049160932266L,
},
    NullableValue = 
new System.Int64[3]
{
1574611083381781226L,
6317986873784545513L,
3168729315732014519L,
},
},
    NullableValue = 
new System.Int64[4]
{
5544551685992640738L,
4895665766685304190L,
4129013037366153773L,
1655399442106422509L,
},
},
            new Int64MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[4]
{
6152782315698184898L,
793963965881833985L,
8295447029052116881L,
6477421373683937759L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int64[3]
{
807423149916783356L,
2371553856816606479L,
5026546301946441943L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8222327724787520557L,
284878765595359555L,
9035155784339707391L,
6184425672054001050L,
},
},
            new Int64MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
1969173637073266529L,
1878201448510415961L,
1791698031225886988L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Int64[3]
{
4122466810568626961L,
8808382971805092545L,
3554138734408961022L,
},
    NullableValue = 
new System.Int64[3]
{
8271028872791554778L,
9057250026729533829L,
7234471089782413787L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int64[4]
{
443280479361699798L,
4984753922938235604L,
675060477872642112L,
7898890658067461967L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.Int64[4]
{
965991117619270453L,
7957620657558385677L,
5694680724857349194L,
4664743121875016357L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7512748367766071974L,
6799193214760797633L,
8210765585978179422L,
},
},
            new Int64MArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int64[3]
{
802154879762091772L,
983732070312982027L,
8430598137052029528L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int64[3]
{
5724528444202932983L,
8209313340058498135L,
6828849975377739031L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5844640849694593292L,
2758544098603427507L,
7543503292380631289L,
7785195147677699390L,
},
},
            new Int64MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int64[3]
{
5205754019971359823L,
3334382497158750534L,
7845672993603651229L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.Int64[4]
{
1988761877323867069L,
7027411709935170249L,
1819960650159212181L,
1348365900940067374L,
},
    NullableValue = 
new System.Int64[3]
{
4814966403765096851L,
2537426247082784305L,
537112899459028926L,
},
},
    NullableValue = 
new System.Int64[3]
{
3211719118257894567L,
6274567173778063516L,
7968144968449844257L,
},
},
            new Int64MArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int64[4]
{
5793064302713270573L,
9193001649768477915L,
1253073781928840399L,
8913232463901409670L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Int64[3]
{
6995727756780200082L,
5380674872739653211L,
123929051606723928L,
},
    NullableValue = 
new System.Int64[3]
{
8680188522246155359L,
6062787691165586701L,
167610958556110998L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 166,
    Value = 
new System.Int64[3]
{
4930724910228907978L,
5644319227054693223L,
5847761113020508019L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Int64[3]
{
98883536731555226L,
5652586254491457300L,
8905813536211597892L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6619595047460383541L,
9178292127224475604L,
2168314316828305347L,
5411889054266463526L,
},
},
            new Int64MArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int64[4]
{
5513770988448943632L,
5567588926293059344L,
6155733066224553820L,
5341604984267883408L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Int64[4]
{
7094613716878850273L,
6750072945311354269L,
4189853256057932075L,
3468259147551494615L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 177,
    Value = 
new System.Int64[3]
{
460332008904026374L,
5394658303413032917L,
7220986087609834789L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 185,
    Value = 
new System.Int64[3]
{
5412672684344839155L,
2167453238504533074L,
4382700369496067055L,
},
    NullableValue = 
new System.Int64[4]
{
3983729383230051909L,
1796919427895416121L,
6269942096197619602L,
7836738280859292942L,
},
},
    NullableValue = 
new System.Int64[3]
{
8940392351041073647L,
1554558165523044346L,
4470435239595038221L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int64)}, 
    {mi_id:Int32},
    {mi_value:Array(Int64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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
                    await ((IInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
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
                    var models = await ((IInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

