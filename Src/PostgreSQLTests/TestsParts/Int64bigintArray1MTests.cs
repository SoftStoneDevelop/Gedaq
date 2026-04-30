

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 1,
    Value = 
new System.Int64[4]
{
3602782396575144304L,
7032263077821650034L,
8093934778014137105L,
5114012263885539083L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 4,
    Value = 
new System.Int64[3]
{
1555395332294621168L,
34566594811370247L,
3612174191622372553L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 2,
    Value = 
new System.Int64[4]
{
6970192226807682208L,
9105539260142053347L,
6917846180446135759L,
1190353397606165735L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1321731302643165335L,
5465260711318140403L,
4364679485037865567L,
5962987662003391225L,
},
},
            new Int64bigintArray1M
{
    Id = 11,
    Value = 
new System.Int64[3]
{
6595793358588126957L,
6901171323064286910L,
2903562460315549269L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 13,
    Value = 
new System.Int64[4]
{
1055225010639346940L,
6840232939143538643L,
3024684735567867870L,
4210741827187200511L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 6,
    Value = 
new System.Int64[4]
{
715535161269682065L,
4434095274106040901L,
6330430364559885652L,
7709879970335954718L,
},
    NullableValue = 
new System.Int64[3]
{
7355640218067884638L,
1349013967690007974L,
3196898589424444701L,
},
},
    NullableValue = 
new System.Int64[4]
{
5659163099264526927L,
4624532929927088440L,
8736735799637138312L,
5081361224222637076L,
},
},
            new Int64bigintArray1M
{
    Id = 22,
    Value = 
new System.Int64[4]
{
1917334601225226870L,
6660626619361311611L,
1971752934702267412L,
940219157165280282L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7564980142941274908L,
6767002615270786426L,
937495643181111040L,
4574690983663959930L,
},
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[3]
{
5291192505209893291L,
787695721258549371L,
2699621960722206291L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 14,
    Value = 
new System.Int64[3]
{
49372757742849753L,
8749245432111094264L,
8401531056707551443L,
},
    NullableValue = 
new System.Int64[3]
{
5347515391776974388L,
3495180989377997410L,
877308418709575971L,
},
},
    NullableValue = 
new System.Int64[3]
{
8661935251322646487L,
3590295354927224911L,
8570491319979221770L,
},
},
            new Int64bigintArray1M
{
    Id = 33,
    Value = 
new System.Int64[4]
{
3234883390268811045L,
8457148014184769932L,
5144036030564117649L,
2051724210762340360L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 34,
    Value = 
new System.Int64[4]
{
9203906305223849535L,
2713417292916165089L,
5174444827915367596L,
2735693299205428420L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 18,
    Value = 
new System.Int64[3]
{
4846003791851049317L,
4238524141656012821L,
2696383403525265419L,
},
    NullableValue = 
new System.Int64[3]
{
5696923788372674805L,
4480956656485671050L,
6167152177615703172L,
},
},
    NullableValue = 
new System.Int64[3]
{
5342312473743221572L,
1482182103525859752L,
5218520603283397191L,
},
},
            new Int64bigintArray1M
{
    Id = 41,
    Value = 
new System.Int64[4]
{
6196917540897364913L,
6952071700616586217L,
8712731709585546980L,
24065817222981428L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3629671687450008632L,
3716747662718026321L,
1257354719703066915L,
8427596165300678856L,
},
},
            new Int64bigintArray1M
{
    Id = 44,
    Value = 
new System.Int64[3]
{
7816871729570121360L,
415499382697327141L,
4966021259591050654L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 27,
    Value = 
new System.Int64[3]
{
4393463780106625111L,
8462850395411921919L,
6893676223905270495L,
},
    NullableValue = 
new System.Int64[4]
{
5603468655796243262L,
5383378665890461143L,
2546850643426744665L,
7293853008908592684L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 51,
    Value = 
new System.Int64[4]
{
2431072721282204795L,
6933129727594486993L,
175561606300818852L,
8594490656583342282L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1629428746116876152L,
1130259249767146243L,
2258920903771396863L,
},
},
            new Int64bigintArray1M
{
    Id = 56,
    Value = 
new System.Int64[4]
{
8968411666966447409L,
8036989142172562151L,
6944309434638844528L,
8688588684082045091L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[3]
{
1984078407394388940L,
332575885697569268L,
1703505173936079424L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 57,
    Value = 
new System.Int64[3]
{
2166987373771959796L,
2783208147664562634L,
4235563476278680536L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[3]
{
5580294164861895024L,
3681838551569328162L,
4475262337504151821L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[3]
{
3069882391438023747L,
6824251421325777471L,
7904914635229049891L,
},
    NullableValue = 
new System.Int64[3]
{
923277401048795853L,
7196290429859007111L,
7156890736059151104L,
},
},
    NullableValue = 
new System.Int64[3]
{
5922285745011510343L,
3882171300703513933L,
6572000751600220988L,
},
},
            new Int64bigintArray1M
{
    Id = 67,
    Value = 
new System.Int64[4]
{
8651802989839986186L,
8619612439539143563L,
4129207958897158736L,
260531981571149035L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
3018243886224131533L,
16357900175513353L,
3285558526910458408L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 39,
    Value = 
new System.Int64[3]
{
4204459651915057120L,
5705302742627465690L,
2604296344846322788L,
},
    NullableValue = 
new System.Int64[4]
{
5808578257864659785L,
7011028084885444899L,
769535554394860808L,
709070601598489101L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 79,
    Value = 
new System.Int64[4]
{
5564844850272891954L,
5437393407031209690L,
4492460462982175494L,
1057955223172747894L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 83,
    Value = 
new System.Int64[4]
{
9074160010491042107L,
1456255723192583606L,
2751404756843908523L,
5296479603548093147L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
2202250549172493762L,
7437215099697411798L,
2209247591107427925L,
4256444073988832476L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
346301131088270939L,
5217185318589395691L,
2834981730707320528L,
},
},
            new Int64bigintArray1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
7500752601187553036L,
6065603242971343659L,
4337499746079463589L,
4712046513761519387L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 96,
    Value = 
new System.Int64[4]
{
6993335170259525623L,
7667950312792009603L,
9039130827776268724L,
1474396022335776223L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 46,
    Value = 
new System.Int64[4]
{
159525025227049524L,
3123367450197818618L,
6905450294181266413L,
5192340385293005623L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 100,
    Value = 
new System.Int64[3]
{
2178523233450995996L,
3697941092925990478L,
5087730688683784042L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6681013392659323612L,
3513447501428566185L,
7209545835612272592L,
},
},
            new Int64bigintArray1M
{
    Id = 108,
    Value = 
new System.Int64[4]
{
7526012092790298490L,
5483293089231551486L,
5163842930316506880L,
8920612472912158722L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 48,
    Value = 
new System.Int64[3]
{
9193153559763906307L,
5070740013459014431L,
2872003482513116910L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5478104403987496943L,
2973836385639536826L,
8713677000168457971L,
},
},
            new Int64bigintArray1M
{
    Id = 109,
    Value = 
new System.Int64[4]
{
9109825898525492301L,
7496783132973592878L,
1226605717559827135L,
4880017063778094924L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
6083722910906019070L,
562032168634038068L,
1511212086737670676L,
890384150732221463L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
1539165388892099392L,
2928757035716260217L,
7601834606225928086L,
2765210501959167903L,
},
    NullableValue = 
new System.Int64[3]
{
9183502414690583118L,
5297569816533400864L,
2985757257232029086L,
},
},
    NullableValue = 
new System.Int64[4]
{
6905963558783922981L,
6275342363024757857L,
5799249601409642116L,
8920051270502019292L,
},
},
            new Int64bigintArray1M
{
    Id = 117,
    Value = 
new System.Int64[3]
{
2200334988559875729L,
8923446689161230800L,
4851016821314421085L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
116266869859486196L,
5666348619287493791L,
633558194315406013L,
},
},
            new Int64bigintArray1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
5851039706129261446L,
4790965331896915596L,
2111359491262970373L,
6971526302164868254L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 58,
    Value = 
new System.Int64[3]
{
6271609402325321595L,
6618515213228803791L,
4013592717381868879L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 125,
    Value = 
new System.Int64[3]
{
3873676363383183526L,
2870191660069426348L,
2365253446425585823L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1649229116090883919L,
982913614639789235L,
3765766851794807501L,
},
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
2869805566498154928L,
8868671053763457426L,
6954266450277003855L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 60,
    Value = 
new System.Int64[3]
{
7567617308011772382L,
768753195336464151L,
1048535226058974767L,
},
    NullableValue = 
new System.Int64[4]
{
7556581390255699276L,
6271390764392220565L,
7865271614577859463L,
2681677839540430824L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
4273775995475525671L,
8559567632046171239L,
2744693152757407203L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 141,
    Value = 
new System.Int64[4]
{
8924356481043178184L,
4892438294274190067L,
5750247739746942895L,
4166743745586930931L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
2906799446358855326L,
6902523865033333917L,
5170673884868834944L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4413263482188397890L,
6304978374734078137L,
4908091437634983366L,
8212289756953227647L,
},
},
            new Int64bigintArray1M
{
    Id = 150,
    Value = 
new System.Int64[4]
{
6612049010368573431L,
4202410989109464958L,
8262595461095429110L,
4616852523599798687L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6751218201444544380L,
7032446543899883653L,
6579350371144937328L,
},
},
            new Int64bigintArray1M
{
    Id = 155,
    Value = 
new System.Int64[3]
{
3848591951986186249L,
2954333001867010256L,
8606286846061336425L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 72,
    Value = 
new System.Int64[4]
{
5685118124682150961L,
4448971284513763053L,
1419242310452891603L,
1134023065860812991L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4354582519268807754L,
111355049927666294L,
976771355287426876L,
8128220870447601922L,
},
},
            new Int64bigintArray1M
{
    Id = 159,
    Value = 
new System.Int64[4]
{
8172008699232549374L,
339706019767868717L,
514151203212698599L,
6319047600342936488L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 163,
    Value = 
new System.Int64[4]
{
3260338389376990922L,
7486617242575384006L,
3189448264153079603L,
2104621119701738074L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 75,
    Value = 
new System.Int64[4]
{
3164595829761794640L,
1360710247925648895L,
1809360063979243319L,
4207440936249284474L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 169,
    Value = 
new System.Int64[3]
{
3779971830712610740L,
3552419186470999300L,
2386908127335141639L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
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
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
7564980142941274908L,
6767002615270786426L,
937495643181111040L,
4574690983663959930L,
}));
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
8661935251322646487L,
3590295354927224911L,
8570491319979221770L,
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5342312473743221572L,
1482182103525859752L,
5218520603283397191L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                methodParametrName: "int64bigintarray1mi_id", 
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
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
3629671687450008632L,
3716747662718026321L,
1257354719703066915L,
8427596165300678856L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1629428746116876152L,
1130259249767146243L,
2258920903771396863L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintArray1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 44, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 135, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
Int64bigintArray1M.AssertModel(models[0],_testData[1], false);Int64bigintArray1M.AssertModel(models[1],_testData[2], false);Int64bigintArray1M.AssertModel(models[2],_testData[3], false);Int64bigintArray1M.AssertModel(models[3],_testData[4], false);Int64bigintArray1M.AssertModel(models[4],_testData[5], false);Int64bigintArray1M.AssertModel(models[5],_testData[6], false);Int64bigintArray1M.AssertModel(models[6],_testData[7], false);Int64bigintArray1M.AssertModel(models[7],_testData[8], false);Int64bigintArray1M.AssertModel(models[8],_testData[9], false);Int64bigintArray1M.AssertModel(models[9],_testData[10], false);Int64bigintArray1M.AssertModel(models[10],_testData[11], false);Int64bigintArray1M.AssertModel(models[11],_testData[12], false);Int64bigintArray1M.AssertModel(models[12],_testData[13], false);Int64bigintArray1M.AssertModel(models[13],_testData[14], false);Int64bigintArray1M.AssertModel(models[14],_testData[15], false);Int64bigintArray1M.AssertModel(models[15],_testData[16], false);Int64bigintArray1M.AssertModel(models[16],_testData[17], false);Int64bigintArray1M.AssertModel(models[17],_testData[18], false);Int64bigintArray1M.AssertModel(models[18],_testData[19], false);Int64bigintArray1M.AssertModel(models[19],_testData[20], false);Int64bigintArray1M.AssertModel(models[20],_testData[21], false);Int64bigintArray1M.AssertModel(models[21],_testData[22], false);Int64bigintArray1M.AssertModel(models[22],_testData[23], false);Int64bigintArray1M.AssertModel(models[23],_testData[24], false);Int64bigintArray1M.AssertModel(models[24],_testData[25], false);Int64bigintArray1M.AssertModel(models[25],_testData[26], false);Int64bigintArray1M.AssertModel(models[26],_testData[27], false);Int64bigintArray1M.AssertModel(models[27],_testData[28], false);Int64bigintArray1M.AssertModel(models[28],_testData[29], false);Int64bigintArray1M.AssertModel(models[29],_testData[30], false);Int64bigintArray1M.AssertModel(models[30],_testData[31], false);Int64bigintArray1M.AssertModel(models[31],_testData[32], false);Int64bigintArray1M.AssertModel(models[32],_testData[33], false);Int64bigintArray1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray1M.AssertModel(models[0],_testData[25], false);Int64bigintArray1M.AssertModel(models[1],_testData[26], false);Int64bigintArray1M.AssertModel(models[2],_testData[27], false);Int64bigintArray1M.AssertModel(models[3],_testData[28], false);Int64bigintArray1M.AssertModel(models[4],_testData[29], false);Int64bigintArray1M.AssertModel(models[5],_testData[30], false);Int64bigintArray1M.AssertModel(models[6],_testData[31], false);Int64bigintArray1M.AssertModel(models[7],_testData[32], false);Int64bigintArray1M.AssertModel(models[8],_testData[33], false);Int64bigintArray1M.AssertModel(models[9],_testData[34], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

