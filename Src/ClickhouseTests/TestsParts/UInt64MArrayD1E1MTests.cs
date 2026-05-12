

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
    internal partial interface IUInt64MArrayMArrayD1
    {
    }
    
    internal partial class UInt64MArrayMArrayD1 : IUInt64MArrayMArrayD1
    {


#region TestData

        private readonly UInt64MArrayD1E1M[] _testData = new UInt64MArrayD1E1M[]
        {
            new UInt64MArrayD1E1M
{
    Id = 3,
    Value = 
new System.UInt64[3]
{
2805353207101064647L,
7294651650935951412L,
2334815372305972514L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 3,
    Value = 
new System.UInt64[4]
{
8161332209444611299L,
3478965941393920430L,
3601014244609020334L,
5560344884361572577L,
},
    NullableValue = 
new System.UInt64[3]
{
5082756860341822874L,
3849298550456352906L,
8188208713040347199L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 9,
    Value = 
new System.UInt64[3]
{
2255766082152414086L,
3408198878691235276L,
2313955944919794734L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.UInt64[4]
{
2930343220048737324L,
113038495933752786L,
3811517930274063756L,
1518945702417747981L,
},
    NullableValue = 
new System.UInt64[3]
{
193380290295370217L,
1852507510984452796L,
4400410008478268354L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt64[4]
{
2505408479733782469L,
5657955850064197540L,
8421466575550825493L,
1500634080278557638L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.UInt64[4]
{
3007509310035547855L,
4239860820895070369L,
2779025676856988787L,
8558059703734343077L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6927353450443405115L,
7444674558081543432L,
8603682781898878130L,
8913238449622433851L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt64[4]
{
223951664443105864L,
1618529625389965574L,
5011019365419894832L,
6907040216443547333L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt64[3]
{
8917692039666552284L,
3369794551634352030L,
6319354222719863297L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5232029179820296625L,
5052762407377134676L,
2988001999209085887L,
2007931723718804321L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 27,
    Value = 
new System.UInt64[4]
{
182402359510759898L,
208405653990177866L,
487470650188270840L,
7501633822514671251L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.UInt64[4]
{
8670218599092183238L,
2194377078874501336L,
6593540637442899193L,
5624808007725564661L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
4758577437523178499L,
389115977230401270L,
1470770464943589218L,
2326878168351053954L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 31,
    Value = 
new System.UInt64[4]
{
9194218014883965037L,
7656633347240906695L,
3291505884475202056L,
5508164908385315368L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt64[4]
{
1426649762168479716L,
3945513566566340414L,
2931455571418276440L,
6819533280005469410L,
},
    NullableValue = 
new System.UInt64[3]
{
4865070597704086036L,
8075114248780556366L,
1431686896104778967L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 38,
    Value = 
new System.UInt64[4]
{
7256231309500602212L,
5225418649957553617L,
8487304694293116668L,
741650981020132774L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.UInt64[4]
{
6554617042969490136L,
44326662881535776L,
1255560522056725823L,
6810057108490085785L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6789875504246796748L,
3063541432615619053L,
5628567012857867865L,
1168326072199715736L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 47,
    Value = 
new System.UInt64[3]
{
6869264286556047293L,
1039730839013780261L,
5165244258094395024L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
752377517344215625L,
1973270670355011780L,
3000044286852633176L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3638022881825849680L,
3058269400956359953L,
4847112660406441699L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt64[4]
{
462911402223470185L,
5232384237033708341L,
4169076352507222941L,
4436240954122575242L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.UInt64[4]
{
7905941836643238692L,
1610723508216435793L,
6723665779355565415L,
4152624382984224289L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
3038320135842529650L,
6059529778056666282L,
7035646178577430493L,
8023699634381353327L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
4554673074714449959L,
5752171824333628530L,
2006278058378868433L,
5207343200806495549L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 51,
    Value = 
new System.UInt64[4]
{
4166661206151283706L,
5384630837983708455L,
3812916930430824512L,
5725624288966713011L,
},
    NullableValue = 
new System.UInt64[4]
{
143175638794997468L,
585364989452128320L,
8104588991887877958L,
7896040078550589236L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 56,
    Value = 
new System.UInt64[3]
{
5396427420167330505L,
333220058309654830L,
3084431276092128307L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt64[4]
{
5361451348287358725L,
5662810521167804369L,
2620192899488176162L,
4428340121822060173L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 65,
    Value = 
new System.UInt64[3]
{
7983179927301506339L,
712529514382955132L,
5574706529610082569L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.UInt64[4]
{
5107682686274257035L,
8131842879361678389L,
8077122116650869371L,
299011213263525882L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
8968104640561304174L,
897097900603378788L,
628531221528237822L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt64[4]
{
3967928960147694114L,
7808160680962862746L,
7377982697131705014L,
6888076933613112554L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.UInt64[4]
{
2058742833510705186L,
2366018239191581230L,
1322597747652664100L,
5734420104426511195L,
},
    NullableValue = 
new System.UInt64[4]
{
6021125127663830567L,
3281198803440820686L,
7020770647167928913L,
5488085472399103613L,
},
},
    NullableValue = 
new System.UInt64[3]
{
5286340712763644490L,
304600863444376835L,
8905712645121942147L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt64[4]
{
1139887475059230131L,
2014397147792778588L,
7463753345280523731L,
3635722042465381125L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt64[3]
{
7311849487745168966L,
1946505879933007388L,
5863920694181542236L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7277274388847004819L,
4791957104418560288L,
4161780852919850900L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt64[3]
{
869039220572518010L,
4737904443752537271L,
2614123957701354506L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.UInt64[3]
{
5122178576065689860L,
7415716266247926402L,
3767146419996501423L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt64[3]
{
8208471305610684328L,
3299915174140574935L,
4607961185156445967L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt64[3]
{
2007880676977546747L,
5066172519163062626L,
8249892811288216529L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 93,
    Value = 
new System.UInt64[4]
{
1327460825436072679L,
4906817085274360667L,
2906372558423289347L,
5792322830444692687L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt64[3]
{
5914782838121604797L,
6860040600459125112L,
2176877403270188221L,
},
    NullableValue = 
new System.UInt64[3]
{
4248015696347062357L,
3030937143356193295L,
7840297984473088277L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8245860192840560110L,
5129174839850528698L,
1078316548884724283L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 101,
    Value = 
new System.UInt64[3]
{
8764305212470965591L,
2479067873217997160L,
6782412459736806462L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt64[4]
{
5865825843375284974L,
8242296149558456104L,
8496510269735113951L,
6156452322128029724L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt64[4]
{
6589422136964329430L,
6974755201593392348L,
1740922668482732288L,
8907157373733462439L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt64[3]
{
985675101288353773L,
7526825126725225481L,
7909521346956983528L,
},
    NullableValue = 
new System.UInt64[4]
{
4085864130985374455L,
1703331770347020931L,
2193206217058553043L,
6572323333008365666L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt64[3]
{
3727325837175171714L,
8322511365468768958L,
4528378557627167773L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.UInt64[4]
{
22613527992332215L,
4114987550579303104L,
676856799828512333L,
2615191943984948716L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
2876090274658291032L,
7220591522127885886L,
3138327682181728681L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt64[4]
{
8171865680304069741L,
2520435856290393864L,
941465864273145713L,
671020506006021636L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt64[3]
{
7735938400923530236L,
1384985369548596758L,
1060358441431352239L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 124,
    Value = 
new System.UInt64[3]
{
9156813472528458417L,
7431487285208155335L,
5511229343358138596L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt64[4]
{
2844249539590612757L,
782125948665278868L,
4794305465704818250L,
5174112951086061063L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5663170129246801108L,
2146241747668468721L,
4309432659971485925L,
1536877569155641397L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 132,
    Value = 
new System.UInt64[3]
{
424697398428445425L,
5481352642646286485L,
2320058953087514997L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.UInt64[3]
{
3895113090878116388L,
1734360481864576081L,
1570879076938304193L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
916926640134724374L,
3862022123961223205L,
6877094660913186190L,
438171801285481202L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 140,
    Value = 
new System.UInt64[4]
{
8098213776341742239L,
8311084304779779550L,
205072197276151141L,
3235907079223406833L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt64[3]
{
6623595969501879983L,
5190270839624544703L,
7637111315945918908L,
},
    NullableValue = 
new System.UInt64[3]
{
5048255151206196229L,
391523458220078692L,
8510205328367710521L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5435967058821976814L,
929487890615411792L,
1118677020816692006L,
8470198024686189803L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 144,
    Value = 
new System.UInt64[4]
{
3252941140175535360L,
5253671279002905740L,
4301029377173797015L,
2158860520080190106L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt64[4]
{
517631463693998779L,
2472227612980063587L,
6571102490178371785L,
972545653024761326L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
8208089644947894264L,
5201130538362701633L,
7634656004943155525L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 153,
    Value = 
new System.UInt64[3]
{
819967963097770491L,
6039003871237755184L,
3171622563802261235L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.UInt64[3]
{
2678513848786078659L,
2133514074840482547L,
4723048959649591568L,
},
    NullableValue = 
new System.UInt64[3]
{
1707419618911628554L,
5122750940266567300L,
7397725921569633802L,
},
},
    NullableValue = 
new System.UInt64[4]
{
205198337104082548L,
2587096013147531474L,
2200289083009968708L,
8549810868048228286L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 155,
    Value = 
new System.UInt64[4]
{
6848645667169058382L,
404993914138747923L,
2061652534835400178L,
8046864133000479222L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 142,
    Value = 
new System.UInt64[4]
{
1488658446781682503L,
6165880618552941828L,
7947988208124652397L,
8492819256984680226L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt64[4]
{
1799783880000045531L,
3432066657182670985L,
4598893926185932561L,
3629968869003000629L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 151,
    Value = 
new System.UInt64[3]
{
7629807962041033318L,
5898536262747791645L,
79494670305679395L,
},
    NullableValue = 
new System.UInt64[4]
{
7536548852634287532L,
693269603274022402L,
7130748067538512231L,
5049537510703418740L,
},
},
    NullableValue = 
new System.UInt64[3]
{
7313476611340278128L,
1954089167986548856L,
2996303326838645308L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 160,
    Value = 
new System.UInt64[4]
{
1116174058912200098L,
6876386150158770353L,
2301286393263025490L,
7436840660861306658L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt64[4]
{
2521026173586348774L,
6176651541171824030L,
5193628182590083841L,
8371336691184406780L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 169,
    Value = 
new System.UInt64[3]
{
3590071811604831163L,
4112553754955773014L,
704796544058559947L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.UInt64[3]
{
2620274627214567646L,
2092268574870719824L,
5710930468862070801L,
},
    NullableValue = 
new System.UInt64[4]
{
5052258626998392143L,
7542893622737745119L,
6421622709707536250L,
9221108518415611763L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 176,
    Value = 
new System.UInt64[3]
{
8971521608122476487L,
7408718299437365265L,
7472595338727409301L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.UInt64[4]
{
8289235863890198046L,
2841566734525482634L,
7077258488752624994L,
5614728373154488813L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 185,
    Value = 
new System.UInt64[3]
{
9080559491811933834L,
4682028405601600036L,
717967765274774788L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 173,
    Value = 
new System.UInt64[3]
{
3521685875005423644L,
3672988891658097187L,
388468002820426381L,
},
    NullableValue = 
new System.UInt64[3]
{
632261884973949288L,
8592262091106483914L,
3613415361475932562L,
},
},
    NullableValue = 
new System.UInt64[3]
{
3813449897825210918L,
5192063231555393723L,
333652443300748405L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 189,
    Value = 
new System.UInt64[4]
{
8656406263098852684L,
1529172650434374362L,
4904464305584516817L,
6429242618774064795L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 181,
    Value = 
new System.UInt64[4]
{
1125341644697050609L,
3738844590710550559L,
5532529660402992117L,
181657973020945431L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 195,
    Value = 
new System.UInt64[4]
{
1315145940041032593L,
4465400171466820372L,
8511023453375532809L,
8387321758454328560L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 187,
    Value = 
new System.UInt64[3]
{
2550390583968957573L,
2359732420180659438L,
6464170695332467205L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1303338074174434916L,
5574657287079713985L,
3624361771066258460L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 197,
    Value = 
new System.UInt64[3]
{
3016267596309863029L,
4628848516983465722L,
7394023403789227005L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 192,
    Value = 
new System.UInt64[3]
{
4953825436077882458L,
1767999922582338136L,
1288318358314879824L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
4409593185902618792L,
6955299793940301266L,
6435554037764120482L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd1e1m(
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
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    await ((IUInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    var models = await ((IUInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

