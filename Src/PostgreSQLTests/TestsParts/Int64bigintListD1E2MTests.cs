

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
454330475101216342L,

3225553791071819240L,

2465680620672655082L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7855662797332960057L,

1360701484059920640L,

1664368628839492341L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1309097991613291480L,

4826263285235042877L,

6497327035752456067L,

814365431370321018L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4342508940517861571L,

3412120018501708485L,

3716667888817047403L,

8684512016323530204L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
528780559193045726L,

5275173246151917820L,

9121599937249549660L,

6599927415289518981L,

},
},
            new Int64bigintListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6997591288772957451L,

3817643344821747702L,

8958232313234011515L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3076695909413892070L,

2990935560949930545L,

6462329904840685221L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6873624104767766047L,

1376972810581261674L,

2251663202787610029L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7398649190014576756L,

4824701602700380449L,

6997032527628805020L,

8768438943952408491L,

},
},
            new Int64bigintListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4968036826238637189L,

5363313057146123439L,

7148985830191472115L,

1414921419337708303L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
435897651285633713L,

8217285206618843273L,

5264637794386379159L,

3340760979205776717L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4741720953512901907L,

3556678064451511371L,

3993958806518429233L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3765310794850128287L,

5026476094172694248L,

4360476069688183698L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4833489753392152991L,

961474676537030096L,

2980200244480719236L,

507841350100945815L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2645513993333981479L,

1548328406098406065L,

6215738257471605337L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4372100863688719869L,

115854192497048011L,

2326510660844063018L,

},
},
            new Int64bigintListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5154039758735719207L,

3171806066787941945L,

6640380451202843480L,

3283815320654455299L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4868489708336419725L,

2358921916222998062L,

866858537801934666L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6962736425922137809L,

3886396685278241111L,

2739856118006709440L,

4428539697102441914L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7315497159122340168L,

1170351898999725493L,

2671573089793399877L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9001302343655212892L,

9080090699253149825L,

8994004286649933741L,

},
},
            new Int64bigintListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1278788721911289581L,

7241478011014444407L,

68447936808825059L,

7651480084719458248L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2618260739685765139L,

5004180190369834275L,

2324323001427269299L,

},
},
            new Int64bigintListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4720982820571334541L,

225725847269516260L,

4334836743010110120L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4616201441213759970L,

4275526696976741821L,

2414095231445192412L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5501225074038394217L,

7451193853958298565L,

6700776146843188430L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8966940451259756282L,

6185589899698222640L,

312880034450718379L,

4553453620486185040L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
164180437266806741L,

309406951002722034L,

2690985140930723099L,

812583162973175150L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2164523184282758544L,

7680355512555710886L,

8505959659505725099L,

7014798178994075730L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8784285793225977495L,

6261501930147200732L,

603141793800378603L,

8984111610131311150L,

},
},
            new Int64bigintListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6777839924740508654L,

4771851690092542409L,

4695916216443981814L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2580427977990789150L,

9025830441125568295L,

1321189186919272998L,

8700196619729045495L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6194154145433662561L,

4517313741078078764L,

3389965968190115227L,

8450870797798697461L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
945857843424146301L,

8350633619875843646L,

8446811015215271357L,

},
},
            new Int64bigintListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1809464914013933409L,

4408090650751550798L,

1661930970436600689L,

6644494800449438725L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1772305332658569634L,

482647739941083L,

4840845996758452439L,

2218768283534143545L,

},
},
            new Int64bigintListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8075750354497543597L,

8404303286972054879L,

3749022386777107815L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2770045503061371493L,

7915684124984938340L,

6285509869511178223L,

7255975184743227005L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5014189492469762364L,

736239475904413416L,

2097825581054327222L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1591454316187174283L,

9093414221853294342L,

4691322538758952698L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
65632255485465792L,

5352504482527490806L,

8044292692537912734L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4857142530362683658L,

4880440610049332180L,

5330072449674408837L,

1138743265616640097L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8210015740418043417L,

7173423242294152784L,

884037763827071877L,

7093139291081932338L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4716172667818122215L,

8052924451999049485L,

1780572284179840698L,

8754826495969401330L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8346680523973727944L,

2059426682413400064L,

5467610660177435662L,

5779826845620227373L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4409546443270568633L,

4649314196570121685L,

1508228773540488813L,

3934864803486052089L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1982472294344046639L,

925716346024704774L,

6168276362969642797L,

},
},
            new Int64bigintListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
879570467143580785L,

1883351865921340580L,

8049922200417804826L,

5778991609418188891L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2755949172114823122L,

8043233164309354946L,

5127509338727986913L,

6073544727347735663L,

},
},
            new Int64bigintListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6518031279162047690L,

4341539287673299270L,

3071495584562265773L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6909148966591734459L,

6290789267992295032L,

3408782184911453064L,

3242749296378327144L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2332427622347717243L,

2422212933191775411L,

3507381873198308658L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6315504436235791094L,

3413016299741866748L,

6299256880655826779L,

6724792316416270845L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3287181032360920395L,

3668455561334291963L,

7597292830640207871L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8968593947610343319L,

8721728813529897260L,

5925265670828555990L,

5022174803154406890L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3159772648343679287L,

8299473196383432416L,

360672244586150246L,

},
},
            new Int64bigintListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5487465148780006178L,

6786448336702057047L,

4176137869194467994L,

613388686665264463L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
760762246677359051L,

6963649400076344673L,

9093948078577512926L,

2464236164626612881L,

},
},
            new Int64bigintListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6936625839561956717L,

7362159984720269940L,

2366688283701040219L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2235105239636894294L,

3506913605187484873L,

924923076214728319L,

2624460969114845760L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2411361167436761018L,

1198313949499916640L,

5981325023024596340L,

9027700491816896936L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
655867258378275661L,

8902771998818337283L,

360938452678824196L,

},
},
            new Int64bigintListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3852136724498684725L,

4955180064836479406L,

7999392696109116617L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1045105215455967676L,

6102209544167290346L,

8665209722898900699L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8550748700100446680L,

7339747408765224749L,

2066379959767439025L,

1970484413014250651L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1729509780420108350L,

5524182062815369185L,

8020025223688429883L,

},
},
            new Int64bigintListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7795037379168318420L,

6162796297916792839L,

7875842506296835618L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7196084030915740981L,

3283803461631753134L,

3615122621965477245L,

2806466105903966952L,

},
},
            new Int64bigintListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
157836834022392609L,

5806803538873897703L,

5797947872157751773L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5988475241850214343L,

2086445193622213153L,

3878413347571414019L,

4029737833893235814L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4738605670047913146L,

6933979102736090588L,

1835548423165897106L,

},
},
            new Int64bigintListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8929786826357189367L,

3776475575612092396L,

8063678491673668344L,

6386011850299069733L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8793454158049710032L,

8046937627929545797L,

3623942717562957594L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6005671460875904366L,

8685542255477792805L,

6906691913135528732L,

651676002730171399L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8804421531237379786L,

2184840596087318153L,

7192702704460169014L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3132336751687559603L,

7156286174873161116L,

7812582207648211070L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5987169344839966083L,

3649267741444759101L,

2165448393342991974L,

},
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 92;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 83, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 83, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 138, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 6, query2))
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[33],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 147, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[2], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[3], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[4], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[5], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[6], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[7], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[8], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[9], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[10], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[11], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[12], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[13], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[14], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[15], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[19],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[20],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[21],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[22],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[23],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[24],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[25],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[26],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[27],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[28],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[29],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[30],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[31],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

