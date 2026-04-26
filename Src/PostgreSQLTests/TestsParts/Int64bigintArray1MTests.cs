

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
    Id = 6,
    Value = 
new System.Int64[4]
{
9199833350475735042L,
8440041676959722602L,
7998723006864556940L,
6525410485402489021L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8483275050062468822L,
8538547376752272446L,
6026771080678015589L,
},
},
            new Int64bigintArray1M
{
    Id = 7,
    Value = 
new System.Int64[4]
{
2031706981247864908L,
4300867748302387203L,
1715036393776951819L,
8521961030466089195L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 9,
    Value = 
new System.Int64[4]
{
8460063118696967431L,
6712716487994081598L,
5270363840700827388L,
5421111414763038441L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 14,
    Value = 
new System.Int64[4]
{
3345496136834936884L,
9080636355940839030L,
2874072731181288688L,
6165683868777648187L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
9104696338003517559L,
2771497861890576925L,
2043032396369893369L,
1745853375446081109L,
},
},
            new Int64bigintArray1M
{
    Id = 17,
    Value = 
new System.Int64[3]
{
5047126191878956419L,
7475766260142405402L,
6183441144742532728L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
1052349139836802659L,
8529389876316726652L,
8621438120426144443L,
},
    NullableValue = 
new System.Int64[4]
{
8560467918727863841L,
663778856000517386L,
7501005875054922451L,
1113010618569560731L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
8418618729465483317L,
1667419172352838281L,
4789794741793171626L,
8817417117567604769L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 21,
    Value = 
new System.Int64[3]
{
2671323932689171787L,
6195156293584518068L,
4175294062314886151L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 12,
    Value = 
new System.Int64[4]
{
1331886686984673000L,
519260381372492230L,
6748025010575994451L,
7366291197424572916L,
},
    NullableValue = 
new System.Int64[3]
{
4357736781297185250L,
6121188334930894463L,
5155998773684770171L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[4]
{
7652996018018393542L,
2394324465518918975L,
1808542931441884489L,
3956531074848314156L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6740493373211559434L,
8751564801879625154L,
7201912776944410322L,
},
},
            new Int64bigintArray1M
{
    Id = 33,
    Value = 
new System.Int64[4]
{
4479790300349991024L,
6606967246324063269L,
6758611209476126639L,
1921958117719102919L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 13,
    Value = 
new System.Int64[3]
{
6818843129037425387L,
5937108890293388370L,
8193323858048802660L,
},
    NullableValue = 
new System.Int64[4]
{
6112476510503492885L,
5333764476380429819L,
5124604387025311344L,
868539404939975690L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 36,
    Value = 
new System.Int64[4]
{
7226978069122041064L,
5676511925511337477L,
8526443922253156811L,
7703996407318928356L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 41,
    Value = 
new System.Int64[4]
{
505328287561908365L,
1164259200506479949L,
8033050303118558198L,
35323883651721843L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 22,
    Value = 
new System.Int64[3]
{
1643656940275253814L,
7979247021833989410L,
6103590677093361989L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 45,
    Value = 
new System.Int64[4]
{
3665882740956202097L,
3444502938267971213L,
4131576981924657918L,
4237875255366829710L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
9040944757773450831L,
8444772293146272325L,
9078722860370641358L,
8598640487056099238L,
},
},
            new Int64bigintArray1M
{
    Id = 54,
    Value = 
new System.Int64[3]
{
2190569814692280174L,
8904185375532563401L,
8959293718225610830L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 30,
    Value = 
new System.Int64[3]
{
7863592871365263286L,
6919093940353369060L,
2620255236344013243L,
},
    NullableValue = 
new System.Int64[3]
{
13829438943145519L,
6741007845001607828L,
5589119019053248930L,
},
},
    NullableValue = 
new System.Int64[3]
{
1820465867668766567L,
7751774406591401286L,
220003321964949742L,
},
},
            new Int64bigintArray1M
{
    Id = 56,
    Value = 
new System.Int64[4]
{
5010370926206661476L,
4606171100546912293L,
6205953080085539688L,
6690238712795590514L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 62,
    Value = 
new System.Int64[3]
{
4578403431801345394L,
4812883348613338560L,
3253727818395500124L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
2152208693589989791L,
1787973049636636688L,
2168671308503238717L,
2495612337696362348L,
},
    NullableValue = 
new System.Int64[4]
{
3149760662202187242L,
4967787753298436294L,
6620544018891842352L,
5689070985587678543L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 64,
    Value = 
new System.Int64[3]
{
7752573445400693261L,
6815283544439787341L,
4093986701893870345L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 68,
    Value = 
new System.Int64[4]
{
466920790360693661L,
5245011086077151613L,
1757626722291047207L,
8331917076138557550L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
4336087797427903308L,
3887341431972784041L,
8455607279010116934L,
6607847164042631937L,
},
    NullableValue = 
new System.Int64[4]
{
9019364746377524694L,
5179298461529041180L,
5116866382629599539L,
6928502422276803480L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
1802809488905068676L,
2131240466316639259L,
1658560221981453464L,
8302862232931658054L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7297288365067298444L,
7955099227096016033L,
651221336719990930L,
},
},
            new Int64bigintArray1M
{
    Id = 80,
    Value = 
new System.Int64[3]
{
5884329188513642678L,
4104126148008239636L,
3426416542520245056L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 47,
    Value = 
new System.Int64[4]
{
5152906725498898251L,
5844117249410406771L,
5633897823485038805L,
8601861037761430738L,
},
    NullableValue = 
new System.Int64[4]
{
2492339257092433622L,
6252563865954988422L,
5338513356652603360L,
7293866753702447046L,
},
},
    NullableValue = 
new System.Int64[4]
{
3626631405274498641L,
269955333408964396L,
9111747335562289403L,
6231644975036138560L,
},
},
            new Int64bigintArray1M
{
    Id = 83,
    Value = 
new System.Int64[3]
{
5642938359301102121L,
9220430785611652159L,
2576017545969978788L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 85,
    Value = 
new System.Int64[4]
{
1183536824642841665L,
5895545040765265717L,
1986820456191614198L,
6598304394228920733L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 49,
    Value = 
new System.Int64[4]
{
812524674237547499L,
36122407573111249L,
7725712183352069229L,
7758357028783560890L,
},
    NullableValue = 
new System.Int64[4]
{
7151861530796796709L,
584896278630627524L,
7604067969989012396L,
2031450808638111129L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
8220866981764071686L,
1240791875430360526L,
2179715364862912010L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 89,
    Value = 
new System.Int64[4]
{
3797277120167309619L,
5413705334260347975L,
5719809111524343524L,
8512653456395747020L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
399788535677070993L,
8366035596425255598L,
3686764732391673348L,
2636334001370309838L,
},
    NullableValue = 
new System.Int64[4]
{
7594832140475579707L,
7866793282960174995L,
2390781090332770304L,
2477747091070567023L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 91,
    Value = 
new System.Int64[3]
{
9104282904054138225L,
5582210314681153981L,
7502834687597850708L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 97,
    Value = 
new System.Int64[3]
{
4724019237058049093L,
1476669431418029722L,
6398562471243146264L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 52,
    Value = 
new System.Int64[4]
{
2933707312053459389L,
4787915516998389974L,
6663308400391285991L,
2747786920400362953L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3952528067496313117L,
8377655797484310303L,
1139274966547043578L,
},
},
            new Int64bigintArray1M
{
    Id = 98,
    Value = 
new System.Int64[4]
{
3491672107695402211L,
715516665702687101L,
555056427561773736L,
4973681263549572359L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 106,
    Value = 
new System.Int64[3]
{
5712778970879914955L,
3416568647061077615L,
6400579891974854891L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
527137783348197442L,
963866766917045165L,
243950648129930032L,
6595012201839301402L,
},
    NullableValue = 
new System.Int64[3]
{
5128298615691838710L,
4273533026694719101L,
2719565960896503344L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 109,
    Value = 
new System.Int64[4]
{
2287182823002069402L,
4442594068223486333L,
3787877659732039207L,
5538668416092437668L,
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
6825323966745626003L,
644165097615156942L,
9148257445434927322L,
4962179133567120714L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 61,
    Value = 
new System.Int64[4]
{
6040249107464461590L,
8657956733249484892L,
7517198950933258693L,
4840628561842167935L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
667193941120690412L,
8998803590608800128L,
5055394307911848395L,
8886448778792168736L,
},
},
            new Int64bigintArray1M
{
    Id = 125,
    Value = 
new System.Int64[4]
{
16908227108878724L,
9155629685630149406L,
8738815821278265434L,
9103602518609751004L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3908840857044555372L,
7912279093007575249L,
624652461873917521L,
1782503908022278775L,
},
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[3]
{
6499058207077065471L,
7166283804444585238L,
2348031398466778459L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 70,
    Value = 
new System.Int64[3]
{
36815803004381622L,
355575312989423090L,
341691123036102658L,
},
    NullableValue = 
new System.Int64[4]
{
2910026645816734122L,
4367145558968435535L,
1228954657021317164L,
6110727707933606437L,
},
},
    NullableValue = 
new System.Int64[4]
{
4377871966238264332L,
6369826287128443021L,
1986099493279346655L,
5316521109766926958L,
},
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6740493373211559434L,
8751564801879625154L,
7201912776944410322L,
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
                Assert.That(nullable, Is.Null);
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
9040944757773450831L,
8444772293146272325L,
9078722860370641358L,
8598640487056099238L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1820465867668766567L,
7751774406591401286L,
220003321964949742L,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 36, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 62, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 89, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 88, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[29], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Int64bigintArray1M.AssertModel(models[0],_testData[18], false);Int64bigintArray1M.AssertModel(models[1],_testData[19], false);Int64bigintArray1M.AssertModel(models[2],_testData[20], false);Int64bigintArray1M.AssertModel(models[3],_testData[21], false);Int64bigintArray1M.AssertModel(models[4],_testData[22], false);Int64bigintArray1M.AssertModel(models[5],_testData[23], false);Int64bigintArray1M.AssertModel(models[6],_testData[24], false);Int64bigintArray1M.AssertModel(models[7],_testData[25], false);Int64bigintArray1M.AssertModel(models[8],_testData[26], false);Int64bigintArray1M.AssertModel(models[9],_testData[27], false);Int64bigintArray1M.AssertModel(models[10],_testData[28], false);Int64bigintArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Int64bigintArray1M.AssertModel(models[0],_testData[7], false);Int64bigintArray1M.AssertModel(models[1],_testData[8], false);Int64bigintArray1M.AssertModel(models[2],_testData[9], false);Int64bigintArray1M.AssertModel(models[3],_testData[10], false);Int64bigintArray1M.AssertModel(models[4],_testData[11], false);Int64bigintArray1M.AssertModel(models[5],_testData[12], false);Int64bigintArray1M.AssertModel(models[6],_testData[13], false);Int64bigintArray1M.AssertModel(models[7],_testData[14], false);Int64bigintArray1M.AssertModel(models[8],_testData[15], false);Int64bigintArray1M.AssertModel(models[9],_testData[16], false);Int64bigintArray1M.AssertModel(models[10],_testData[17], false);Int64bigintArray1M.AssertModel(models[11],_testData[18], false);Int64bigintArray1M.AssertModel(models[12],_testData[19], false);Int64bigintArray1M.AssertModel(models[13],_testData[20], false);Int64bigintArray1M.AssertModel(models[14],_testData[21], false);Int64bigintArray1M.AssertModel(models[15],_testData[22], false);Int64bigintArray1M.AssertModel(models[16],_testData[23], false);Int64bigintArray1M.AssertModel(models[17],_testData[24], false);Int64bigintArray1M.AssertModel(models[18],_testData[25], false);Int64bigintArray1M.AssertModel(models[19],_testData[26], false);Int64bigintArray1M.AssertModel(models[20],_testData[27], false);Int64bigintArray1M.AssertModel(models[21],_testData[28], false);Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

