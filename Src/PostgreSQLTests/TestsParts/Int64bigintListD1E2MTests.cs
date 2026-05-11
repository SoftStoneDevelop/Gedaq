

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
    internal partial interface IInt64ListbigintListD1
    {
    }
    
    internal partial class Int64ListbigintListD1 : IInt64ListbigintListD1
    {


#region TestData

        private readonly Int64bigintListD1E2M[] _testData = new Int64bigintListD1E2M[]
        {
            new Int64bigintListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7984535514664924602L,

1793181964045860216L,

2021242504805549389L,

8208348121971780702L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4779896797570323065L,

57547094691099148L,

1901624070375266880L,

},
},
            new Int64bigintListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1887826263826631004L,

7263817532661596049L,

6514013993739252289L,

5950154012087300521L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
575856252385186615L,

5312223836496753275L,

2360159466122967307L,

8452821889319333656L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7370939807200606815L,

8060649392957046362L,

3324472815969253750L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
720667845326227563L,

792893303281921692L,

675956396934601439L,

8430656172710071703L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4395925318787059185L,

2729638463678316150L,

2425439105109497998L,

23321009055599312L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
254954789110129152L,

7431031353568683916L,

403898306160472965L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8787016939517292235L,

7110517005272062579L,

5249519303575579909L,

6252148288937339793L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8404039308609236496L,

3643356011806228137L,

7152309102370295388L,

5570806682826624025L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1676551009272778728L,

718609617169459596L,

8545866392416175047L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5542122610990145566L,

9108363450243608135L,

8034595563901789335L,

2978574053919323306L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
459636748535513013L,

7480817621350771439L,

5498252020373375851L,

},
},
            new Int64bigintListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4323774708564763302L,

2572908498548767199L,

4527002180857369793L,

2181030669177437018L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8385032991744164649L,

1408970102688781552L,

4607800231281677267L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2721193883823034569L,

3511894659918541310L,

7330050223781078435L,

372437519409527839L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1658571120318234737L,

4363792089640019928L,

846577720576135977L,

7032533989454681026L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2007942067698728517L,

4664667721412153306L,

941320378425342064L,

2735401130055966907L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8169595743151096365L,

4470656820720905484L,

2927058763233869423L,

7394073917932400818L,

},
},
            new Int64bigintListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1270173165680187994L,

6829489351548371391L,

6391995613649367155L,

3217429191005446507L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6543018914661024560L,

8425211768334045223L,

5806045413691273105L,

3216664289729838084L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7953090058093942174L,

3364376793010339796L,

6710599834703832879L,

2688110632453403680L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4138076829471722431L,

7509969401780223440L,

7201955933574170300L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4538320581045182498L,

5876570252317950051L,

3060021388089618104L,

5406098120670481719L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7285681611440638797L,

5180798451844109414L,

5873709196642315126L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8402577257709800435L,

7305541226113368223L,

6291205782827417694L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1029265365697785045L,

6202893043071062882L,

1232825411537797169L,

},
},
            new Int64bigintListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4700923371256000777L,

3578016467717837736L,

2429908114424138513L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3001542410506348562L,

2647119385539532865L,

4858993753053882762L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3535592553646964840L,

4666944508197499231L,

6217242693194983375L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5782455232183983488L,

448457683214912132L,

6771525679491140138L,

},
},
            new Int64bigintListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5725988028768110168L,

6827490255198386758L,

1940898118964381770L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4922350793735464841L,

2092778125579468439L,

1930660159570360123L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5391355725235009655L,

4952505232753693318L,

3579051473157068698L,

7754537454966949123L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6162201327884112402L,

924112985540131658L,

5955658698070571970L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4147085192766545347L,

6694124386318256356L,

2916912894286233150L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2643854810865540098L,

2940410317298380493L,

8087412698614190921L,

5887490692217881303L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2667355776321338492L,

345557991238329969L,

6515397455192793381L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2411437012950298699L,

4814412845853953038L,

5252276265680431159L,

1722992214501165470L,

},
},
            new Int64bigintListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6639821304541898254L,

7418996336408225823L,

1369024628395646311L,

4785372422033841149L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9095033686529002765L,

