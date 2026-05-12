

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
    internal partial interface IInt64MArraybigintMMArrayD1
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD1 : IInt64MArraybigintMMArrayD1
    {


#region TestData

        private readonly Int64bigintMMArrayD1E1M[] _testData = new Int64bigintMMArrayD1E1M[]
        {
            new Int64bigintMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int64[4]
{
8804457211565543446L,
1957245313927990371L,
1283240237118202063L,
3581599056569715896L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
700104814565107456L,
3754000703408261096L,
7474794648975178496L,
2472926320939055205L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int64[3]
{
2928696162362115033L,
3794929666688290163L,
506105127729632332L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Int64[4]
{
630495416540050264L,
7022932683740389095L,
2449796320598823406L,
6695988435754423340L,
},
    NullableValue = 
new System.Int64[3]
{
730657114489820028L,
8659114492572171071L,
1018181822878404827L,
},
},
    NullableValue = 
new System.Int64[4]
{
7058410668492686408L,
951470243269112945L,
8106334418382249505L,
7676190596940662342L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
6373464995709168846L,
6981687752227740812L,
3828974204276415806L,
1078657155321229662L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[3]
{
4376466879602601645L,
5793937934050499485L,
2506714965511461260L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Int64[4]
{
2479175590599733725L,
1583383220079483124L,
8053522145468923797L,
1819023256870688007L,
},
    NullableValue = 
new System.Int64[4]
{
7484482581507741829L,
350233641806987611L,
8312504805755693478L,
4187235614151452076L,
},
},
    NullableValue = 
new System.Int64[3]
{
4751998281169551263L,
3426036539059759540L,
2690221461698629193L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int64[3]
{
1787764311583301803L,
355087748173557358L,
3988888594810356711L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int64[3]
{
2086082532516602343L,
3719629824872798235L,
3334776579519573101L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int64[3]
{
8009685552324238578L,
7465080542356281097L,
4551051385534919897L,
},
    NullableValue = 
new System.Int64[3]
{
4307454441831297307L,
8962035812658090988L,
6659357750461687998L,
},
},
    NullableValue = 
new System.Int64[3]
{
6273700291713773357L,
4259581288096336976L,
3921630898899026791L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
7595883488051200060L,
6439259713672582895L,
5637393114038718688L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
4145886804744909956L,
4160968366186515019L,
2133032883836418811L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int64[3]
{
5181445750806390881L,
5426829314694331726L,
6589362059814718119L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7337214294129065344L,
8025550926649418094L,
8516431703068353844L,
3845727062530848624L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Int64[3]
{
2585056243336061584L,
1970217984864413804L,
3140502271417249019L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
4935014677813407955L,
1624763686899031998L,
4462663325923942115L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int64[4]
{
6607883134245402980L,
5097539615325640743L,
7270737210379907010L,
1267862977384310000L,
},
    NullableValue = 
new System.Int64[4]
{
8695414487783100841L,
2241810156861001129L,
9128888991614160006L,
7995360614354466294L,
},
},
    NullableValue = 
new System.Int64[3]
{
5352037002013131837L,
4013630680716223950L,
6498592434413877343L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[3]
{
3216514891034179906L,
2596725893415476629L,
7231350783230009803L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int64[4]
{
5614371863368560112L,
1265085025507478569L,
8139689371373547321L,
141773220636924624L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int64[3]
{
630055826539599517L,
532176259970969551L,
6981677378192403309L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4936952078043174973L,
7592776746827854297L,
7771506962618433876L,
5356214565556712443L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
2847019817619441276L,
8254171188734671354L,
247117560570563050L,
84656639665515147L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3078550788135209802L,
6328339819904647723L,
1382033103081718921L,
198317605421593186L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int64[4]
{
6564863552389737241L,
8108519924399708645L,
695841966572593541L,
1048241994196125114L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int64[4]
{
6034522079847823844L,
7652744537320522495L,
7071081919077502080L,
2344486316337087799L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
359090435720134083L,
3366035655211099513L,
1005815243020698466L,
8859196955366402274L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
1062238521158631959L,
7247709655207921291L,
3270660599243333072L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3252542938124090110L,
7970745295276055302L,
979936244192086896L,
7044048611090090726L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int64[4]
{
3310263933080410683L,
5570234298565761542L,
805704998423282751L,
135069733593573927L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[3]
{
765995314322569597L,
3157971115013568692L,
8987076225680225832L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5270412230617187774L,
6289980774541571544L,
6480425301031669991L,
4662503642986139326L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int64[3]
{
5738093435589845953L,
5257617084075238079L,
6695421328842412067L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1776239912583664095L,
6833347898343132809L,
4379264673961814257L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int64[3]
{
2261704668613867700L,
8621777859227273731L,
4659607718866942184L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int64[4]
{
5637920570404863749L,
1882671265769247188L,
8270694464778425556L,
8644246085786651597L,
},
    NullableValue = 
new System.Int64[3]
{
2442478924588168596L,
5440864713083040376L,
5538976636032330917L,
},
},
    NullableValue = 
new System.Int64[4]
{
1826628560466614348L,
8285018446647092978L,
4979592074321413467L,
8379380510692775501L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Int64[3]
{
4906259162226985075L,
2053471658439301674L,
4038841489285567016L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3544719852699126990L,
892489956072918429L,
6830870019375676104L,
3276717547828111759L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[4]
{
8888894652655003934L,
4400674790491031893L,
8002047242596692560L,
3711032518240031446L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int64[3]
{
4628210497022604539L,
4607707124421242153L,
4887447450676505816L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7304540438405181757L,
6383556253901307508L,
4585615392666521394L,
3027674526804580390L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Int64[4]
{
6422366762279804462L,
1652429275856096853L,
535314883588401259L,
8191595385218261572L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int64[3]
{
4463030726114453044L,
312188584362350309L,
3844145264578099609L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int64[4]
{
6882544421081322794L,
3240895193656050496L,
3529062290766217933L,
4169875212994626383L,
},
    NullableValue = 
new System.Int64[4]
{
9205715853506465308L,
2244993040525467238L,
2509322271305812888L,
4826251618541157026L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
5939105310681900978L,
7691431583871704752L,
4347146228010599666L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int64[3]
{
3197968394649586743L,
3435443792276437010L,
2057201729344677865L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int64[3]
{
7854274301362298884L,
9136093321805025059L,
4898557305838859825L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Int64[3]
{
5918502600395314440L,
2089763872222280683L,
899437565964558854L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int64[4]
{
45376828054022117L,
4974755389527767347L,
8454849337491960427L,
5377407067355346489L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
508153697684390435L,
1080582956463962742L,
2167703420667923111L,
3504695892556523754L,
},
    NullableValue = 
new System.Int64[3]
{
3359860992484466750L,
7000822166764235411L,
7294139387656260778L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
7802166960493861676L,
1922041088725255485L,
714877860047204507L,
6976639535205616648L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int64[3]
{
1610515987897093987L,
7439159392442053582L,
4765648508205367199L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
4894809958501084682L,
886633018429992878L,
541355602016648137L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int64[4]
{
1163477792375369168L,
1427755212772448361L,
753727091476715827L,
2633956676849696416L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
7325005750626485438L,
7483047655205335571L,
32477381226903574L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int64[4]
{
8452972035217938031L,
4726347289053442844L,
7605790555345472103L,
5586971321329896776L,
},
    NullableValue = 
new System.Int64[3]
{
4757406132794681320L,
1015877762842381330L,
7748418292606913756L,
},
},
    NullableValue = 
new System.Int64[4]
{
5554903110062587413L,
5455129187093959425L,
1706831568207504640L,
7742328856860973245L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int64[3]
{
1295974304326314853L,
2959970229702518724L,
6554739644700448236L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2778440868792773211L,
3869740466653889637L,
643554227369444364L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Int64[4]
{
2358007488396889829L,
8369061603498464823L,
6960994960223903760L,
4291454116201516031L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int64[4]
{
7523471295312628971L,
185545600558682804L,
353642128393491052L,
3830230455996831737L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6756659640797688973L,
2544541017014074258L,
2282122130646234596L,
4445031301134905823L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
7820701685418546029L,
1779230407907688425L,
7130577336619377675L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
9118694773878893270L,
7302853822516486301L,
5323780495792891393L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Int64[3]
{
4265555619034087623L,
3193307041220268128L,
8307051703489533061L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int64[4]
{
536060891842263837L,
4415657131391938932L,
157008157293265602L,
5887510649388304427L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int64[3]
{
6324440212796824687L,
5096839522969073805L,
6363408996921166082L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6273700291713773357L,
4259581288096336976L,
3921630898899026791L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
7337214294129065344L,
8025550926649418094L,
8516431703068353844L,
3845727062530848624L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5352037002013131837L,
4013630680716223950L,
6498592434413877343L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4936952078043174973L,
7592776746827854297L,
7771506962618433876L,
5356214565556712443L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 15;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 34, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 80, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 128, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MI),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD1E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
FROM public.binary_int64bigintmmarrayd1e1m m
LEFT JOIN public.binary_int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI), typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                await ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

