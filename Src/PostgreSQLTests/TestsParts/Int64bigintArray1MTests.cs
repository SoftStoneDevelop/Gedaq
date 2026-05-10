

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
    Id = 8,
    Value = 
new System.Int64[4]
{
8589989533653656665L,
7979345549098069562L,
3246168324125642284L,
1793971018545201486L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
3723822675132890445L,
426613914130760909L,
7395493275351841362L,
7915693533185407254L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
3622878827562565053L,
5963461101054903258L,
3534303846374674920L,
1737776860415238475L,
},
    NullableValue = 
new System.Int64[4]
{
7823335916144435742L,
7227344129179793409L,
2737102174734724886L,
604992286304101627L,
},
},
    NullableValue = 
new System.Int64[3]
{
5002164765426689455L,
8183917837470778366L,
5775698102850103118L,
},
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[3]
{
5555998175879838667L,
7626572542839611026L,
8363991414472077171L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 24,
    Value = 
new System.Int64[3]
{
370749175157027837L,
2101372465018444309L,
2588021228173064784L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
5722917039178250846L,
6661995204140367158L,
3544733271218497742L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4556172230908357504L,
2252744850265979660L,
1292916786877399016L,
1105580981657938964L,
},
},
            new Int64bigintArray1M
{
    Id = 30,
    Value = 
new System.Int64[4]
{
4045787754315843920L,
8377751011536269851L,
7112164965813924528L,
2592050255197293783L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 33,
    Value = 
new System.Int64[3]
{
179360448022786128L,
5929967825991484120L,
6967002250521257934L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 17,
    Value = 
new System.Int64[3]
{
6136929780254560294L,
5362124330652982023L,
207953819354125402L,
},
    NullableValue = 
new System.Int64[3]
{
6110467817153635848L,
292646468123782693L,
1466410992336069021L,
},
},
    NullableValue = 
new System.Int64[4]
{
634301530936156436L,
2657936560562271451L,
506515253706167191L,
8400547792022519334L,
},
},
            new Int64bigintArray1M
{
    Id = 37,
    Value = 
new System.Int64[3]
{
6926192805404594268L,
4938989731987865380L,
4638694781557378835L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
7725818373633947931L,
6213842610736106797L,
1930075200429950039L,
2852845277023753965L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 23,
    Value = 
new System.Int64[4]
{
3993373775372410556L,
1935393625357950426L,
7394228613558671722L,
2398140120329895174L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 46,
    Value = 
new System.Int64[3]
{
964944119464402117L,
1401935082355359247L,
5502408395462192625L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5559655158460922517L,
3740345264160794310L,
3325312984773663133L,
602425480266952735L,
},
},
            new Int64bigintArray1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
1336738958708202257L,
7756257163212054237L,
4995742740203481689L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[3]
{
9093952952649758013L,
5425543323593350597L,
928343447507979186L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 59,
    Value = 
new System.Int64[4]
{
8346722450646671279L,
293924917538416162L,
1967209456139877839L,
986786761368723644L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
2001776139758009765L,
605274917614252891L,
490734147114158442L,
2984339423093804621L,
},
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[3]
{
3532148878455925399L,
3088155016214415056L,
9020511729880992661L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
3959120886706410726L,
1361833368093432912L,
3253844785670827971L,
2525428745430869998L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1090832361227908128L,
3375766335854855534L,
4357479038585487214L,
},
},
            new Int64bigintArray1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
5766226049711951298L,
6314805847791187991L,
3825854327044819124L,
4184352063157056714L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
820880991759183743L,
2023779751249141156L,
2036968002083377767L,
6701032799496869225L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 42,
    Value = 
new System.Int64[4]
{
4817847715844099888L,
991972608874891901L,
2133686719476901378L,
1507203600530627652L,
},
    NullableValue = 
new System.Int64[4]
{
2567261207633952499L,
3707229236867751260L,
2078369401964978630L,
4578187450471723946L,
},
},
    NullableValue = 
new System.Int64[4]
{
2278032557548651103L,
6598952182113050428L,
9154300680406480192L,
5666590760143747318L,
},
},
            new Int64bigintArray1M
{
    Id = 80,
    Value = 
new System.Int64[4]
{
7012560385311925415L,
7317339999506427687L,
4001861490328744315L,
4843423591310463826L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 84,
    Value = 
new System.Int64[3]
{
5577610644239494951L,
7786682455502646405L,
815206718316232762L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 46,
    Value = 
new System.Int64[4]
{
316882578172497247L,
5569879611728659738L,
4152320852309109357L,
7945625586684690474L,
},
    NullableValue = 
new System.Int64[3]
{
8107040118804210111L,
7848654082853018679L,
3134138150524766650L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[4]
{
2635356093228369124L,
5434787160206213293L,
8973260556080478171L,
5016694305001850803L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5225125276795024606L,
9158339556253687060L,
7195725824342912395L,
1881727834217060387L,
},
},
            new Int64bigintArray1M
{
    Id = 94,
    Value = 
new System.Int64[3]
{
7890350779663676512L,
2520939631803940782L,
1513357106745526144L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 53,
    Value = 
new System.Int64[3]
{
6705751253520768204L,
809785727241599507L,
7682073102706300521L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
4794585554637675850L,
5321589507214561170L,
5531163160299017299L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 103,
    Value = 
new System.Int64[4]
{
6137095645988712481L,
6105160592410603058L,
1352373385744353521L,
8073588275061657310L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 56,
    Value = 
new System.Int64[4]
{
8453710903024857394L,
3765656889763926305L,
185943358722771167L,
3757897518546300611L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 108,
    Value = 
new System.Int64[3]
{
3289244282185515075L,
1743123480603446382L,
1610953388508830405L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 116,
    Value = 
new System.Int64[4]
{
8627793754352190108L,
6830414250662468965L,
2410643005665639960L,
4409497174632391168L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 64,
    Value = 
new System.Int64[4]
{
5900048849973765183L,
834715468318993679L,
8505737003115277262L,
509461415281794358L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[4]
{
1528643782364149611L,
5538738363040126126L,
3635650802309545539L,
3417514974597593927L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
2693288368170033369L,
691227032338970455L,
6741175648080904698L,
2159796278403642074L,
},
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[3]
{
6539190035815137784L,
4098563633363832434L,
6694875757559580036L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 65,
    Value = 
new System.Int64[4]
{
2924287808074111277L,
3181355084563153235L,
4514797860163541524L,
1590958579453908279L,
},
    NullableValue = 
new System.Int64[3]
{
9148735276780313402L,
2770319130853935563L,
2054723457193074180L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 135,
    Value = 
new System.Int64[4]
{
7061511470844690689L,
1270934198854777334L,
2222810386448379517L,
8480583296296999961L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 143,
    Value = 
new System.Int64[3]
{
1427527717478538305L,
6028763583810961101L,
4030885817575172706L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
1972859758231920719L,
8587997968077118060L,
5481960974435210770L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3577480931140714017L,
4055908759019078610L,
3497288870009217436L,
4198751349803581746L,
},
},
            new Int64bigintArray1M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
8175976681479980248L,
398284715698527033L,
5816101012571795622L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 154,
    Value = 
new System.Int64[3]
{
6967792092877822204L,
913978369480012263L,
1697157923417473120L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 77,
    Value = 
new System.Int64[4]
{
4282490290546739712L,
1089223761044887249L,
4456422758234386690L,
8862490870726862527L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 162,
    Value = 
new System.Int64[4]
{
1508342470490497769L,
5725342086967823071L,
1361654971243061993L,
4573736753767201226L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4810388255911641597L,
6153140662694991462L,
1474604069367349418L,
},
},
            new Int64bigintArray1M
{
    Id = 163,
    Value = 
new System.Int64[3]
{
7372612356517310621L,
4720838193404914582L,
6585901192457017399L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 86,
    Value = 
new System.Int64[3]
{
5517567340512954656L,
1115475359280383449L,
7816722300235375955L,
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
5876423805742777456L,
3128692867130741133L,
6051379338746183614L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4407952085866081399L,
6376978294283541332L,
4062961456161296475L,
},
},
            new Int64bigintArray1M
{
    Id = 178,
    Value = 
new System.Int64[4]
{
4046944461325505640L,
7858165427999539822L,
5330673785469830813L,
4380134360621874291L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 93,
    Value = 
new System.Int64[3]
{
3272693130726698668L,
4361681275065799630L,
7509084468077196071L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 179,
    Value = 
new System.Int64[3]
{
2447425232528828542L,
1466324218960594258L,
1929180933472297003L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7676840306961158990L,
9095036982110409030L,
2694715868619500961L,
},
},
            new Int64bigintArray1M
{
    Id = 182,
    Value = 
new System.Int64[3]
{
2455167447458947416L,
2494026231524141076L,
1838267020525242285L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 101,
    Value = 
new System.Int64[3]
{
1979968380731056098L,
6763633297656591573L,
6536246574537898286L,
},
    NullableValue = 
new System.Int64[4]
{
9129618015654338412L,
503777130943834595L,
2376569151078205923L,
6204462306122511578L,
},
},
    NullableValue = 
new System.Int64[4]
{
7464986463363710077L,
8953691574621446636L,
4562322614388261438L,
8531374015920713130L,
},
},
            new Int64bigintArray1M
{
    Id = 190,
    Value = 
new System.Int64[3]
{
975819177700063299L,
780668820646925532L,
7049944911098600777L,
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
634301530936156436L,
2657936560562271451L,
506515253706167191L,
8400547792022519334L,
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
                Assert.That(nullable, Is.Null);
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
5559655158460922517L,
3740345264160794310L,
3325312984773663133L,
602425480266952735L,
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
new System.Int64[4]
{
2001776139758009765L,
605274917614252891L,
490734147114158442L,
2984339423093804621L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1090832361227908128L,
3375766335854855534L,
4357479038585487214L,
}));
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 24, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 154, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 179, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 37, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[34], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                Int64bigintArray1M.AssertModel(models[0],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int64bigintArray1M.AssertModel(models[0],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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

