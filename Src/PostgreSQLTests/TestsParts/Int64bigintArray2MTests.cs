

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
    internal partial interface IInt64ListbigintArray
    {
    }
    
    internal partial class Int64ListbigintArray : IInt64ListbigintArray
    {


#region TestData

        private readonly Int64bigintArray2M[] _testData = new Int64bigintArray2M[]
        {
            new Int64bigintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8312501026839320750L,

6138509775060415751L,

8577941939941361643L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7842925973868485596L,

2771321726922598496L,

8242849861834385970L,

7349912591746912692L,

},
},
            new Int64bigintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5604048471772922317L,

1010194952549651435L,

5046920286652327053L,

1615311624886870460L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7155058357075851332L,

7590630980078406742L,

8969319845267769235L,

720860990219135943L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7590545488023251048L,

1998759769418850545L,

3830119332903667789L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7105366041357784135L,

587659990592698856L,

1081824475725815667L,

6540149598067128758L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2543136395300258134L,

389639412763677696L,

7134169292008304756L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3618951694969567034L,

148245040120319678L,

649574932448286967L,

7120188119535213866L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5175432850245844144L,

4195970082665714514L,

3097445302483030931L,

7847394597364956812L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8339090689220861110L,

3439765156213083810L,

8516263468978854244L,

7616279644264253984L,

},
},
            new Int64bigintArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4153414186352092388L,

3477574654426065968L,

504394122879775549L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4418521105601347349L,

891041954430350373L,

7356058657000639161L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5481635634464285109L,

4392639282443321107L,

3203988456397834380L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5035642268825962446L,

2811322657306666275L,

3054825561051152670L,

1437930888592210338L,

},
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1651639929275679232L,

6977549244248183500L,

6723550286303261971L,

2473917343471963021L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2299246265808716539L,

2890123671024728538L,

5176055551494263726L,

1466492750299591753L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5523906345546621518L,

5430840188709202234L,

2511228806299485238L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1047174409934396965L,

1773406476020220864L,

8918897987278912963L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7656998220579203686L,

3378408134534410634L,

316052455801758082L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1566939488926419956L,

8671349225956000526L,

1584183380665399351L,

1514384531929899447L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3507825284152238952L,

5998076491919435563L,

5832861926808841798L,

840699913310697422L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6739370425461331268L,

2989355419786042617L,

4034249428789539793L,

2572634466589556871L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6601182630762972215L,

8404031711431396348L,

1910591160894251221L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4016800457318958211L,

30434670921117704L,

9020490630864172522L,

},
},
            new Int64bigintArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3668339458108972200L,

6853687778077164019L,

1330517733056482369L,

6393715376571225178L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8185826727737549752L,

6580080258144731756L,

8993620806252220207L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3356057412805556175L,

6775511185550337753L,

5985037656415600751L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5339619734616611307L,

1522778907469475273L,

2424842308520580824L,

5315904390867564593L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1350237200067249809L,

6277093537835795334L,

1873488536242971604L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1661861086108573242L,

7822495725781788610L,

673921842997007599L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7072852347629205615L,

3133572877267908163L,

9012368784082799986L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9195418291294212108L,

7198889984543304833L,

2014779928378594379L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1277028646501127400L,

3078755538403628321L,

4009180782654714950L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5369347622258827865L,

4358230750903790999L,

1140982062219480911L,

5546218978687606892L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3188845904494464313L,

3823202582419105391L,

8438472202955738912L,

1435756873951903375L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4869891789304124788L,

4817045131385601095L,

919109586361751643L,

895942209587280676L,

},
},
            new Int64bigintArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
558579417997769548L,

2781357425967031641L,

5647614507720254299L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6781134368435439435L,

7603888585845701115L,

1188199560093407506L,

6856977532142758313L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7279076266684020965L,

7422057236782473861L,

710795607324981927L,

8973598528192928264L,

},
},
            new Int64bigintArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7819732163904858660L,

803164285550692160L,

