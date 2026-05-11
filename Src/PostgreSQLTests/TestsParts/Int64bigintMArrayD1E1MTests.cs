

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
    internal partial interface IInt64MArraybigintMArrayD1
    {
    }
    
    internal partial class Int64MArraybigintMArrayD1 : IInt64MArraybigintMArrayD1
    {


#region TestData

        private readonly Int64bigintMArrayD1E1M[] _testData = new Int64bigintMArrayD1E1M[]
        {
            new Int64bigintMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int64[3]
{
9064104546823619472L,
5668816300023572073L,
4568204134063900067L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int64[3]
{
1668520546085096975L,
666948967671667461L,
3040238998574480275L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 2,
    Value = 
new System.Int64[4]
{
9162001117719279777L,
6216518991877585598L,
4901265539672681671L,
1031967987364284522L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[3]
{
3958290716587228641L,
304221262450205997L,
7047824480496562643L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int64[3]
{
3809948366420514215L,
5416117390369461272L,
1814440101804462407L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 3,
    Value = 
new System.Int64[3]
{
2196665810350396356L,
4217748987972526312L,
8371434319150508437L,
},
    NullableValue = 
new System.Int64[4]
{
1216827750416633442L,
898348632178403727L,
188826838099279580L,
1502871931148601584L,
},
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int64[4]
{
2218896511961303472L,
3704447080434588393L,
3189110140646830074L,
5015547880880831841L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4238541523036558409L,
5969931802125970158L,
1262878444964003821L,
3879783645479793356L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[3]
{
6078361208182851598L,
4151855882453381557L,
2935580048447771025L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 7,
    Value = 
new System.Int64[4]
{
2009349414551214942L,
3785735504894868185L,
2621046508195525818L,
8571671899791362839L,
},
    NullableValue = 
new System.Int64[3]
{
5233508666820342144L,
5878800918371798660L,
2774257025455431877L,
},
},
    NullableValue = 
new System.Int64[3]
{
3020276874691138800L,
516239762430179235L,
6352578920310236032L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Int64[3]
{
3567362118193034979L,
7844856043486248601L,
7548041221255385549L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1442685098629108776L,
1104412160438361892L,
4166138619431407233L,
1606875496047126136L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int64[3]
{
1389557379425569596L,
7470963955046903019L,
5070293001060828152L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 8,
    Value = 
new System.Int64[4]
{
7405386685406375254L,
1447616157167845955L,
6500716782762263039L,
5777039458970096856L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2417236544037383878L,
3584830994909869142L,
5065464589280012507L,
3921695600198952626L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[3]
{
4877119975833053483L,
4535181525911058491L,
1417394131778052681L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int64[3]
{
8851268428097255395L,
426173179316558080L,
1735408418761131072L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 17,
    Value = 
new System.Int64[3]
{
1043934016406519078L,
2025011588888970642L,
5764069437410482446L,
},
    NullableValue = 
new System.Int64[3]
{
8419770477603543166L,
1116525131629089244L,
1879613548870668018L,
},
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Int64[4]
{
2638257975352140321L,
5520473870162656128L,
8015560897890040387L,
5145022134157509556L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int64[4]
{
5085667973012617671L,
888049517286419836L,
2585415720617306899L,
1778263629620792111L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
8101531950081630713L,
1495824927869740613L,
6880644193106387415L,
4564199405117034934L,
},
    NullableValue = 
new System.Int64[4]
{
1327712828805625114L,
5820697860564911556L,
9137681965931016717L,
4579467060218723478L,
},
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int64[3]
{
7360264056219195933L,
5855252334114146728L,
1133212904108586726L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4953057880859703038L,
8154174331114297250L,
230448374207043646L,
1624017869909919001L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int64[3]
{
5212859589813705708L,
4217518861514757748L,
1373996534320989350L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 29,
    Value = 
new System.Int64[3]
{
6511716927719764829L,
4972863363844502073L,
3175425175801870386L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
177858072012229280L,
9192926887122816859L,
2519688789023482819L,
8308762418195939753L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int64[3]
{
8324384607516395250L,
8157046263719159003L,
2185799039062315543L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
3422454866872086941L,
8503254158023564055L,
2030653491068500455L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
161054631276461138L,
8776339356083011450L,
392291551421043006L,
3867635565954934565L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
9051977767164897717L,
3602286163312219270L,
6277026006472978120L,
5651384394503573021L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Int64[4]
{
8526838589370352910L,
7894179150925798269L,
4007156202536802718L,
4954881576796500973L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4841361800930198520L,
6536172487138377949L,
5106510218447338989L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
6235438422499673471L,
973618066270179424L,
7375566578498861378L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 39,
    Value = 
new System.Int64[4]
{
3004995222995948542L,
1007017030263915133L,
4018952960971283610L,
7886330584119834573L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
7674415543636303510L,
2897927812900798176L,
7775279389963642257L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
2593764846762549301L,
1998010076336195748L,
7197473121723400200L,
5323264567767785730L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
6452228924157637471L,
117789355137642273L,
1557522603930090825L,
7378204501521241943L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Int64[4]
{
8724437739564829023L,
5053467184157701813L,
2560825101415247761L,
6688712846972285764L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int64[3]
{
2649232754222891389L,
6421990960890218148L,
3810419704146308509L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 54,
    Value = 
new System.Int64[4]
{
3434005803924108661L,
9103890060913309619L,
1079782473730720753L,
573284859852140245L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
674068646549507417L,
6284453785967132002L,
6504587314055260632L,
5516033648770815067L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
7956256767624660495L,
8297471033810724467L,
7716717082787261389L,
4917113128802810566L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 59,
    Value = 
new System.Int64[3]
{
7093725726541970366L,
3265160042642306377L,
669064751675542221L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7057884125209450584L,
3487971328645182379L,
5033198785135678908L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Int64[3]
{
282216960404840943L,
4272910696011816337L,
8837988217934955010L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Int64[4]
{
3155242539074621787L,
1714761264435980724L,
7876987690944319079L,
2908769357418558305L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 61,
    Value = 
new System.Int64[4]
{
1431627101901698851L,
2906377075510007243L,
8801412785134267049L,
1746890773534636874L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int64[3]
{
8835644444399853705L,
561518529765223559L,
4586245727630275097L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3038065281644101816L,
7012371853968469025L,
346596272491525079L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int64[4]
{
3124828420557758612L,
7962946991057112149L,
5615591146921274944L,
7465208552214583988L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 63,
    Value = 
new System.Int64[4]
{
3661194263207161945L,
4978424448561851270L,
6870822228971039404L,
8404296618225918970L,
},
    NullableValue = 
new System.Int64[4]
{
3893383443945462996L,
6749446385575938395L,
7408892972054979825L,
4056417117963665211L,
},
},
    NullableValue = 
new System.Int64[3]
{
7824096696080437324L,
6332909970400547435L,
8284213262672356366L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int64[3]
{
5175521264126821909L,
8248309129835197433L,
6641967780118936302L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int64[4]
{
2239778008131978915L,
6417524974724496250L,
2381077913950922219L,
8750063827755338214L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 69,
    Value = 
new System.Int64[3]
{
6864110687900649715L,
6034398898859456312L,
1067262070834791041L,
},
    NullableValue = 
new System.Int64[3]
{
4960812690159790498L,
4201564261528390650L,
6006242857866478767L,
},
},
    NullableValue = 
new System.Int64[3]
{
4787561080445457632L,
3903341852586671795L,
6021029058154023418L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int64[3]
{
5847652875644940972L,
7911961926012671381L,
6860037071958501162L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3791074716118152670L,
7251102819508666847L,
8839556707446206610L,
8886994258039221989L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int64[3]
{
8208448164454746913L,
3931100482440601581L,
6447777260297485555L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
2233549274452544703L,
814467618445541501L,
5778590861157516996L,
},
    NullableValue = 
new System.Int64[4]
{
5855909915256081865L,
4794955136164161002L,
6424411557499424338L,
5903797844360994738L,
},
},
    NullableValue = 
new System.Int64[3]
{
3048278241135071996L,
6625707765689168148L,
4449408545560560375L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int64[3]
{
823966733240314190L,
1738222289109743936L,
9087025102267721167L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1638192546056806867L,
8401338649912540420L,
7360693542006780746L,
6994518262434265487L,
},
},
            new Int64bigintMArrayD1E1M
{
    Id = 166,
    Value = 
new System.Int64[3]
{
1344025367978754155L,
1626612331435325910L,
5217131928047343075L,
},
    ModelInner = new Int64bigintMArrayD11MI
{
    Id = 79,
    Value = 
new System.Int64[3]
{
4491304296481739252L,
2583560329301609590L,
6319949150124194272L,
},
    NullableValue = 
new System.Int64[3]
{
9182742991485487704L,
1673573489058359974L,
6811003813607626863L,
},
},
    NullableValue = null,
},
            new Int64bigintMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Int64[3]
{
1226144667710454557L,
8525043372673436736L,
8781125246471626223L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmarrayd11mi(
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
INSERT INTO public.int64bigintmarrayd11mi(
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
            queryMapTypes: [typeof(Int64bigintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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

                changedRows =  ((IInt64MArraybigintMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmarrayd11mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)), 
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
                methodParametrName: "int64bigintmarrayd11mi_id", 
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
                changedRows =  ((IInt64MArraybigintMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmarrayd11mi_id
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
    int64bigintmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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

                    nullable =  ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4238541523036558409L,
5969931802125970158L,
1262878444964003821L,
3879783645479793356L,
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

                    nullable =  ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
3020276874691138800L,
516239762430179235L,
6352578920310236032L,
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

                    nullable = await ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
1442685098629108776L,
1104412160438361892L,
4166138619431407233L,
1606875496047126136L,
}));
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

                    nullable = await ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
2417236544037383878L,
3584830994909869142L,
5065464589280012507L,
3921695600198952626L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmarrayd11mi_id
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
    int64bigintmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                methodParametrName: "int64bigintmarrayd11mi_id", 
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
                nullable =  ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMArrayD1E1M> models = null;

                models =  ((IInt64MArraybigintMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMArrayD1E1M> models = null;

                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M), typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                ((IInt64MArraybigintMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
LEFT JOIN public.int64bigintmarrayd11mi mi ON mi.id = m.int64bigintmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await ((IInt64MArraybigintMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M), typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                ((IInt64MArraybigintMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
LEFT JOIN public.int64bigintmarrayd11mi mi ON mi.id = m.int64bigintmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await ((IInt64MArraybigintMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M), typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                await((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
LEFT JOIN public.int64bigintmarrayd11mi mi ON mi.id = m.int64bigintmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await((IInt64MArraybigintMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M), typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                await((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 161, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMArrayD1E1M>();
                ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 156, query1, 86, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                await ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
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
FROM public.int64bigintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMArrayD1E1M>();
                 ((IInt64MArraybigintMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 46, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintmarrayd1e1m m
LEFT JOIN public.int64bigintmarrayd11mi mi ON mi.id = m.int64bigintmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await((IInt64MArraybigintMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 156, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((IInt64MArraybigintMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                Int64bigintMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                Int64bigintMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                Int64bigintMArrayD1E1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models =  ((IInt64MArraybigintMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int64bigintMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                Int64bigintMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                Int64bigintMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_int64bigintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMArrayD11MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMArrayD11MI),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMArrayD1E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
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
FROM public.binary_int64bigintmarrayd1e1m m
LEFT JOIN public.binary_int64bigintmarrayd11mi mi ON mi.id = m.int64bigintmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models =  ((IInt64MArraybigintMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA), typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                await ((IInt64MArraybigintMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                ((IInt64MArraybigintMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmarrayd11mi
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
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmarrayd11mi
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
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA), typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                await ((IInt64MArraybigintMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                ((IInt64MArraybigintMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
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
                var models = await ((IInt64MArraybigintMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmarrayd11mi
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
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmarrayd11mi
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
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MI), typeof(Int64bigintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models1 = new List<Int64bigintMArrayD11MI>();
                var models2 = new List<Int64bigintMArrayD11MI>();
                await ((IInt64MArraybigintMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMArrayD11MI>();
                var models2 = new List<Int64bigintMArrayD11MI>();
                ((IInt64MArraybigintMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1)),
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
                var models = await ((IInt64MArraybigintMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA), typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                await ((IInt64MArraybigintMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMArrayD11MIWA>();
                var models2 = new List<Int64bigintMArrayD11MIWA>();
                ((IInt64MArraybigintMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMArrayD1))]
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
                var models = await ((IInt64MArraybigintMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