3277050857512752184L,

6646630397180147129L,

},
},
            new Int64bigintListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3326770399377144437L,

3546112117999937166L,

8953098592428812214L,

5865859412069741167L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6452178675300862640L,

640920622231222622L,

7572687815724704185L,

1264916250543241155L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5251194943047352927L,

6112626942849362191L,

728837171902701162L,

7230169774729946695L,

},
},
            new Int64bigintListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3758487520456567865L,

298203516096907736L,

1947200900423786233L,

7211255458134916239L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8794294684119852747L,

4461999984435127012L,

3468526878339286023L,

1010806632143259094L,

},
},
            new Int64bigintListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3897172163917262846L,

5443973911003010510L,

2530997264825755774L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5303101305490359668L,

5935970679828966719L,

2710891151467487997L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4770421881098221002L,

7420158428265663459L,

5586225292275990628L,

5924264076029646181L,

},
},
            new Int64bigintListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1144565314755850630L,

3135289396137931398L,

3811043793463452771L,

6095987712469052292L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5955269189122765043L,

7868400607998258565L,

7835227628115573327L,

},
},
            new Int64bigintListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5207111378380129553L,

225482583492282352L,

4179181767474962529L,

3224372051251103196L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6959925557015845455L,

398821960464244071L,

1068303729097449878L,

894776175761079393L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8246523249690812652L,

649034115161073973L,

470356388079555523L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7551432127509259577L,

7487547710987644910L,

8245968923777616645L,

},
},
            new Int64bigintListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8437853206927904537L,

7127484694116436696L,

1919509980175616460L,

4638673700828975620L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8837574485514148335L,

4120755444494804915L,

5235128032552349206L,

5237438812748890973L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
420783215550006582L,

4137769591530713276L,

8819887353412450057L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3436324346593370926L,

9157075320776368260L,

2657569413369072531L,

3743108179880770611L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
440220684140412237L,

3121770807583588429L,

4564832111232218373L,

},
},
            new Int64bigintListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6547839247651379516L,

102493487761061142L,

1786982216620564262L,

4501183659822731468L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7498064758961688895L,

2603898982677351813L,

5926344885286428132L,

4670154516234662729L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
436593237073592179L,

8514578562810619497L,

6131503666232387557L,

3673733536664955607L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2941065485764907475L,

4789376227945165580L,

6851000478563618523L,

8952782873185863446L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3725670831459399003L,

9017908002094018290L,

7612753547956205372L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4107108978918836231L,

4710759499882409174L,

3268587530189560295L,

6189800977057429746L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4371618054708436130L,

1561520149996897090L,

6110499020477440251L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2593882950385026583L,

2503908975239274506L,

1566811204548432861L,

5883344569188456913L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5262393638767912848L,

2359799496432083205L,

6706780314997727384L,

4357870023927930078L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4619436997125276116L,

6232201006106639771L,

4697195717226293157L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4871037481304070328L,

3911032687507933589L,

3381221412675667425L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1982410005972828351L,

749038407535254371L,

3925411001480154346L,

439382323198238138L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1944053887158335161L,

6100682505401186942L,

1693798281358012152L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2275198002550058314L,

8501127611943479570L,

8077502122412208818L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
601176718330466860L,

6582603131424250395L,

7675738109170175725L,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2mi(
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
INSERT INTO public.int64bigintlistd1e2mi(
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
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
            asPartInterface: typeof(IInt64ListbigintListD1)), 
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
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                List<Int64bigintListD1E2M> models = null;

                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintListD1E2M> models = null;

                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 170;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[4], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[5], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[6], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[28],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[29],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[5], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[6], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[28],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 187, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 45, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 98, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 151, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 178, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 178))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 160, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[7], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[8], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[9], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[10], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[11], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[12], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[13], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[14], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[15], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[19],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[20],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[21],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[22],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[23],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[24],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[25],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[26],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MI),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintListD1E2M),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
FROM public.binary_int64bigintlistd1e2m m
LEFT JOIN public.binary_int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models =  ((IInt64ListbigintListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI), typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                await ((IInt64ListbigintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                ((IInt64ListbigintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