8662450629941062230L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4430987368293706584L,

7954375531197237661L,

7673213220783436173L,

},
},
            new Int64bigintArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6162940341097657009L,

8082397070414774481L,

8676420909122184466L,

7184090891360429349L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4892127942126000593L,

7222216397129248445L,

6180063331520379478L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3740992010799454933L,

6034504501977503139L,

3340547212994057326L,

3260499391339394377L,

},
},
            new Int64bigintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5902067465531898636L,

5869182280562699308L,

7377609057871642625L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6764976013656479291L,

1445569806382786937L,

30585933843247535L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
421956857446996900L,

7202839509616935570L,

5135424096101616077L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5958961875049000098L,

542195667697295846L,

266480063490808327L,

},
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8558309460189643593L,

1843498094394617539L,

4215321915185957920L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3725164015043497762L,

7445470257727629651L,

372816175105268942L,

3098187590025620041L,

},
},
            new Int64bigintArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7982712994970661514L,

7993909218463988200L,

8104865687704471776L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7734139247475929907L,

1860174190121217648L,

2690409146670685831L,

3528542267351083389L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5837222972466870469L,

495995632497372331L,

5311156985979047072L,

},
},
            new Int64bigintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1737775566756812015L,

1938454615439192080L,

1239900464941429968L,

625323396885528823L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5563223957029231140L,

7643499442133835545L,

522378417040260390L,

8301741071998471022L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7180876167919058437L,

9039246807024978495L,

2673239608463096897L,

803681609201100288L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4274525045066854277L,

4347818742994067090L,

6801062390159876724L,

395530491729870501L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4323514736101131551L,

9138950663155413757L,

5312897708488901517L,

},
},
            new Int64bigintArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8423532295646544530L,

5979192741805457021L,

276305389134616460L,

5407364693437767026L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6345823083356100430L,

2037128562420879796L,

6027002083262005239L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6163899802333175786L,

6415028890001781770L,

6341414744423419030L,

7969037742464841425L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1643527797676211385L,

7635507880939520121L,

3888096573835029763L,

5028591856374580478L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8098740527006921352L,

5964909972981174771L,

5587942941820879992L,

1477391520446723870L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6888830294315724360L,

1915453151818106695L,

8996774753013921165L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
126585703744844580L,

4289053402276404221L,

4632089524472346220L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3687594822256635172L,

5403363020021458107L,

451581698316168171L,

},
},
            new Int64bigintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3090450909182964027L,

4557298525962830473L,

3936595471854894607L,

6875926985872752055L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7375353835384611547L,

6476009185804141705L,

6908237395433412692L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8551118724667077912L,

1019087006887744286L,

1643020741167267169L,

8328358181316561758L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1531407774935934688L,

2086676695786788571L,

8751650992120169875L,

3861740270380965134L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1601253461633453031L,

1994171067555238682L,

4688943271484869616L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8869182081500218919L,

5383326461608270101L,

1090406195790038399L,

3181842448767389302L,

},
},
            new Int64bigintArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8210339588966614596L,

1895555872602336392L,

6103765370197838123L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8753424320284063785L,

1735724225933225309L,

7856799441736304118L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3654598888608789328L,

3310885475918450208L,

1584834131756820732L,

5322353083536431385L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1713519072390701408L,

1117089939830321303L,

2493358317348049302L,

8452951326992315782L,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
            asPartInterface: typeof(IInt64ListbigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintArray2M.AssertModel(models[0],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray2M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int64bigintArray2M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 143, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray2M.AssertModel(models[0],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray2M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 93, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray2M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int64bigintArray2M.AssertModel(models[0],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[14], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[15], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[16], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[17], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[17],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[18],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[19],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[20],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[21],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[22],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[23],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[24],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[25],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[26],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[27],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray2M),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
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
FROM public.binary_int64bigintarray2m m
LEFT JOIN public.binary_int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models =  ((IInt64ListbigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI), typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                await ((IInt64ListbigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                ((IInt64ListbigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

