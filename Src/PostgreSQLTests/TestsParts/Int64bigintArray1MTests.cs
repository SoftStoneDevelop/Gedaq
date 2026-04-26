

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
2389193711114490880L,
5887466171054340973L,
7341680347921838575L,
185835486310307544L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7066159908023609663L,
3965149509638735480L,
910581043972207095L,
},
},
            new Int64bigintArray1M
{
    Id = 12,
    Value = 
new System.Int64[4]
{
1690751055630682641L,
7584827117849156155L,
2887849231357264117L,
7862139752391836258L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 9,
    Value = 
new System.Int64[3]
{
5088602473978802382L,
7688339435014219136L,
1396970697318713679L,
},
    NullableValue = 
new System.Int64[3]
{
3008671024209545890L,
3522046929124300169L,
1801607684046787666L,
},
},
    NullableValue = 
new System.Int64[4]
{
1504504762254553616L,
1708127486783173349L,
6520420979277161288L,
7220102251077274237L,
},
},
            new Int64bigintArray1M
{
    Id = 21,
    Value = 
new System.Int64[3]
{
8984044376586580498L,
3124720443754246386L,
6353757452895127914L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2188819955461831356L,
1877599299458672023L,
6391757391994629094L,
},
},
            new Int64bigintArray1M
{
    Id = 28,
    Value = 
new System.Int64[3]
{
317970683951664662L,
6739180308659886750L,
7909092272213945092L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 18,
    Value = 
new System.Int64[3]
{
6445410659570166608L,
8884528807873386922L,
8754220094450882386L,
},
    NullableValue = 
new System.Int64[4]
{
7322698419292288604L,
1012866792083133058L,
3687214792843423363L,
8631709432546305463L,
},
},
    NullableValue = 
new System.Int64[3]
{
5841388105452515561L,
3737732529598530536L,
5355558784730855695L,
},
},
            new Int64bigintArray1M
{
    Id = 37,
    Value = 
new System.Int64[4]
{
3301833349408896830L,
4493064109479509551L,
8568318036900997960L,
7059521422628535512L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1944695370231526146L,
4954037829959490916L,
7754019007380295111L,
3672234908031155071L,
},
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[3]
{
4911551508644579671L,
7538340392034415386L,
1919617255714308459L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 21,
    Value = 
new System.Int64[3]
{
700024238539440934L,
8943252636923264618L,
7009095282396879463L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
6760559331395538258L,
8905257301056203623L,
2813794870060116425L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 48,
    Value = 
new System.Int64[3]
{
1960432236987357405L,
3956886636615069789L,
3622017164888637071L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 22,
    Value = 
new System.Int64[4]
{
4711430938044520413L,
442566142305830642L,
4001672455613320026L,
5103167866824247617L,
},
    NullableValue = 
new System.Int64[4]
{
5080368011424908368L,
2204482213383570065L,
3925075533636934669L,
3897727870349007991L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 53,
    Value = 
new System.Int64[4]
{
2366036126344874650L,
3422556260173797690L,
8138212338682645876L,
4499319556781834304L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 58,
    Value = 
new System.Int64[3]
{
2311860659330201872L,
9029251630630037901L,
3834626968797575987L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
8550446610424058343L,
1694882356947138286L,
2954015098000715464L,
1520986044147942047L,
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
3678469102842775312L,
1470488685664602097L,
7690689897785991643L,
414042615573409906L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6901991698107420346L,
6202715081915224885L,
2511038749575017753L,
},
},
            new Int64bigintArray1M
{
    Id = 71,
    Value = 
new System.Int64[4]
{
3253347465221198582L,
6607033310870669894L,
5246330103775270909L,
2638751502607801562L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 32,
    Value = 
new System.Int64[3]
{
4554551730465761171L,
1400850699962012029L,
2090919788548358087L,
},
    NullableValue = 
new System.Int64[3]
{
7097427239577398730L,
7060796085777928622L,
9220956632333763166L,
},
},
    NullableValue = 
new System.Int64[3]
{
4857997328137409848L,
2329156406573485071L,
3181864605600964409L,
},
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[4]
{
8077499221829902722L,
4700622393861187643L,
3769868872527997107L,
5280331306106059061L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 81,
    Value = 
new System.Int64[3]
{
1424373043316989065L,
2100378933179044633L,
2750596040695114398L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[3]
{
8161558028791007623L,
7112723320926784162L,
8794962359188327483L,
},
    NullableValue = 
new System.Int64[3]
{
4269556376905056675L,
6084892654566807464L,
1064643780234504909L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[4]
{
1001926716073863182L,
8472085114914587048L,
5998457779772406477L,
3887483966286542548L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5046326395935827517L,
6818726475344112764L,
7954688243174560578L,
},
},
            new Int64bigintArray1M
{
    Id = 85,
    Value = 
new System.Int64[4]
{
5616341957792868381L,
2780840887241719010L,
1788319131418866722L,
2432008786584388343L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 42,
    Value = 
new System.Int64[4]
{
1079388700429115904L,
8926087305528897299L,
1234399014645127765L,
6675173559711457395L,
},
    NullableValue = 
new System.Int64[4]
{
6245095621855144108L,
8246905395402557751L,
1896900669403219961L,
135965903846942222L,
},
},
    NullableValue = 
new System.Int64[3]
{
1547721460611436576L,
7083148715905796467L,
4974455346880791444L,
},
},
            new Int64bigintArray1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
6289452596887260938L,
4740074993315438668L,
5316089817057723749L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
3829753089652486518L,
2441755070941998886L,
8480289863774543232L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[3]
{
7382914951240014644L,
1806367121357931668L,
973776534331929549L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 90,
    Value = 
new System.Int64[3]
{
6136535932040889595L,
8055350284147124074L,
3913042512314780056L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[3]
{
5162770941703948676L,
4138273839039656116L,
3614523907291034097L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 53,
    Value = 
new System.Int64[4]
{
2629070443452788603L,
5080289477723686140L,
7567795439064918994L,
6483637908482281037L,
},
    NullableValue = 
new System.Int64[4]
{
8979232961128060748L,
1628882078413368934L,
5667929910717784450L,
2937576533866314547L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 97,
    Value = 
new System.Int64[3]
{
1066676760600296618L,
1837153069232216861L,
5556855708552816319L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 100,
    Value = 
new System.Int64[3]
{
2131960718652756127L,
6284770405309451779L,
4897841540459791480L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
8403434897561343597L,
7104858959492220013L,
6940648032764262014L,
3942618676141240332L,
},
    NullableValue = 
new System.Int64[4]
{
2884830628659692652L,
3274112854352763594L,
651250092665071000L,
1631220143217087945L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
5799805323239852964L,
2389920426016437124L,
8030718356614494256L,
6242397872746375769L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8116641964815503622L,
8170200210627103974L,
5641699844448491450L,
300451789507872944L,
},
},
            new Int64bigintArray1M
{
    Id = 110,
    Value = 
new System.Int64[3]
{
5998001340841161930L,
1587079514984018213L,
2943679735126596880L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 67,
    Value = 
new System.Int64[4]
{
2127550563474732946L,
7449538020716955702L,
6099982902872163284L,
340587406203223404L,
},
    NullableValue = 
new System.Int64[3]
{
6804000639056417980L,
7013431551960437103L,
7967091701531767563L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 116,
    Value = 
new System.Int64[3]
{
1674799488372850027L,
4644373628608576714L,
455058442045356804L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5049413732154326829L,
3475995998180229811L,
4761908804037196191L,
},
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[4]
{
8247237483729654439L,
5140554145465834990L,
8565894250751814227L,
4958507839337766203L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 70,
    Value = 
new System.Int64[4]
{
2325861804242753098L,
3440362204505119596L,
2077768215806896422L,
7694661596886227714L,
},
    NullableValue = 
new System.Int64[4]
{
6073718633279066195L,
7834975571259324243L,
2198992651260506052L,
5321769627532969843L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[3]
{
545113611773299506L,
4108885162738766958L,
1334713554397357141L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3222077526483896714L,
4065080460982246919L,
7216002817040267445L,
4514977277618263355L,
},
},
            new Int64bigintArray1M
{
    Id = 131,
    Value = 
new System.Int64[3]
{
4723561236483570967L,
1593860318179562707L,
3246121774215169002L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 78,
    Value = 
new System.Int64[3]
{
6883008997108811754L,
7679141343721977087L,
7681170902537207908L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 137,
    Value = 
new System.Int64[3]
{
6696608028507168148L,
7772763403144683475L,
6585585524532217202L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
9025437758066490681L,
7935269306805974313L,
872582469458707865L,
9022996755001383536L,
},
},
            new Int64bigintArray1M
{
    Id = 143,
    Value = 
new System.Int64[4]
{
1064871491823000842L,
6278191260645153495L,
6615413573652391622L,
2878618722063074085L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 87,
    Value = 
new System.Int64[3]
{
3280676352597452479L,
81383620148734262L,
3366854506100733722L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3159119241308562850L,
1594953486730971758L,
7067522499787951832L,
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
new System.Int64[4]
{
1944695370231526146L,
4954037829959490916L,
7754019007380295111L,
3672234908031155071L,
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
new System.Int64[3]
{
6901991698107420346L,
6202715081915224885L,
2511038749575017753L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4857997328137409848L,
2329156406573485071L,
3181864605600964409L,
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                        Assert.That(models, Has.Count.EqualTo(7));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[3], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[4], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[5], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[6], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[7], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[22],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[23],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[24],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[25],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                        Assert.That(models, Has.Count.EqualTo(4));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 28;
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
                        Assert.That(models, Has.Count.EqualTo(26));
Int64bigintArray1M.AssertModel(models[0],_testData[4], false);Int64bigintArray1M.AssertModel(models[1],_testData[5], false);Int64bigintArray1M.AssertModel(models[2],_testData[6], false);Int64bigintArray1M.AssertModel(models[3],_testData[7], false);Int64bigintArray1M.AssertModel(models[4],_testData[8], false);Int64bigintArray1M.AssertModel(models[5],_testData[9], false);Int64bigintArray1M.AssertModel(models[6],_testData[10], false);Int64bigintArray1M.AssertModel(models[7],_testData[11], false);Int64bigintArray1M.AssertModel(models[8],_testData[12], false);Int64bigintArray1M.AssertModel(models[9],_testData[13], false);Int64bigintArray1M.AssertModel(models[10],_testData[14], false);Int64bigintArray1M.AssertModel(models[11],_testData[15], false);Int64bigintArray1M.AssertModel(models[12],_testData[16], false);Int64bigintArray1M.AssertModel(models[13],_testData[17], false);Int64bigintArray1M.AssertModel(models[14],_testData[18], false);Int64bigintArray1M.AssertModel(models[15],_testData[19], false);Int64bigintArray1M.AssertModel(models[16],_testData[20], false);Int64bigintArray1M.AssertModel(models[17],_testData[21], false);Int64bigintArray1M.AssertModel(models[18],_testData[22], false);Int64bigintArray1M.AssertModel(models[19],_testData[23], false);Int64bigintArray1M.AssertModel(models[20],_testData[24], false);Int64bigintArray1M.AssertModel(models[21],_testData[25], false);Int64bigintArray1M.AssertModel(models[22],_testData[26], false);Int64bigintArray1M.AssertModel(models[23],_testData[27], false);Int64bigintArray1M.AssertModel(models[24],_testData[28], false);Int64bigintArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int64bigintArray1M.AssertModel(models[0],_testData[2], false);Int64bigintArray1M.AssertModel(models[1],_testData[3], false);Int64bigintArray1M.AssertModel(models[2],_testData[4], false);Int64bigintArray1M.AssertModel(models[3],_testData[5], false);Int64bigintArray1M.AssertModel(models[4],_testData[6], false);Int64bigintArray1M.AssertModel(models[5],_testData[7], false);Int64bigintArray1M.AssertModel(models[6],_testData[8], false);Int64bigintArray1M.AssertModel(models[7],_testData[9], false);Int64bigintArray1M.AssertModel(models[8],_testData[10], false);Int64bigintArray1M.AssertModel(models[9],_testData[11], false);Int64bigintArray1M.AssertModel(models[10],_testData[12], false);Int64bigintArray1M.AssertModel(models[11],_testData[13], false);Int64bigintArray1M.AssertModel(models[12],_testData[14], false);Int64bigintArray1M.AssertModel(models[13],_testData[15], false);Int64bigintArray1M.AssertModel(models[14],_testData[16], false);Int64bigintArray1M.AssertModel(models[15],_testData[17], false);Int64bigintArray1M.AssertModel(models[16],_testData[18], false);Int64bigintArray1M.AssertModel(models[17],_testData[19], false);Int64bigintArray1M.AssertModel(models[18],_testData[20], false);Int64bigintArray1M.AssertModel(models[19],_testData[21], false);Int64bigintArray1M.AssertModel(models[20],_testData[22], false);Int64bigintArray1M.AssertModel(models[21],_testData[23], false);Int64bigintArray1M.AssertModel(models[22],_testData[24], false);Int64bigintArray1M.AssertModel(models[23],_testData[25], false);Int64bigintArray1M.AssertModel(models[24],_testData[26], false);Int64bigintArray1M.AssertModel(models[25],_testData[27], false);Int64bigintArray1M.AssertModel(models[26],_testData[28], false);Int64bigintArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray1M.AssertModel(models[0],_testData[20], false);Int64bigintArray1M.AssertModel(models[1],_testData[21], false);Int64bigintArray1M.AssertModel(models[2],_testData[22], false);Int64bigintArray1M.AssertModel(models[3],_testData[23], false);Int64bigintArray1M.AssertModel(models[4],_testData[24], false);Int64bigintArray1M.AssertModel(models[5],_testData[25], false);Int64bigintArray1M.AssertModel(models[6],_testData[26], false);Int64bigintArray1M.AssertModel(models[7],_testData[27], false);Int64bigintArray1M.AssertModel(models[8],_testData[28], false);Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Int64bigintArray1M.AssertModel(models[0],_testData[4], false);Int64bigintArray1M.AssertModel(models[1],_testData[5], false);Int64bigintArray1M.AssertModel(models[2],_testData[6], false);Int64bigintArray1M.AssertModel(models[3],_testData[7], false);Int64bigintArray1M.AssertModel(models[4],_testData[8], false);Int64bigintArray1M.AssertModel(models[5],_testData[9], false);Int64bigintArray1M.AssertModel(models[6],_testData[10], false);Int64bigintArray1M.AssertModel(models[7],_testData[11], false);Int64bigintArray1M.AssertModel(models[8],_testData[12], false);Int64bigintArray1M.AssertModel(models[9],_testData[13], false);Int64bigintArray1M.AssertModel(models[10],_testData[14], false);Int64bigintArray1M.AssertModel(models[11],_testData[15], false);Int64bigintArray1M.AssertModel(models[12],_testData[16], false);Int64bigintArray1M.AssertModel(models[13],_testData[17], false);Int64bigintArray1M.AssertModel(models[14],_testData[18], false);Int64bigintArray1M.AssertModel(models[15],_testData[19], false);Int64bigintArray1M.AssertModel(models[16],_testData[20], false);Int64bigintArray1M.AssertModel(models[17],_testData[21], false);Int64bigintArray1M.AssertModel(models[18],_testData[22], false);Int64bigintArray1M.AssertModel(models[19],_testData[23], false);Int64bigintArray1M.AssertModel(models[20],_testData[24], false);Int64bigintArray1M.AssertModel(models[21],_testData[25], false);Int64bigintArray1M.AssertModel(models[22],_testData[26], false);Int64bigintArray1M.AssertModel(models[23],_testData[27], false);Int64bigintArray1M.AssertModel(models[24],_testData[28], false);Int64bigintArray1M.AssertModel(models[25],_testData[29], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[8], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[9], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[10], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[11], false);FlatInt64bigintArray1M.AssertModel(models[4],_testData[12], false);FlatInt64bigintArray1M.AssertModel(models[5],_testData[13], false);FlatInt64bigintArray1M.AssertModel(models[6],_testData[14], false);FlatInt64bigintArray1M.AssertModel(models[7],_testData[15], false);FlatInt64bigintArray1M.AssertModel(models[8],_testData[16], false);FlatInt64bigintArray1M.AssertModel(models[9],_testData[17], false);FlatInt64bigintArray1M.AssertModel(models[10],_testData[18], false);FlatInt64bigintArray1M.AssertModel(models[11],_testData[19], false);FlatInt64bigintArray1M.AssertModel(models[12],_testData[20], false);FlatInt64bigintArray1M.AssertModel(models[13],_testData[21], false);FlatInt64bigintArray1M.AssertModel(models[14],_testData[22], false);FlatInt64bigintArray1M.AssertModel(models[15],_testData[23], false);FlatInt64bigintArray1M.AssertModel(models[16],_testData[24], false);FlatInt64bigintArray1M.AssertModel(models[17],_testData[25], false);FlatInt64bigintArray1M.AssertModel(models[18],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[19],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[20],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatchAsync(connection, 126, 93))
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
                        Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray1M.AssertModel(models[0],_testData[20], false);Int64bigintArray1M.AssertModel(models[1],_testData[21], false);Int64bigintArray1M.AssertModel(models[2],_testData[22], false);Int64bigintArray1M.AssertModel(models[3],_testData[23], false);Int64bigintArray1M.AssertModel(models[4],_testData[24], false);Int64bigintArray1M.AssertModel(models[5],_testData[25], false);Int64bigintArray1M.AssertModel(models[6],_testData[26], false);Int64bigintArray1M.AssertModel(models[7],_testData[27], false);Int64bigintArray1M.AssertModel(models[8],_testData[28], false);Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatch(connection, 42, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int64bigintArray1M.AssertModel(models[0],_testData[6], false);Int64bigintArray1M.AssertModel(models[1],_testData[7], false);Int64bigintArray1M.AssertModel(models[2],_testData[8], false);Int64bigintArray1M.AssertModel(models[3],_testData[9], false);Int64bigintArray1M.AssertModel(models[4],_testData[10], false);Int64bigintArray1M.AssertModel(models[5],_testData[11], false);Int64bigintArray1M.AssertModel(models[6],_testData[12], false);Int64bigintArray1M.AssertModel(models[7],_testData[13], false);Int64bigintArray1M.AssertModel(models[8],_testData[14], false);Int64bigintArray1M.AssertModel(models[9],_testData[15], false);Int64bigintArray1M.AssertModel(models[10],_testData[16], false);Int64bigintArray1M.AssertModel(models[11],_testData[17], false);Int64bigintArray1M.AssertModel(models[12],_testData[18], false);Int64bigintArray1M.AssertModel(models[13],_testData[19], false);Int64bigintArray1M.AssertModel(models[14],_testData[20], false);Int64bigintArray1M.AssertModel(models[15],_testData[21], false);Int64bigintArray1M.AssertModel(models[16],_testData[22], false);Int64bigintArray1M.AssertModel(models[17],_testData[23], false);Int64bigintArray1M.AssertModel(models[18],_testData[24], false);Int64bigintArray1M.AssertModel(models[19],_testData[25], false);Int64bigintArray1M.AssertModel(models[20],_testData[26], false);Int64bigintArray1M.AssertModel(models[21],_testData[27], false);Int64bigintArray1M.AssertModel(models[22],_testData[28], false);Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Int64bigintArray1M.AssertModel(models[0],_testData[26], false);Int64bigintArray1M.AssertModel(models[1],_testData[27], false);Int64bigintArray1M.AssertModel(models[2],_testData[28], false);Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int64bigintArray1M.AssertModel(models[0],_testData[3], false);Int64bigintArray1M.AssertModel(models[1],_testData[4], false);Int64bigintArray1M.AssertModel(models[2],_testData[5], false);Int64bigintArray1M.AssertModel(models[3],_testData[6], false);Int64bigintArray1M.AssertModel(models[4],_testData[7], false);Int64bigintArray1M.AssertModel(models[5],_testData[8], false);Int64bigintArray1M.AssertModel(models[6],_testData[9], false);Int64bigintArray1M.AssertModel(models[7],_testData[10], false);Int64bigintArray1M.AssertModel(models[8],_testData[11], false);Int64bigintArray1M.AssertModel(models[9],_testData[12], false);Int64bigintArray1M.AssertModel(models[10],_testData[13], false);Int64bigintArray1M.AssertModel(models[11],_testData[14], false);Int64bigintArray1M.AssertModel(models[12],_testData[15], false);Int64bigintArray1M.AssertModel(models[13],_testData[16], false);Int64bigintArray1M.AssertModel(models[14],_testData[17], false);Int64bigintArray1M.AssertModel(models[15],_testData[18], false);Int64bigintArray1M.AssertModel(models[16],_testData[19], false);Int64bigintArray1M.AssertModel(models[17],_testData[20], false);Int64bigintArray1M.AssertModel(models[18],_testData[21], false);Int64bigintArray1M.AssertModel(models[19],_testData[22], false);Int64bigintArray1M.AssertModel(models[20],_testData[23], false);Int64bigintArray1M.AssertModel(models[21],_testData[24], false);Int64bigintArray1M.AssertModel(models[22],_testData[25], false);Int64bigintArray1M.AssertModel(models[23],_testData[26], false);Int64bigintArray1M.AssertModel(models[24],_testData[27], false);Int64bigintArray1M.AssertModel(models[25],_testData[28], false);Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
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

