

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
    Id = 4,
    Value = 
new System.Int64[4]
{
4370776237546162063L,
2999862146553310476L,
699681416961976923L,
9119715742642603462L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4967413705860886057L,
3246811676566398853L,
1009447573544584367L,
7845324844385880403L,
},
},
            new Int64bigintArray1M
{
    Id = 6,
    Value = 
new System.Int64[3]
{
1904203830619871474L,
4521434872746658739L,
6704939930645917432L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
8023885181985328715L,
8568994430161662972L,
4083611713602583571L,
1524797598636641751L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 8,
    Value = 
new System.Int64[3]
{
7882643824385132399L,
1975770794792052732L,
3496021378226243524L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7243477028968592441L,
8922446911824005529L,
8192900813801435871L,
},
},
            new Int64bigintArray1M
{
    Id = 9,
    Value = 
new System.Int64[3]
{
7195619065496254787L,
7695897180097746181L,
8190729990961664459L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
142642538127528162L,
3088119616251586227L,
2688390612309676973L,
},
    NullableValue = 
new System.Int64[3]
{
8919963485552859760L,
2884934573036244227L,
2866810599418724426L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 12,
    Value = 
new System.Int64[4]
{
7351422684413819744L,
4093715561958928268L,
1395666709187585008L,
1270271671201000521L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4709192354213838921L,
4431381989573788992L,
4480968461104960322L,
},
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[3]
{
5415191484510064946L,
7175985478388919019L,
482659067011468558L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 19,
    Value = 
new System.Int64[3]
{
8662832769544925891L,
6095604461725061636L,
5766833079285908749L,
},
    NullableValue = 
new System.Int64[3]
{
6003900265332926491L,
8998656290528646914L,
1402025974150132526L,
},
},
    NullableValue = 
new System.Int64[4]
{
6208691486220084813L,
3634652390989115769L,
1140293188619810871L,
2237941547480486561L,
},
},
            new Int64bigintArray1M
{
    Id = 18,
    Value = 
new System.Int64[4]
{
6994446327211402677L,
6872743052734703454L,
8833378985383245996L,
4066069233982031169L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5505932709647812166L,
5026803490311948054L,
3396863894694453773L,
},
},
            new Int64bigintArray1M
{
    Id = 27,
    Value = 
new System.Int64[4]
{
8832345607346889462L,
4890762111446563586L,
9147825161480248008L,
1942772735357510891L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 21,
    Value = 
new System.Int64[4]
{
2561256830729946033L,
1295805622687979349L,
9100458947283191726L,
188668655826364106L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7585311541606806884L,
3202724285741689746L,
7346354462510016757L,
4455956270826493801L,
},
},
            new Int64bigintArray1M
{
    Id = 33,
    Value = 
new System.Int64[3]
{
943218631320690346L,
802035661059364171L,
4202962841563823347L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 41,
    Value = 
new System.Int64[3]
{
2447517665714984107L,
1286068329348338420L,
2974968210003677124L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 23,
    Value = 
new System.Int64[3]
{
4220141827982387576L,
6550430727829688193L,
3457550705543254393L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8647477640820570435L,
4533575805712125673L,
2830209922023357714L,
},
},
            new Int64bigintArray1M
{
    Id = 50,
    Value = 
new System.Int64[3]
{
3485333893850454592L,
3440461896748704230L,
9069540089596513894L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 55,
    Value = 
new System.Int64[4]
{
1471311140108685818L,
897448258842042417L,
7020904626832056133L,
6314816573226993270L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[3]
{
2545112187091219651L,
6606683118322695010L,
1805918103874657533L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[4]
{
2153009067933106574L,
8369202571296251453L,
2387113034187711203L,
103513115315832313L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
1486610509945348293L,
5565198749509246680L,
7696711171136059354L,
9190522580405180652L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 30,
    Value = 
new System.Int64[3]
{
3435406559835895490L,
4898933409348039541L,
7584397681760988384L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 74,
    Value = 
new System.Int64[4]
{
5804275320547348655L,
6524380852494215360L,
4309512693614166554L,
6796068405608043647L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[3]
{
2664982213119002010L,
6053608998869016903L,
6131374049964259101L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[3]
{
8466735899299279191L,
5811308040822477113L,
8940778275113600516L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7132157239817559702L,
5687365786318377445L,
916378194168478378L,
1634153053726719141L,
},
},
            new Int64bigintArray1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
7603826396913864259L,
105508751121724314L,
6761575233735881902L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8282719457671846788L,
6122402514375066995L,
1847107824768030283L,
},
},
            new Int64bigintArray1M
{
    Id = 89,
    Value = 
new System.Int64[4]
{
3737629747251759740L,
2128353235775927688L,
6836717649394205646L,
221543035541845142L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 35,
    Value = 
new System.Int64[3]
{
2799862233277032396L,
7559443059233535265L,
1205921131624503881L,
},
    NullableValue = 
new System.Int64[4]
{
2554333555662038893L,
7037769581334804066L,
8301688223831949475L,
724829199448560468L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 94,
    Value = 
new System.Int64[3]
{
5761137359182169638L,
7600396794054261504L,
4745155800976585783L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5965635299495719126L,
3167405102075201490L,
2490554419676943045L,
},
},
            new Int64bigintArray1M
{
    Id = 99,
    Value = 
new System.Int64[4]
{
5225398712367498833L,
8429090578149166516L,
3158888485057902863L,
6696088200039043377L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 41,
    Value = 
new System.Int64[3]
{
6348753362790636756L,
3438025499171930038L,
897560335719129884L,
},
    NullableValue = 
new System.Int64[4]
{
7619065840455128625L,
5450458451918932014L,
3641124154490903910L,
7141448577397876706L,
},
},
    NullableValue = 
new System.Int64[4]
{
1233336856157577152L,
4895305845139817422L,
5737570457072247817L,
1619755714671695526L,
},
},
            new Int64bigintArray1M
{
    Id = 103,
    Value = 
new System.Int64[4]
{
2469214208613092430L,
5266650614124919391L,
3243813452648434037L,
4863774235746098607L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 108,
    Value = 
new System.Int64[4]
{
4787620069145103803L,
3553363598665021234L,
6273396984809437047L,
5396966877881980740L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
5544115350054469924L,
5335459774827907461L,
4496473211689312499L,
8679637798842338645L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4190570355112364765L,
7091187084607153171L,
4105005503429775400L,
5423580730583959979L,
},
},
            new Int64bigintArray1M
{
    Id = 113,
    Value = 
new System.Int64[3]
{
3163957008966464077L,
6327615368777059659L,
8893810082429329870L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4199495074863998510L,
2438221234671083896L,
2005240201257964362L,
},
},
            new Int64bigintArray1M
{
    Id = 120,
    Value = 
new System.Int64[4]
{
5530388422392526102L,
3977949819598435756L,
1783296455148610165L,
5485780153183594648L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 47,
    Value = 
new System.Int64[4]
{
4571932994434561605L,
1137177592919944327L,
5295173308505387813L,
5692318857047420819L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1075750358098041509L,
8731504262882015707L,
197844654357585046L,
},
},
            new Int64bigintArray1M
{
    Id = 127,
    Value = 
new System.Int64[4]
{
1220152213977419101L,
6675108565987389645L,
4747132991536627690L,
6802715471171435568L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8733275804068443966L,
5086538937860930396L,
1748004491590405435L,
},
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
4350957944493106659L,
8637798355335367514L,
6523169947498953989L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
6738987538385843750L,
1905598940190218986L,
6365005743834857359L,
},
    NullableValue = 
new System.Int64[4]
{
8327731945913752126L,
1766678869189493106L,
8916267556027185850L,
3548087723687202095L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 141,
    Value = 
new System.Int64[4]
{
2632403515610136448L,
4500820099870482460L,
747121145460609616L,
1599065155789756616L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 144,
    Value = 
new System.Int64[4]
{
3166525922274292873L,
2440467203894118728L,
6794018206819433623L,
3779451146685788453L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 51,
    Value = 
new System.Int64[3]
{
6459261130402893770L,
8680019603784209275L,
9170964415202655377L,
},
    NullableValue = 
new System.Int64[3]
{
4557478824550312066L,
7197821515078390363L,
6638981014886862040L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 150,
    Value = 
new System.Int64[4]
{
2078314627937214154L,
7843330763509624389L,
8471608368156950529L,
2818432037192026451L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 151,
    Value = 
new System.Int64[3]
{
9129052702099688802L,
5766739774565737045L,
5098307382888367823L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 60,
    Value = 
new System.Int64[4]
{
8120554815131493054L,
1345146572881632780L,
5044753489386668659L,
8115501002466059058L,
},
    NullableValue = 
new System.Int64[3]
{
3590345012808527862L,
7177401392351420463L,
7454738872316043203L,
},
},
    NullableValue = 
new System.Int64[4]
{
6275297291318054317L,
3265705062360554912L,
9071765699068357694L,
2839287168723205252L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4709192354213838921L,
4431381989573788992L,
4480968461104960322L,
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
new System.Int64[4]
{
6208691486220084813L,
3634652390989115769L,
1140293188619810871L,
2237941547480486561L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5505932709647812166L,
5026803490311948054L,
3396863894694453773L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
7585311541606806884L,
3202724285741689746L,
7346354462510016757L,
4455956270826493801L,
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
8647477640820570435L,
4533575805712125673L,
2830209922023357714L,
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
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[7], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Int64bigintArray1M.AssertModel(models[0],_testData[21], false);Int64bigintArray1M.AssertModel(models[1],_testData[22], false);Int64bigintArray1M.AssertModel(models[2],_testData[23], false);Int64bigintArray1M.AssertModel(models[3],_testData[24], false);Int64bigintArray1M.AssertModel(models[4],_testData[25], false);Int64bigintArray1M.AssertModel(models[5],_testData[26], false);Int64bigintArray1M.AssertModel(models[6],_testData[27], false);Int64bigintArray1M.AssertModel(models[7],_testData[28], false);Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Int64bigintArray1M.AssertModel(models[0],_testData[5], false);Int64bigintArray1M.AssertModel(models[1],_testData[6], false);Int64bigintArray1M.AssertModel(models[2],_testData[7], false);Int64bigintArray1M.AssertModel(models[3],_testData[8], false);Int64bigintArray1M.AssertModel(models[4],_testData[9], false);Int64bigintArray1M.AssertModel(models[5],_testData[10], false);Int64bigintArray1M.AssertModel(models[6],_testData[11], false);Int64bigintArray1M.AssertModel(models[7],_testData[12], false);Int64bigintArray1M.AssertModel(models[8],_testData[13], false);Int64bigintArray1M.AssertModel(models[9],_testData[14], false);Int64bigintArray1M.AssertModel(models[10],_testData[15], false);Int64bigintArray1M.AssertModel(models[11],_testData[16], false);Int64bigintArray1M.AssertModel(models[12],_testData[17], false);Int64bigintArray1M.AssertModel(models[13],_testData[18], false);Int64bigintArray1M.AssertModel(models[14],_testData[19], false);Int64bigintArray1M.AssertModel(models[15],_testData[20], false);Int64bigintArray1M.AssertModel(models[16],_testData[21], false);Int64bigintArray1M.AssertModel(models[17],_testData[22], false);Int64bigintArray1M.AssertModel(models[18],_testData[23], false);Int64bigintArray1M.AssertModel(models[19],_testData[24], false);Int64bigintArray1M.AssertModel(models[20],_testData[25], false);Int64bigintArray1M.AssertModel(models[21],_testData[26], false);Int64bigintArray1M.AssertModel(models[22],_testData[27], false);Int64bigintArray1M.AssertModel(models[23],_testData[28], false);Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
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

                var models =  ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
Int64bigintArray1M.AssertModel(models[0],_testData[26], false);Int64bigintArray1M.AssertModel(models[1],_testData[27], false);Int64bigintArray1M.AssertModel(models[2],_testData[28], false);Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Int64bigintArray1M.AssertModel(models[0],_testData[17], false);Int64bigintArray1M.AssertModel(models[1],_testData[18], false);Int64bigintArray1M.AssertModel(models[2],_testData[19], false);Int64bigintArray1M.AssertModel(models[3],_testData[20], false);Int64bigintArray1M.AssertModel(models[4],_testData[21], false);Int64bigintArray1M.AssertModel(models[5],_testData[22], false);Int64bigintArray1M.AssertModel(models[6],_testData[23], false);Int64bigintArray1M.AssertModel(models[7],_testData[24], false);Int64bigintArray1M.AssertModel(models[8],_testData[25], false);Int64bigintArray1M.AssertModel(models[9],_testData[26], false);Int64bigintArray1M.AssertModel(models[10],_testData[27], false);Int64bigintArray1M.AssertModel(models[11],_testData[28], false);Int64bigintArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
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
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 82, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[6], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[7], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[22],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatchAsync(connection, 113, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Int64bigintArray1M.AssertModel(models[0],_testData[23], false);Int64bigintArray1M.AssertModel(models[1],_testData[24], false);Int64bigintArray1M.AssertModel(models[2],_testData[25], false);Int64bigintArray1M.AssertModel(models[3],_testData[26], false);Int64bigintArray1M.AssertModel(models[4],_testData[27], false);Int64bigintArray1M.AssertModel(models[5],_testData[28], false);Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int64bigintArray1M.AssertModel(models[0],_testData[7], false);Int64bigintArray1M.AssertModel(models[1],_testData[8], false);Int64bigintArray1M.AssertModel(models[2],_testData[9], false);Int64bigintArray1M.AssertModel(models[3],_testData[10], false);Int64bigintArray1M.AssertModel(models[4],_testData[11], false);Int64bigintArray1M.AssertModel(models[5],_testData[12], false);Int64bigintArray1M.AssertModel(models[6],_testData[13], false);Int64bigintArray1M.AssertModel(models[7],_testData[14], false);Int64bigintArray1M.AssertModel(models[8],_testData[15], false);Int64bigintArray1M.AssertModel(models[9],_testData[16], false);Int64bigintArray1M.AssertModel(models[10],_testData[17], false);Int64bigintArray1M.AssertModel(models[11],_testData[18], false);Int64bigintArray1M.AssertModel(models[12],_testData[19], false);Int64bigintArray1M.AssertModel(models[13],_testData[20], false);Int64bigintArray1M.AssertModel(models[14],_testData[21], false);Int64bigintArray1M.AssertModel(models[15],_testData[22], false);Int64bigintArray1M.AssertModel(models[16],_testData[23], false);Int64bigintArray1M.AssertModel(models[17],_testData[24], false);Int64bigintArray1M.AssertModel(models[18],_testData[25], false);Int64bigintArray1M.AssertModel(models[19],_testData[26], false);Int64bigintArray1M.AssertModel(models[20],_testData[27], false);Int64bigintArray1M.AssertModel(models[21],_testData[28], false);Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
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
                var models =  ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatch(connection, 141, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
Int64bigintArray1M.AssertModel(models[0],_testData[27], false);Int64bigintArray1M.AssertModel(models[1],_testData[28], false);Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int64bigintArray1M.AssertModel(models[0],_testData[6], false);Int64bigintArray1M.AssertModel(models[1],_testData[7], false);Int64bigintArray1M.AssertModel(models[2],_testData[8], false);Int64bigintArray1M.AssertModel(models[3],_testData[9], false);Int64bigintArray1M.AssertModel(models[4],_testData[10], false);Int64bigintArray1M.AssertModel(models[5],_testData[11], false);Int64bigintArray1M.AssertModel(models[6],_testData[12], false);Int64bigintArray1M.AssertModel(models[7],_testData[13], false);Int64bigintArray1M.AssertModel(models[8],_testData[14], false);Int64bigintArray1M.AssertModel(models[9],_testData[15], false);Int64bigintArray1M.AssertModel(models[10],_testData[16], false);Int64bigintArray1M.AssertModel(models[11],_testData[17], false);Int64bigintArray1M.AssertModel(models[12],_testData[18], false);Int64bigintArray1M.AssertModel(models[13],_testData[19], false);Int64bigintArray1M.AssertModel(models[14],_testData[20], false);Int64bigintArray1M.AssertModel(models[15],_testData[21], false);Int64bigintArray1M.AssertModel(models[16],_testData[22], false);Int64bigintArray1M.AssertModel(models[17],_testData[23], false);Int64bigintArray1M.AssertModel(models[18],_testData[24], false);Int64bigintArray1M.AssertModel(models[19],_testData[25], false);Int64bigintArray1M.AssertModel(models[20],_testData[26], false);Int64bigintArray1M.AssertModel(models[21],_testData[27], false);Int64bigintArray1M.AssertModel(models[22],_testData[28], false);Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int64bigintArray1M.AssertModel(models[0],_testData[3], false);Int64bigintArray1M.AssertModel(models[1],_testData[4], false);Int64bigintArray1M.AssertModel(models[2],_testData[5], false);Int64bigintArray1M.AssertModel(models[3],_testData[6], false);Int64bigintArray1M.AssertModel(models[4],_testData[7], false);Int64bigintArray1M.AssertModel(models[5],_testData[8], false);Int64bigintArray1M.AssertModel(models[6],_testData[9], false);Int64bigintArray1M.AssertModel(models[7],_testData[10], false);Int64bigintArray1M.AssertModel(models[8],_testData[11], false);Int64bigintArray1M.AssertModel(models[9],_testData[12], false);Int64bigintArray1M.AssertModel(models[10],_testData[13], false);Int64bigintArray1M.AssertModel(models[11],_testData[14], false);Int64bigintArray1M.AssertModel(models[12],_testData[15], false);Int64bigintArray1M.AssertModel(models[13],_testData[16], false);Int64bigintArray1M.AssertModel(models[14],_testData[17], false);Int64bigintArray1M.AssertModel(models[15],_testData[18], false);Int64bigintArray1M.AssertModel(models[16],_testData[19], false);Int64bigintArray1M.AssertModel(models[17],_testData[20], false);Int64bigintArray1M.AssertModel(models[18],_testData[21], false);Int64bigintArray1M.AssertModel(models[19],_testData[22], false);Int64bigintArray1M.AssertModel(models[20],_testData[23], false);Int64bigintArray1M.AssertModel(models[21],_testData[24], false);Int64bigintArray1M.AssertModel(models[22],_testData[25], false);Int64bigintArray1M.AssertModel(models[23],_testData[26], false);Int64bigintArray1M.AssertModel(models[24],_testData[27], false);Int64bigintArray1M.AssertModel(models[25],_testData[28], false);Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Int64bigintArray1M.AssertModel(models[0],_testData[22], false);Int64bigintArray1M.AssertModel(models[1],_testData[23], false);Int64bigintArray1M.AssertModel(models[2],_testData[24], false);Int64bigintArray1M.AssertModel(models[3],_testData[25], false);Int64bigintArray1M.AssertModel(models[4],_testData[26], false);Int64bigintArray1M.AssertModel(models[5],_testData[27], false);Int64bigintArray1M.AssertModel(models[6],_testData[28], false);Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
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

