

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
    internal partial interface IInt64MArrayArrayInt64
    {
    }
    
    internal partial class Int64MArrayArrayInt64 : IInt64MArrayArrayInt64
    {


#region TestData

        private readonly Int64ArrayInt64E1M[] _testData = new Int64ArrayInt64E1M[]
        {
            new Int64ArrayInt64E1M
{
    Id = 6,
    Value = 
new System.Int64[4]
{
966988836699778952L,
961238804322796990L,
6129661826457163004L,
5522693221675313020L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 1,
    Value = 
new System.Int64[3]
{
1770754657751895291L,
5414653572578893691L,
5558472416125480335L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4440747733849314320L,
9205648968555631943L,
549395542692283190L,
8780286048822315271L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 15,
    Value = 
new System.Int64[4]
{
7679703039735740158L,
9122636375201638009L,
7818328438291112763L,
4120954796682962667L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 9,
    Value = 
new System.Int64[4]
{
7484001447761586802L,
9089597767181954172L,
4829182224807136821L,
7511672278074596138L,
},
    NullableValue = 
new System.Int64[3]
{
482221354464218041L,
4399307217792087898L,
6965917241416042520L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
8721527620232632149L,
8341962807843289091L,
7545895492649315199L,
159988787255257690L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 14,
    Value = 
new System.Int64[3]
{
1419812898648106323L,
4286797481516187012L,
3186111982692877011L,
},
    NullableValue = 
new System.Int64[4]
{
1948494797602246719L,
7140344141330674008L,
4941507539773223556L,
2974607888295141820L,
},
},
    NullableValue = 
new System.Int64[4]
{
2819240293204125330L,
6117462832068115404L,
8507498931184615587L,
1380002844041113054L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 25,
    Value = 
new System.Int64[4]
{
3288847300503519361L,
5573298914750121315L,
1250116879609375017L,
1542884356396660591L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 20,
    Value = 
new System.Int64[3]
{
1778499093055434257L,
3872274835820073256L,
4340140621254079909L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
400174976673600809L,
2324410158713046538L,
8786054428841025441L,
2240078114115123914L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 23,
    Value = 
new System.Int64[4]
{
8254370638668681000L,
7285868318967688124L,
5604340944971820381L,
3153706222521934203L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3030555598208205538L,
5153944661822953042L,
527625614976876428L,
6170066992062510577L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 39,
    Value = 
new System.Int64[3]
{
7380056959824681482L,
2372764032370674158L,
4130866133369770355L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 31,
    Value = 
new System.Int64[4]
{
7467725479666889397L,
6990167941697165873L,
8127113833317609358L,
3588213305952621502L,
},
    NullableValue = 
new System.Int64[4]
{
8858294387292284195L,
1365624871108568456L,
165142523712809718L,
6242293301332467088L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
7905584492744768994L,
3546660045622840578L,
6358592201630419925L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 36,
    Value = 
new System.Int64[4]
{
3163210964653455649L,
3722690457092903915L,
7667248461442484909L,
4891351874711102787L,
},
    NullableValue = 
new System.Int64[3]
{
1653476804735860761L,
5842904364487892401L,
6969081088610998987L,
},
},
    NullableValue = 
new System.Int64[4]
{
2148332827561465523L,
874598499213089738L,
2886743583324266416L,
97277138217393407L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
5861806388855402774L,
4483422307879133402L,
2547956862053399214L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
2534136718271383483L,
2965522424494406384L,
2178911191463606488L,
6226971807788704184L,
},
    NullableValue = 
new System.Int64[3]
{
5865284580600652715L,
9016156284480718160L,
1408288946984697053L,
},
},
    NullableValue = 
new System.Int64[4]
{
1459936229291448620L,
9013498580032890664L,
6070967740109174574L,
3830289687464691431L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 52,
    Value = 
new System.Int64[4]
{
8427030720106768637L,
6319423590999666531L,
4878908660731179587L,
1831923073168241063L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 44,
    Value = 
new System.Int64[4]
{
3974350790141309138L,
4306589079062255294L,
6324510753912232484L,
135198202927468045L,
},
    NullableValue = 
new System.Int64[3]
{
7965931718507524208L,
7607910586454075664L,
2161355202357711295L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 58,
    Value = 
new System.Int64[3]
{
2766862050943137466L,
13173883086444033L,
7140487212878093083L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 53,
    Value = 
new System.Int64[4]
{
2107117811823357332L,
5852291080657957002L,
2746474632492792723L,
1532617723617536108L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1392834583352841085L,
3133775006772970753L,
4451533199875124307L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 67,
    Value = 
new System.Int64[4]
{
7294986107474711616L,
7444797587001839737L,
8866937445631038307L,
7999655560952434233L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 61,
    Value = 
new System.Int64[4]
{
364678566064746548L,
3596333492271005174L,
3663846556037043073L,
3019120113077385713L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4136159480214230844L,
4727531627619836402L,
179501884474602252L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 72,
    Value = 
new System.Int64[3]
{
2665178032163517921L,
8596198963849862979L,
65137167732880146L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 69,
    Value = 
new System.Int64[4]
{
6789887934718142869L,
5828404658553354800L,
5487207673908846613L,
6845178503303639051L,
},
    NullableValue = 
new System.Int64[3]
{
111251772816336815L,
8364136718795052695L,
2279720299862123986L,
},
},
    NullableValue = 
new System.Int64[4]
{
1143362099317618257L,
4726144423617764550L,
3717819456795880488L,
1416452691547944066L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 76,
    Value = 
new System.Int64[3]
{
533273634191528878L,
5817637354824578323L,
1322702385442058976L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 71,
    Value = 
new System.Int64[3]
{
7455956271606888948L,
6348534361107367287L,
8731816039153697175L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6035716899740335186L,
5721223658505121495L,
4361394472733588844L,
7327671306384940778L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 84,
    Value = 
new System.Int64[4]
{
4006085319148496944L,
5422602773268916769L,
7726710418821041887L,
3785288932285433282L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 78,
    Value = 
new System.Int64[3]
{
998735296196718130L,
7452223548650028009L,
1488454522381407096L,
},
    NullableValue = 
new System.Int64[3]
{
8813067847193472243L,
5986823460060279753L,
249795154674214038L,
},
},
    NullableValue = 
new System.Int64[3]
{
2625448102646406829L,
9134621893207917109L,
1343769545979531708L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 91,
    Value = 
new System.Int64[3]
{
1512770862406968283L,
2936682087060421536L,
7826294111443132906L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 85,
    Value = 
new System.Int64[4]
{
1015600484132595747L,
1339761167285341533L,
5325155495355107065L,
7596507622108748488L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 97,
    Value = 
new System.Int64[4]
{
4230936996005918244L,
1887986566878771629L,
3444648427796800166L,
1953087535212679434L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 92,
    Value = 
new System.Int64[3]
{
4155567109328239936L,
8365374356943337637L,
8722502321773416597L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4192563033955571899L,
1989175656291203493L,
2707422083668705167L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 99,
    Value = 
new System.Int64[3]
{
8657682785260122563L,
5954134607047217674L,
1995401962133974743L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 96,
    Value = 
new System.Int64[3]
{
8344785450359253695L,
6684416162120379233L,
3625431229518397854L,
},
    NullableValue = 
new System.Int64[4]
{
3533345834434139031L,
3527347890800405643L,
4917936609423448983L,
1929915241727350851L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
5840011863460615140L,
258311573381804873L,
3254441417532344738L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 101,
    Value = 
new System.Int64[4]
{
8333167972531981372L,
4231266002738960618L,
5207088858386072209L,
3750752156995005583L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
306456161453886765L,
6677270106886805540L,
2765788537159083659L,
8804822951930663357L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 112,
    Value = 
new System.Int64[4]
{
580640604469873151L,
1608045077145515921L,
7003269739158166764L,
2319096194375674602L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 110,
    Value = 
new System.Int64[3]
{
3643067379251814040L,
4871388792974439582L,
2588418433671871775L,
},
    NullableValue = 
new System.Int64[4]
{
2155828653789003983L,
1796825733355407648L,
1517083412248097160L,
8184847231671920108L,
},
},
    NullableValue = 
new System.Int64[3]
{
3465175776270326431L,
4817375272177690978L,
7504929235743667856L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 114,
    Value = 
new System.Int64[4]
{
275685162271405387L,
5219839495027832465L,
5688840486438659676L,
8357673500230465786L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 117,
    Value = 
new System.Int64[4]
{
8589077872977722710L,
9092483610693632674L,
4371529044295585982L,
998678489819569822L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5475897815828398250L,
7216228941392526509L,
558207036492351688L,
2280608922477068129L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
3788735601617124156L,
8412542873992871298L,
6040605505144706731L,
1794053624793908524L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 118,
    Value = 
new System.Int64[3]
{
3796917594784470755L,
2914399209469452478L,
675134948727527768L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 129,
    Value = 
new System.Int64[4]
{
8586478957209946317L,
8962544054785851321L,
8902176012745468139L,
2857684489384402459L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 121,
    Value = 
new System.Int64[3]
{
8802340323174337653L,
2774298077486103274L,
7243470084296013431L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 132,
    Value = 
new System.Int64[3]
{
4360669954862662286L,
3792096316550018286L,
399370856946050614L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 123,
    Value = 
new System.Int64[3]
{
5331904427570269684L,
3891782248975288176L,
1108601873716659311L,
},
    NullableValue = 
new System.Int64[4]
{
190592106005314894L,
1340424615613973787L,
3247635052495248644L,
7889180007418492257L,
},
},
    NullableValue = 
new System.Int64[4]
{
731925634543490055L,
3538741489531397691L,
6543146841588941461L,
3021100267547320954L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 141,
    Value = 
new System.Int64[3]
{
5527580760008355407L,
4923725702761018496L,
4036019784748260901L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 129,
    Value = 
new System.Int64[3]
{
8059770237034824466L,
8934659686741548846L,
795382888261396400L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 150,
    Value = 
new System.Int64[4]
{
4233431104374555652L,
4556818783890281133L,
3705877550800104861L,
1166156722245897568L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 137,
    Value = 
new System.Int64[4]
{
4941537110486210342L,
1115829454796766524L,
1075861114590394536L,
8428431548839550577L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
8193867637192866513L,
4215434819877807214L,
2780014906124396622L,
7310449060660258525L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 146,
    Value = 
new System.Int64[3]
{
2701139255949285836L,
2710716175759722889L,
2380038036646097849L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6326836947904915414L,
290536824220326461L,
6929642467061754639L,
3538422078585799679L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 164,
    Value = 
new System.Int64[4]
{
3903439077529869550L,
5281674958201021535L,
2858736027823972443L,
5535936784566130392L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 152,
    Value = 
new System.Int64[3]
{
7216444590989266993L,
5376307941221639798L,
7818767857198958680L,
},
    NullableValue = 
new System.Int64[3]
{
6304334530789134817L,
207618826440140675L,
1460573658196250967L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 173,
    Value = 
new System.Int64[4]
{
8429690548570175295L,
2700457466895204514L,
4012555948742819123L,
6042463677621925734L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 156,
    Value = 
new System.Int64[3]
{
6425597776409916919L,
3778592798221197228L,
3979504016388315040L,
},
    NullableValue = 
new System.Int64[3]
{
8836992313600466416L,
346443442422070584L,
8646602342783304079L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 181,
    Value = 
new System.Int64[3]
{
700187487121305714L,
1910231743226837512L,
3486616535280824962L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 164,
    Value = 
new System.Int64[4]
{
6265024226942754703L,
9043618096890677200L,
281700554257644198L,
7486577205831882919L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 182,
    Value = 
new System.Int64[4]
{
5895285604872636291L,
5911637340760452501L,
898401725223772701L,
7674002196109074422L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 171,
    Value = 
new System.Int64[3]
{
3499629769094787332L,
5137264247484336466L,
1551978606475865353L,
},
    NullableValue = 
new System.Int64[3]
{
4693368996129634648L,
4713607082220369114L,
3157469538616403644L,
},
},
    NullableValue = 
new System.Int64[4]
{
6196154971836426601L,
2445015859616910695L,
5558269479962155490L,
3159440114939776655L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 190,
    Value = 
new System.Int64[4]
{
7064689855816548276L,
7463860132386921901L,
4622099489834499267L,
1125810260745402870L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 177,
    Value = 
new System.Int64[4]
{
2201753735873506579L,
5697561367952404773L,
2728904951861700454L,
1912397451300264877L,
},
    NullableValue = 
new System.Int64[4]
{
4663940620723684487L,
7126806318376296638L,
5751178519010908980L,
1811420786582274317L,
},
},
    NullableValue = 
new System.Int64[3]
{
8439659905969146705L,
3867350827232039582L,
1483664782741171998L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 193,
    Value = 
new System.Int64[3]
{
390184450563560761L,
8514138463284993450L,
5265864411004572548L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 182,
    Value = 
new System.Int64[4]
{
4152693817719673572L,
821918291248387442L,
2409563186517577137L,
5196086368958894377L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 197,
    Value = 
new System.Int64[3]
{
3910731246310499616L,
987231692044967559L,
776798284479807023L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 188,
    Value = 
new System.Int64[3]
{
3225850795575352241L,
5758833089902404604L,
4148383379018311920L,
},
    NullableValue = 
new System.Int64[4]
{
6964643295631961989L,
4189518653388360611L,
4782205060854291213L,
3810480219759686878L,
},
},
    NullableValue = 
new System.Int64[4]
{
5930581182196897589L,
95873258620271245L,
4722654852526131364L,
4730602987096305919L,
},
},
            new Int64ArrayInt64E1M
{
    Id = 204,
    Value = 
new System.Int64[3]
{
7110212967190990239L,
6920220151754285062L,
50457763661890296L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 192,
    Value = 
new System.Int64[4]
{
8330614460249531505L,
269203143610981547L,
3304631420914370247L,
580544457995245739L,
},
    NullableValue = 
new System.Int64[3]
{
8882352643414844278L,
6003017149706372918L,
5282312398198247521L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt64E1M
{
    Id = 206,
    Value = 
new System.Int64[4]
{
2960579787702789396L,
3844388675524916448L,
4434097435592589305L,
2935636552617992345L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 194,
    Value = 
new System.Int64[4]
{
7086830701533483730L,
621946045872796956L,
6563350299825256073L,
7485030027823745534L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1758492452243152786L,
8079485436561147900L,
1490117095641242102L,
7698748820063929721L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64arrayint64e1m(
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
            asPartInterface: typeof(IInt64MArrayArrayInt64)),
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
                    await ((IInt64MArrayArrayInt64)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayArrayInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.int64arrayint64e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64ArrayInt64E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayArrayInt64)),
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
                    var models = await ((IInt64MArrayArrayInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayInt64E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayArrayInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

