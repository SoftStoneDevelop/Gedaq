

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
    internal partial interface IInt64MArraybigintMMArrayD2
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD2 : IInt64MArraybigintMMArrayD2
    {


#region TestData

        private readonly Int64bigintMMArrayD2E1M[] _testData = new Int64bigintMMArrayD2E1M[]
        {
            new Int64bigintMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Int64[,] { { 4833032317555704434L, 7048357201262692198L, }, { 3566309182749922543L, 2863132612767378243L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6070060803418502816L, 5799605955189806208L, }, { 3062657883377164316L, 4347564287247030958L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int64[,] { { 5121386000035502309L, 2805676532576425096L, }, { 4283552381700044621L, 7624187283726298859L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int64[,] { { 7875186725438624170L, 8691278940522402364L, }, { 6854022298908327814L, 6029162611468084045L, }, },
    NullableValue = 
new System.Int64[,] { { 1687511926015807053L, 7537143132320511439L, }, { 7440035290568395993L, 6562970079571020370L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Int64[,] { { 7205898145840967047L, 1992356057675594731L, }, { 4977907606833587289L, 8540654032683855934L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7687237700575590207L, 5934986719012602773L, }, { 1259771529215614976L, 4935382673383179559L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Int64[,] { { 4003739828581323672L, 3143470319532055107L, }, { 1279229526005943139L, 8490352530860466848L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int64[,] { { 1878440597839032779L, 1802851336372143155L, }, { 3119684466895366566L, 1371261722169838807L, }, },
    NullableValue = 
new System.Int64[,] { { 5540932863225689255L, 2664048532062357543L, }, { 8704253443588096323L, 2253120376264553708L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6040458356816992841L, 4123848385930194944L, }, { 7533533516932629489L, 4418104777971961360L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int64[,] { { 1572904473236662980L, 4549097804325316565L, }, { 3862214098577516367L, 8687940086722271642L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int64[,] { { 100100171528496667L, 2000663048898932626L, }, { 5371577516492009687L, 5618910832071141164L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int64[,] { { 6450565606490656264L, 2790466135347159386L, }, { 9176750601576549004L, 6275772059750999635L, }, },
    NullableValue = 
new System.Int64[,] { { 31008230151832179L, 7112849127725847176L, }, { 9143903275804440926L, 4364639432987446675L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5892267848215492512L, 2707751257211793745L, }, { 3341451737978419686L, 8653955397893303793L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int64[,] { { 2253598517047157864L, 4561050442409853966L, }, { 520809611661534784L, 4804931380239467814L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3809037017370815132L, 8947811121158507557L, }, { 2388440653207595864L, 3973913768191955964L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int64[,] { { 6665782569918832332L, 3329031772786174712L, }, { 4933146224963573294L, 1688301230127805427L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int64[,] { { 1341281982483526224L, 8049170257748522L, }, { 8326741650055213903L, 3838240787815026073L, }, },
    NullableValue = 
new System.Int64[,] { { 2465735714096148829L, 8144156906128681474L, }, { 4315007033894630829L, 5848256173585364751L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2767289889572542776L, 2107478843307728383L, }, { 1729201009049114532L, 756382644422003640L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int64[,] { { 2557353314861854145L, 8299932784021529340L, }, { 2520458010971853188L, 4582488844235902280L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2846739283542906383L, 5688512437417541367L, }, { 5638631365049740061L, 2666799263455984536L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int64[,] { { 2616414129968981041L, 7775936351865926885L, }, { 3241264331115556584L, 6948781576878220550L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Int64[,] { { 7983762833506752471L, 286191840582189115L, }, { 4621845924584058637L, 5188782610516671896L, }, },
    NullableValue = 
new System.Int64[,] { { 3587457352284546181L, 4565635838560546421L, }, { 6289760191802301651L, 8172961515567361185L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Int64[,] { { 7321321839251480782L, 56416433811431601L, }, { 7710245302489263634L, 3849041395623492064L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 8780738419584604749L, 266705875768484074L, }, { 5803242125231731995L, 6889829680660062602L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int64[,] { { 1187285425008453357L, 5780856250934305858L, }, { 5032237106255263876L, 1424379586997017527L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int64[,] { { 739589696676641494L, 4682269398212719459L, }, { 2465937406467581006L, 7537926469227461700L, }, },
    NullableValue = 
new System.Int64[,] { { 638741538848594387L, 3034085741238329768L, }, { 700124472769175101L, 4655079829034677228L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Int64[,] { { 4017585067801744678L, 2587704358724379557L, }, { 7064617042091217575L, 2814852949685683611L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3232728908431702345L, 155924417877740806L, }, { 5747012453070420757L, 4029453196808259358L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int64[,] { { 5788827224941881552L, 9060610942759744950L, }, { 7699543335701053648L, 2849349367128616151L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Int64[,] { { 4897329266513308630L, 3917949437201007098L, }, { 1570926746636743253L, 1091828220938644709L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8329045158746934655L, 8333540237613400557L, }, { 1811855951471623272L, 3748105120351854907L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int64[,] { { 5811806251602713443L, 4831934774682609561L, }, { 3636189083557180926L, 3693162825546533867L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 5844699053523576064L, 5317958012047963485L, }, { 8183786656791090573L, 1904524591743588021L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int64[,] { { 2954915585183518359L, 1463883800386988616L, }, { 6434593847669421638L, 8439500484122437935L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 88494772944224866L, 1135272149886785515L, }, { 5751706415924683887L, 4403338290340438330L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6199554073026137018L, 7544818881284298545L, }, { 857453294192700810L, 5923436184858178141L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Int64[,] { { 3221142894633194189L, 4814524798825749123L, }, { 2000015337233611132L, 8784030689268710177L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 5152658726807586323L, 2191523410437839334L, }, { 1387521224479872647L, 314175139073849237L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Int64[,] { { 2726231535020982961L, 1175729596215798393L, }, { 7397544444678404279L, 7418338802927284923L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int64[,] { { 6617597824529050521L, 7432890656162116319L, }, { 7602059637384028943L, 304718130165679661L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2687525223224599168L, 5638132721358092537L, }, { 638067516973886087L, 3912919517432329393L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int64[,] { { 8121888842353026823L, 4392874480362017409L, }, { 4301008517091332473L, 7088940874975482622L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int64[,] { { 8313060465077914850L, 4694703461796695628L, }, { 8705156504151758250L, 6559018857717384774L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int64[,] { { 1837265430039274807L, 4444292869152130883L, }, { 4944016191497878096L, 8607152926610480028L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8942840318244406454L, 6579086809535538264L, }, { 8087973240893661918L, 586610319173394841L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int64[,] { { 173529029319544975L, 5785257883872026487L, }, { 1326823628855814037L, 696725405986506043L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int64[,] { { 8151857517695227973L, 6982346474763026929L, }, { 8087072552384980233L, 9172060626891035000L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int64[,] { { 680847215867289950L, 536119947236896779L, }, { 1362568982456441912L, 8272915697484049371L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4115615492489154033L, 4347838363720402599L, }, { 2144373420120215180L, 6190577287341168820L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Int64[,] { { 508391571524292599L, 7653927599847111098L, }, { 1644104763385219654L, 9084239017315272416L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3119311270766948635L, 2351710684749245245L, }, { 8366231560623659351L, 2461912173379704473L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int64[,] { { 7277294419602524494L, 2060740313013214710L, }, { 4701663522946777226L, 25063204552979671L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int64[,] { { 1166120721546021020L, 4208784710945009660L, }, { 2853134187748545948L, 9000637370077921909L, }, },
    NullableValue = 
new System.Int64[,] { { 275153224829939678L, 7462051946033326503L, }, { 2629091850560449499L, 4825845193180922940L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2046841982485549997L, 2022226622331976420L, }, { 8541989058772819301L, 4077933494843020474L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Int64[,] { { 4340002827379257322L, 6950470140534415221L, }, { 5258694195343939100L, 8835755098151516112L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int64[,] { { 1790738906266813947L, 8457644062374731938L, }, { 3854383003830012185L, 8652137425224418874L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int64[,] { { 286411865166220554L, 2612159636496542511L, }, { 4899264769271180206L, 8778974935550353484L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 940578595131053459L, 5062383777180180474L, }, { 6281847349352352417L, 3972656457806587484L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Int64[,] { { 150862016163093947L, 1965263067106504930L, }, { 4102904562053771466L, 5344761914627518103L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 7319247251865478453L, 8447113436044828238L, }, { 5358188850291147981L, 7369933135067238645L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int64[,] { { 2621240040584546833L, 1777520199582624372L, }, { 3926577381155909320L, 59546575458651725L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 3979914576040381888L, 5128348301597166257L, }, { 5966777308872609498L, 5548673598947598940L, }, },
    NullableValue = 
new System.Int64[,] { { 3894655066790756823L, 565338472666422716L, }, { 8821927170905336175L, 834237934995031304L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6132136341815936087L, 1596884642250406653L, }, { 2612383405895876262L, 1567752017116832493L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 380107241358560138L, 6319658140510782897L, }, { 7847615967981797326L, 1192420607658108824L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 6904443944185601477L, 8415330128156697012L, }, { 4572118293078637322L, 511783031683843402L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int64[,] { { 4521456410363343269L, 3925207988780529253L, }, { 775972824291158630L, 1601063659341066286L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Int64[,] { { 1189562683676446678L, 6452318005973366091L, }, { 8878259744060782104L, 8683168591570966465L, }, },
    NullableValue = 
new System.Int64[,] { { 5800380907426452744L, 7469263840205260443L, }, { 8102437676202983114L, 7305294774596244953L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Int64[,] { { 2598440830629917709L, 1799989880221363035L, }, { 3043747393802964697L, 5336749679080732403L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int64[,] { { 1607270837027275547L, 1559746307216233789L, }, { 7238187349949598504L, 6848970993165069822L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int64[,] { { 5056544067032851718L, 1118807208528465068L, }, { 1572321616798072784L, 1289435079046405079L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 129012031511797742L, 1132335368605302005L, }, { 3191632800900836916L, 1241951358720946300L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int64[,] { { 6228817811704956743L, 5157768352989880660L, }, { 7274180201815230300L, 5333376909890356429L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Int64[,] { { 1727801613918564845L, 4915784242283930776L, }, { 2889063341593756782L, 5265438334523815156L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Int64[,] { { 8431061711134438344L, 1165004001449841483L, }, { 2887358449456003054L, 8123628263115955860L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Int64[,] { { 2518973197720295217L, 2309943193201118270L, }, { 3801705756915323216L, 2975860619889180982L, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 5892267848215492512L, 2707751257211793745L, }, { 3341451737978419686L, 8653955397893303793L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 3809037017370815132L, 8947811121158507557L, }, { 2388440653207595864L, 3973913768191955964L, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 2767289889572542776L, 2107478843307728383L, }, { 1729201009049114532L, 756382644422003640L, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                System.Int64[,] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 2846739283542906383L, 5688512437417541367L, }, { 5638631365049740061L, 2666799263455984536L, }, }));
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 8780738419584604749L, 266705875768484074L, }, { 5803242125231731995L, 6889829680660062602L, }, }));
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 137;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 137, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 173, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 168))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 146, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 168);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
FROM public.binary_int64bigintmmarrayd2e1m m
LEFT JOIN public.binary_int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI), typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                await ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

