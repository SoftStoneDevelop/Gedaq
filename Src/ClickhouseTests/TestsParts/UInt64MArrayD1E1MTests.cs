

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
    Id = 1,
    Value = 
new System.UInt64[4]
{
7361091376105027716L,
2457070242662330756L,
4501194741815646854L,
1526644110832036827L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt64[3]
{
4001215127201239323L,
2486398141832874402L,
4239787045614535503L,
},
    NullableValue = 
new System.UInt64[4]
{
5245873523856937682L,
5718413143398498847L,
6584457419415131741L,
2433338872852137366L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 5,
    Value = 
new System.UInt64[3]
{
7663987300937163167L,
5606358374510360751L,
3064765569892233927L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 17,
    Value = 
new System.UInt64[3]
{
5084770102617515980L,
8281824657038011939L,
1102725943934326127L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 13,
    Value = 
new System.UInt64[4]
{
2762219273751712154L,
6853831143807144451L,
3263994502829341272L,
2802533820738578004L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.UInt64[3]
{
3124028279364848205L,
530852717156864870L,
8563310106709690026L,
},
    NullableValue = 
new System.UInt64[4]
{
4663554674788766354L,
5714702303049744323L,
937513746114728443L,
8609710747957142120L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt64[3]
{
5338655130652856322L,
1435986208602571236L,
385307036759196088L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.UInt64[4]
{
357684480016371565L,
8139536666732822417L,
4796993967185597194L,
4486046578615317509L,
},
    NullableValue = 
new System.UInt64[3]
{
5421178709619221775L,
373619135039538637L,
5336509933343575480L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 21,
    Value = 
new System.UInt64[3]
{
1303079015316203725L,
6367143957564322821L,
2805804724658599416L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
1922688723131797623L,
810742585856625346L,
2464344164687308168L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8728826786206612335L,
793025306644499034L,
1291875072923633801L,
2495169819819373062L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt64[3]
{
6751938040716274528L,
2595840169152597140L,
5457321539583671130L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.UInt64[3]
{
5125209550520449959L,
5577290291135730277L,
5682589665195992544L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 31,
    Value = 
new System.UInt64[4]
{
439505069587740370L,
7747645659550907099L,
2295708490748443195L,
4509290564878837260L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 43,
    Value = 
new System.UInt64[3]
{
1152890237718702880L,
8325595841108241522L,
9052002380398990302L,
},
    NullableValue = 
new System.UInt64[4]
{
1807454211726174699L,
4123899748625552547L,
9028465421259739575L,
4485982594765431045L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7750246234305726895L,
3164674066228569185L,
2867084010738045583L,
8887968768089750600L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
8159178390973465762L,
172666115873041322L,
5310445610184511960L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt64[3]
{
3155249099217777809L,
562997878326918958L,
9113127851847882814L,
},
    NullableValue = 
new System.UInt64[4]
{
4728762158829135118L,
1214726333747666369L,
4031870297324565266L,
4124244054300827771L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt64[3]
{
5032245131976741421L,
119932116852292819L,
3541326350312553946L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt64[3]
{
6145325130385137264L,
2120583761027520667L,
897614385920233692L,
},
    NullableValue = 
new System.UInt64[3]
{
3621051503957274937L,
617675449728493381L,
8658418842679095961L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt64[3]
{
2310491269176218758L,
6192450357956913952L,
9124091358436568162L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.UInt64[4]
{
2697584409783386537L,
3409213286147279503L,
3018430257763073100L,
1660172605403248572L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 55,
    Value = 
new System.UInt64[3]
{
8577828337441421718L,
3228383225429943901L,
2520734699979178033L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.UInt64[4]
{
8432668238686555795L,
4171948826684284248L,
8726718772555465214L,
1032647127438933955L,
},
    NullableValue = 
new System.UInt64[3]
{
7184775026471727789L,
3208928556300829552L,
970812053857631945L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt64[3]
{
2604139038072514659L,
793591463735209921L,
2910015725151924733L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.UInt64[3]
{
7302797472835236619L,
8409952433621184865L,
4241385917304751956L,
},
    NullableValue = 
new System.UInt64[4]
{
3707160703444982764L,
6050600776067154057L,
559408996825885596L,
4389141848163445503L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 66,
    Value = 
new System.UInt64[4]
{
4240774517284601307L,
4097445174440782906L,
5319691700562479720L,
4854690931659626509L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.UInt64[3]
{
371269578555782358L,
7181265601466378231L,
6705194252740065513L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 73,
    Value = 
new System.UInt64[4]
{
5890521288530600474L,
7517867742166343884L,
8678953649609806363L,
8142461847318983908L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt64[4]
{
2370977956228690390L,
9137870167886565228L,
4522322811933253210L,
4260924232181695167L,
},
    NullableValue = 
new System.UInt64[3]
{
4316727054332209507L,
6268970394812693962L,
1585493735257166981L,
},
},
    NullableValue = 
new System.UInt64[4]
{
725841487402760926L,
1172387539298618210L,
4731497095831543732L,
780874262380011323L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 82,
    Value = 
new System.UInt64[3]
{
2185326860158328226L,
3745058192161485776L,
1196334856946833331L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.UInt64[3]
{
2933627504797937242L,
4165642182578856316L,
6807716483534091346L,
},
    NullableValue = 
new System.UInt64[4]
{
3502449158502483100L,
7769832064241866721L,
8472301683977046831L,
7336618002870914500L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt64[4]
{
2283112136798340713L,
3813675846701706800L,
2321758207355811384L,
6537734229505469870L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt64[3]
{
6618931036068487792L,
3391032147969756184L,
3484441339572778858L,
},
    NullableValue = 
new System.UInt64[3]
{
1714601198604648060L,
7990490486028826741L,
2554922803419918440L,
},
},
    NullableValue = 
new System.UInt64[4]
{
3619081559094956978L,
2369497560447238107L,
4787383974886679703L,
1638474896515399453L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt64[4]
{
746571624921138582L,
3194110742527530819L,
6599704927546850308L,
3442524015326962096L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt64[4]
{
7728228997374779902L,
9029747205244017914L,
2735605713138900964L,
3215404350055384032L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 100,
    Value = 
new System.UInt64[4]
{
2151903035137077179L,
2288046976543402132L,
7052987659450076647L,
3970615745215120115L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt64[4]
{
5914957421295969299L,
4017557258013798986L,
7891746011987516646L,
3727068599725733665L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
5245223747157376608L,
4758756246506408449L,
7908449955462049749L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 106,
    Value = 
new System.UInt64[4]
{
1922465815549462639L,
1281738221908871548L,
4202798268697610428L,
8346845614755833076L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.UInt64[4]
{
3763624476753216386L,
8864911217696188504L,
5190115771760609207L,
6060540854242837495L,
},
    NullableValue = 
new System.UInt64[3]
{
3396977156032148003L,
7277217033527708556L,
1351207298061070309L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt64[3]
{
5788022661514650754L,
2313434407779771348L,
708235235689837431L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 105,
    Value = 
new System.UInt64[4]
{
7853636634675820035L,
2036296290535542144L,
1693228957674876245L,
168326065506632179L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.UInt64[3]
{
3599275749564819440L,
2399834769026889001L,
5044384432262889454L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.UInt64[3]
{
2577789463254684080L,
6046050244093042670L,
76924421776196880L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt64[4]
{
434827594216127108L,
8816733360388440511L,
8289403507089294468L,
7583903953653264125L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt64[3]
{
5540060704941116942L,
7234955041432730103L,
746658272829995828L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3079208728637227945L,
8101253343424719431L,
2232533659040740212L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 126,
    Value = 
new System.UInt64[3]
{
7252843455985478989L,
5917452631119299684L,
2958817657038469825L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.UInt64[3]
{
7561717273335636278L,
181963031502243537L,
3454707244045320710L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 134,
    Value = 
new System.UInt64[3]
{
205384013180689199L,
1626576562446439751L,
8244730882857388300L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.UInt64[3]
{
5313845507322911594L,
4491842586029580928L,
6486364465752084598L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt64[4]
{
8630217988176410241L,
358734259102540027L,
8089332228381998121L,
4641659162143257124L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.UInt64[4]
{
4247843448318684820L,
4383203391138265237L,
2302950410536152781L,
1075805789262592719L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
5761415838086596311L,
5903939219853357225L,
2926409835436480871L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt64[3]
{
706749076487491453L,
7507988826515155271L,
153663363271272021L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.UInt64[3]
{
1066465688012125775L,
6850673720486487778L,
8541346853666184821L,
},
    NullableValue = 
new System.UInt64[3]
{
8999278004848564210L,
6882850124426967909L,
2711727683566238757L,
},
},
    NullableValue = 
new System.UInt64[3]
{
660209691641615012L,
3119120936884610209L,
2642635058974624369L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt64[3]
{
465120893564193624L,
2013429131985926723L,
8663248616165560543L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.UInt64[4]
{
4931174015936003969L,
2235762648610219571L,
5775615791042463224L,
5561527147702927382L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7639552117003901156L,
2788355387663660101L,
3305822816766124273L,
8764970756207199147L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt64[4]
{
4391313237584415995L,
3120988722814902986L,
2519458213566476980L,
8153448905829811776L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt64[3]
{
2008560793572910872L,
3092733175955544585L,
4477379679842358778L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 166,
    Value = 
new System.UInt64[3]
{
891371794220844971L,
1100584941438746229L,
9035312770275060872L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt64[3]
{
572265430234082059L,
9211237744771534678L,
4726452293459839684L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
2336484497987480976L,
871604096924331030L,
5582724126664043760L,
7615271523354150974L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 173,
    Value = 
new System.UInt64[3]
{
8737787130737890263L,
7009380387287629960L,
6506431308911106427L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt64[3]
{
144549617182786095L,
8750418672109304858L,
8488900583335544669L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 176,
    Value = 
new System.UInt64[3]
{
6550659103440774091L,
7314532472273377928L,
102194942611416614L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.UInt64[3]
{
1402508017417298387L,
3289548017252397423L,
5491159624494069481L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 180,
    Value = 
new System.UInt64[4]
{
7214260465733716607L,
3610412448479186572L,
3492660252730804455L,
1111783655481642060L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
5344049837263093945L,
600504729136994443L,
1176328673210175103L,
955809580850223569L,
},
    NullableValue = 
new System.UInt64[4]
{
8126563799242591078L,
4831305095160740150L,
5947051740018153605L,
3194835477482871346L,
},
},
    NullableValue = 
new System.UInt64[4]
{
8210912119328852932L,
7372607435601609943L,
999558024460694730L,
2319023071931325080L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 184,
    Value = 
new System.UInt64[3]
{
2484489934860677484L,
6071193599377564784L,
3020957385786188070L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 171,
    Value = 
new System.UInt64[3]
{
7373329987669101798L,
6855816088392096386L,
8679997652277896044L,
},
    NullableValue = 
new System.UInt64[3]
{
8732415960570903909L,
4882143949261351083L,
8895859125672724058L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 187,
    Value = 
new System.UInt64[3]
{
2918266253404284394L,
3109295287508422422L,
1208179160367555420L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 180,
    Value = 
new System.UInt64[4]
{
6851044817632018725L,
6996256966342666887L,
5597814830105363147L,
1037282110883605235L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3314609650570750934L,
5532683402531531156L,
3596048864881910597L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 189,
    Value = 
new System.UInt64[4]
{
7329820716356702822L,
6157988800368331177L,
8466618712013138912L,
2046715471009156633L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 184,
    Value = 
new System.UInt64[4]
{
4055158745558416041L,
4259011268053038458L,
2370533751255754213L,
7814596563343508586L,
},
    NullableValue = 
new System.UInt64[4]
{
3119010628620950175L,
3596434559778313273L,
2428748367925252662L,
5746169767942340373L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4836195240739314973L,
8658782438551357424L,
803596866944984686L,
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

