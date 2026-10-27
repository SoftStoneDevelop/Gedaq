

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
    Id = 3,
    Value = 
new System.Int64[4]
{
6900960705691349225L,
8596548499016489517L,
7544249247113018683L,
2506817234814616498L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
411023803312578375L,
3496787589658233193L,
8357630239719695841L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Int64[3]
{
6049866460754492836L,
1467212681760741212L,
3720041596251607643L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Int64[3]
{
6319900607204520651L,
5267710388895619388L,
1632974862674669545L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1848403366394032301L,
2094330514749530510L,
7141427768232772590L,
8012712996380367607L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
2439928617359979242L,
146068116636199757L,
8026709681938838351L,
6575271508818113463L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int64[4]
{
4436769213419433496L,
1482131618423148238L,
5763106508238108396L,
3244701939402053922L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
1198316063945583781L,
6277748818952800355L,
3385990348690030837L,
3586509732553956078L,
},
    NullableValue = 
new System.Int64[4]
{
1852439148117621554L,
6044825193196274702L,
6050668335144902677L,
6379457221860306812L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int64[4]
{
1258914010506197494L,
5131553086601271186L,
5444893107798553106L,
412675509778869459L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int64[4]
{
265039006664912861L,
1025345131526338485L,
6445422166263308257L,
8561634050428132497L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
3187020076572981663L,
8877406347001877384L,
521841565879968231L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4453604751667732316L,
601773316017852775L,
4552011231673014279L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[4]
{
5656077522848283753L,
2399777414617808520L,
893821639771363470L,
8423973509546328022L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4590967517560487484L,
8825588680421745128L,
4546748509520738208L,
8295342501533563404L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int64[3]
{
2478067002805171440L,
6223535297913032792L,
5340096837551922540L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int64[4]
{
1380400696363587339L,
1663931474069848537L,
5236417107684016565L,
2007474672992888238L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7294780332890815590L,
5198314852764179884L,
4403908862750907416L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[3]
{
765122066333032625L,
1986190696079200287L,
3063536407894943158L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
7614388866322639823L,
173345288736068886L,
3071831347699220242L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
7523088497664282300L,
2848594143384725687L,
2048336805000482004L,
1610637116459197959L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
941564851339358863L,
2661644492287526122L,
4312285379021544090L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int64[3]
{
7534702910297135426L,
8973370220277463776L,
5903182502775151013L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
8137731797175587518L,
7219497389550593001L,
5466613022794969737L,
6665638232953915041L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Int64[3]
{
8515889638604195079L,
7184352926738664449L,
4073301072217735333L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int64[3]
{
5274629746782727581L,
7255238383535142418L,
7949363851646108779L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1007360469035006377L,
6328625990278041852L,
3840264343125525469L,
4666374643025745836L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int64[3]
{
1097183150618722550L,
1859679237264230999L,
6497361329172588932L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
6414839812387802802L,
8315886079613814221L,
6282766200053519296L,
3019902912092988723L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int64[4]
{
9133737585062736671L,
5767146972512851820L,
5714772835071976081L,
3016298725389903822L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int64[3]
{
744526281674562588L,
3882747404155151853L,
1562236671312170963L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int64[4]
{
1197348273442738991L,
8657907528479278080L,
7605037488729368917L,
3292686180333326680L,
},
    NullableValue = 
new System.Int64[4]
{
2363724845316094046L,
7251438779364659253L,
9135621010174944467L,
713660149176182666L,
},
},
    NullableValue = 
new System.Int64[4]
{
7474335921162921529L,
8102156321942872027L,
4904596284764865582L,
1605409003724718327L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
6612251823898369450L,
5046189100819881156L,
5545568344555457884L,
5153864146200643415L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int64[3]
{
4844737270499708274L,
6391951639811831367L,
8754985529452802856L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Int64[4]
{
6592214583586554977L,
2353630518190159886L,
4763422947746190683L,
3690188668419231922L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2082434179852560801L,
1336141428303263745L,
2656257666828797839L,
1170942317501592448L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Int64[4]
{
9192259365088627297L,
9178701922626323112L,
8718254730190902421L,
5240762156270917005L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3700463573117384357L,
6596833989135226716L,
7794651522332803597L,
3606478705915684990L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Int64[4]
{
6638084094220313370L,
2162689116975084033L,
2466717622274896616L,
5146813742284565899L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
5630173675032927674L,
8771941784720960024L,
2185650991837082599L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2218228428315781678L,
4728571063018698630L,
6275073630188278108L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int64[4]
{
542003126910932728L,
7787339979653149848L,
7497344981778582920L,
232595781889083703L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2082085366604591494L,
5693156662625919014L,
9188577577852898081L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int64[3]
{
6490051235848971787L,
4142699107157409914L,
4739794541308614834L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[3]
{
1529792787277334127L,
6936619058395896861L,
825271564987108993L,
},
    NullableValue = 
new System.Int64[3]
{
9051104047611836234L,
1373603432845160894L,
1418471240751418078L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Int64[4]
{
6007814747231789346L,
499294258850852601L,
6611373436321020163L,
2592478772445980415L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Int64[4]
{
672802502000114510L,
6081728498762728366L,
7876948338283966037L,
1697875980705547274L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int64[4]
{
3210689939502888244L,
7346087381083380979L,
2795295467442401260L,
8044732672264985019L,
},
    NullableValue = 
new System.Int64[4]
{
4968393546476005889L,
2458222342160325718L,
8123211092917729240L,
5763399299520780111L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
8956280014617874680L,
7245350294348267784L,
5266999596227528085L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4747515591545404610L,
4848266100124722872L,
5108475225550722896L,
5142846100547725458L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int64[4]
{
3152904526273454363L,
2081956315352110609L,
747287998085583299L,
5542601234852643300L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int64[3]
{
8384952554568526142L,
2159625696484811727L,
3423724713435739978L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6980743220144207889L,
4920342305349396650L,
2454208522240216042L,
6677540754455470474L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[4]
{
1345138151452990112L,
7236670795853772781L,
5945562132102345613L,
17141819401090393L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7984120870588403220L,
6243889480894215783L,
5848186346040868143L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Int64[3]
{
5222236419184872647L,
2462087843007496298L,
3279235161029479998L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Int64[3]
{
8583508317062437336L,
5387173778487292500L,
1876781523278497449L,
},
    NullableValue = 
new System.Int64[4]
{
4679499483666099476L,
8477004381587286717L,
9059113921450588292L,
1664219534473830543L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
330092150821344609L,
7700928656629283228L,
2509361825012731562L,
2363916350419179622L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3706192346549585903L,
6473885256551036081L,
601521308959470225L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int64[3]
{
739768446390344377L,
658849124050005558L,
742506410686567006L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int64[3]
{
4789515111887790154L,
6990823396039776944L,
5953006190234707112L,
},
    NullableValue = 
new System.Int64[4]
{
1605478302257148194L,
7598581640552284219L,
4218268128563503929L,
8534159424696237957L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int64[4]
{
3220278855249972234L,
7726065970235198420L,
5577263705031811324L,
7921992611715900014L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8841445839860880441L,
6587293321096589931L,
6552056355850503340L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
916611561612409980L,
3052991521474777126L,
6067123445688256879L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Int64[3]
{
6791103926008427882L,
6144904790640200344L,
3642814061705608080L,
},
    NullableValue = 
new System.Int64[3]
{
3188631483945612739L,
8571777084571142923L,
8331744111378412408L,
},
},
    NullableValue = 
new System.Int64[3]
{
6656815757980863460L,
8708338173187602768L,
945624188708697234L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Int64[3]
{
1426602325063457466L,
7108467647111787322L,
5732783725776126731L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1850457362310319043L,
7380564434118151441L,
8303829959804259453L,
4561138389375849326L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Int64[3]
{
8153928072860690157L,
9125884778587602109L,
5364788098093867006L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int64[4]
{
2770325568408438292L,
5597664629030450495L,
1185843780214976133L,
3966782409155538943L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8457518123510682808L,
2175219754045681021L,
3614453047535570015L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
1118717574370518573L,
5483201948057558398L,
3943391418367820884L,
},
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4453604751667732316L,
601773316017852775L,
4552011231673014279L,
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4590967517560487484L,
8825588680421745128L,
4546748509520738208L,
8295342501533563404L,
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
7294780332890815590L,
5198314852764179884L,
4403908862750907416L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
941564851339358863L,
2661644492287526122L,
4312285379021544090L,
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
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
                parametr1.Value = 19;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 95, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 57, 6))
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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

