

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
    Id = 1,
    Value = 
new System.Int64[3]
{
3752047598719113170L,
6260085993404988137L,
363716525666178291L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Int64[3]
{
3991393861485011903L,
6533240408275643445L,
7822958333799894664L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int64[3]
{
6375494840083344666L,
2000475239326810412L,
3598854134456324053L,
},
    NullableValue = 
new System.Int64[4]
{
4189666170947107173L,
8812968154408109810L,
444740839719208914L,
4209141315690130345L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
1875330872381778323L,
691647117875132809L,
5269925910023897078L,
3797903561445474530L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8297851841802335564L,
2967049966424577513L,
8476992465608078026L,
5278825899531085352L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int64[3]
{
1542975592242689021L,
4986036139696083643L,
2600503492974708638L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int64[3]
{
1414609289022692855L,
5215585422592752549L,
2356535775014927880L,
},
    NullableValue = 
new System.Int64[4]
{
9140106255768630419L,
806743507152735338L,
2131339447481002837L,
2503380148568654014L,
},
},
    NullableValue = 
new System.Int64[3]
{
1436699895083951360L,
194130163966653821L,
9180316674289635778L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int64[4]
{
6296306990199930632L,
2625628679503138083L,
7940437322223604180L,
8188785080146974686L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Int64[3]
{
5903706379880201964L,
2595177597282353961L,
3905159157609122200L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int64[4]
{
2252867157348567915L,
6474189457855799618L,
2804732274584587847L,
8708439807982890128L,
},
    NullableValue = 
new System.Int64[3]
{
3030834663670005086L,
941654550749615135L,
2334914791534056854L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[4]
{
4985996954799468531L,
4827182860206277130L,
7149593399693622740L,
4183939750113433532L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1586734186191454951L,
4615035293264157077L,
4326952748817499369L,
7242407875612749699L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int64[4]
{
2440994485133427930L,
2909448046923511738L,
1223793891773860823L,
5410734081560382540L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int64[3]
{
5134700765991164518L,
6294694319699115813L,
2115510705645632712L,
},
    NullableValue = 
new System.Int64[3]
{
5818305883888122000L,
4064549998928900772L,
3879901108092950264L,
},
},
    NullableValue = 
new System.Int64[3]
{
6639635869620964955L,
4297167194612150077L,
7786790121464459653L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
6738846284130795442L,
3942739039772704728L,
2341566397146981150L,
1772419306130219316L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int64[4]
{
8194972932365356512L,
6137262570246102929L,
5604400489424926575L,
3797864583239876399L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[3]
{
3459538251879179548L,
8259677212769171662L,
1218046193306275184L,
},
    NullableValue = 
new System.Int64[4]
{
9167677405675967235L,
3610031854826569442L,
2587611702230720699L,
500140199268691197L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Int64[4]
{
7954835234380537844L,
138905788735929478L,
3471133041770753896L,
8509774948264876249L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4956067081114140911L,
4442268881405284008L,
8004151328796405100L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Int64[4]
{
3631820676713851004L,
1269387006938810400L,
818187171398816923L,
5786156163534127380L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Int64[3]
{
1259468582317769729L,
7462894333105066888L,
8371824892070203672L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
1144397860918956338L,
730690574191034048L,
6821728400293208793L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int64[3]
{
1031208949661783531L,
1909595612519957633L,
2625151803520797561L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int64[4]
{
507687826113116175L,
5373082491958981252L,
8975379268124515403L,
5433337160238483053L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8104216021664825908L,
8318997313084279256L,
3925606006628178281L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Int64[4]
{
1677969424900121287L,
963500877098787436L,
3858403285502772786L,
5350343511720132308L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[3]
{
5675591933367552868L,
8362938429327393382L,
2431689874422528253L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Int64[3]
{
7343567454420314909L,
5714114866978954269L,
5530179957053387237L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6537140988444878037L,
7638655104631165554L,
2652986562312682933L,
6147856849355192453L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Int64[3]
{
800767711850702430L,
267790182418603294L,
5447413843817854324L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
9143955482623738026L,
849935726967112237L,
2084312088440650580L,
999781420595349920L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int64[3]
{
2472829776278952360L,
2304855495417949097L,
2286700578441750278L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
3957828317726094789L,
4066859952642874875L,
4477196426990996791L,
6118762632259271632L,
},
    NullableValue = 
new System.Int64[4]
{
2447547500754782639L,
4465169084026853178L,
8244973472734730828L,
5397169924078749638L,
},
},
    NullableValue = 
new System.Int64[3]
{
4006148605284920537L,
1021960544502988010L,
5508142603435855931L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int64[3]
{
7418678860517124783L,
853983476514166358L,
4838940170547660973L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4939142594516994111L,
117559782675828646L,
2997246912760206022L,
3103973088966559668L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Int64[3]
{
3071065817842915013L,
2970106851504024922L,
6623144195572809440L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int64[3]
{
6647414899362219968L,
8573071157329372379L,
2605135232255948515L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Int64[4]
{
2061133215755637677L,
9098263222754842294L,
1088273481682789924L,
6708753781016207461L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4456999022655668352L,
362708849733551301L,
7272195100232022793L,
6356867983388262561L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Int64[3]
{
5497459297536460845L,
5891164119639811189L,
4251249315598133916L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int64[3]
{
2983374656278387878L,
2060748163614308385L,
6644929729905424048L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Int64[4]
{
1337789006254597909L,
2919688398617636357L,
3646479037551807819L,
1318043411023399036L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int64[3]
{
6438465267733871206L,
2662709485919888956L,
2374883221217099807L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int64[3]
{
5231952921770228191L,
7341681217217893939L,
6008138797178266117L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4704098249134980239L,
1616245920137050693L,
8899340494426256112L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int64[4]
{
596095785606403534L,
75312887656433959L,
3995658158136636186L,
417312475476996569L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3886599276064509333L,
4929267292851226284L,
4463202025011758282L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
2812520436566904242L,
2927354808365535708L,
6875374619295546767L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int64[3]
{
3826949598172211805L,
3477053886891525561L,
1156523963096264807L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int64[3]
{
4842131822184760315L,
5772523319072273734L,
2262209501707348670L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int64[3]
{
7610785435885210027L,
4003766753479060420L,
1521268319184807861L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int64[4]
{
8658478186692943094L,
7508211873606962388L,
4407338121362739657L,
9120573518340365780L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6897975935749998424L,
2493020378387331747L,
617636406971809612L,
6875366838176630433L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
6764067873983053312L,
1456855989168787552L,
8972024196734557451L,
7695180759562408876L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
251641243383317478L,
8292772941359034035L,
9160586962197529061L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
3709875035509519165L,
1824899850572694406L,
5392305867212651521L,
3870600886053063392L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int64[4]
{
5029643677057839819L,
8677127469779028220L,
3867738860397567616L,
8902120070701579576L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Int64[3]
{
4468958651679490235L,
7103927860637001862L,
3025648913002959463L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1513901085530356639L,
2390968727149233139L,
6296373299198829662L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int64[3]
{
4504524770867035526L,
6770868958456196565L,
2649048419569109280L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int64[4]
{
6362619546651738241L,
2173313122165662516L,
2964973041561539593L,
325254004049196739L,
},
    NullableValue = 
new System.Int64[4]
{
1887685259543468158L,
8644200408107953304L,
3142522385630628773L,
8043966483304142285L,
},
},
    NullableValue = 
new System.Int64[3]
{
5188283162418884380L,
114154324314801525L,
100926369216055368L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int64[3]
{
6904101337305323657L,
8559299761994915465L,
4849969120962166575L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3313403449404440706L,
7505774618836573822L,
3870023211146564763L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int64[3]
{
6379224979468331354L,
119689425806920692L,
4931292777454737891L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int64[4]
{
6157975407894635293L,
8650431568597990592L,
2707772737570214863L,
2815018982706929039L,
},
    NullableValue = 
new System.Int64[4]
{
1120593439899266768L,
5976853506949078930L,
7624587172536834832L,
3891321515480411325L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int64[3]
{
1597361160497896191L,
7825305823814341721L,
2139636334590832858L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2362807041171304382L,
5828174047419614826L,
2964208175142058629L,
},
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
1586734186191454951L,
4615035293264157077L,
4326952748817499369L,
7242407875612749699L,
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6639635869620964955L,
4297167194612150077L,
7786790121464459653L,
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
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4956067081114140911L,
4442268881405284008L,
8004151328796405100L,
}));
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
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
                parametr1.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 52;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 97, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 46, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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

