

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3477228268769963d, y: 0.7456543872013471d), radius: 0.11104392032499932d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732117858175214d, y: 0.7662405451436475d), radius: 0.1599982945687729d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1815596536301729d, y: 0.8215616528676706d), radius: 0.25340036056205584d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0012815699371167d, y: 0.4158238968899809d), radius: 0.9032997314778772d),
},
            new NpgsqlCirclecircle0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18620657224071768d, y: 0.28738864848455814d), radius: 0.2761991049567277d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24176611653991043d, y: 0.5092553723577633d), radius: 0.8176153346010135d),
},
            new NpgsqlCirclecircle0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9619269790194109d, y: 0.7355476933025107d), radius: 0.6578500211856101d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5893548114891505d, y: 0.021321874698093546d), radius: 0.2385428770808038d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9974710064416434d, y: 0.407027037585709d), radius: 0.5560726334899639d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058537777957707426d, y: 0.20181025975836742d), radius: 0.25935368802861447d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692608470240547d, y: 0.48911234133687d), radius: 0.9183661486746829d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9972806411676046d, y: 0.039264641993132954d), radius: 0.09541227181999568d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.572738984287762d, y: 0.6924584370657628d), radius: 0.5536195744573555d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46685315401611205d, y: 0.31294356096874054d), radius: 0.3138119783662112d),
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35582135904839085d, y: 0.5330207619372233d), radius: 0.32115050829808534d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572320764221576d, y: 0.5577466671531629d), radius: 0.8266059314740082d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32311516617583d, y: 0.23978348013338668d), radius: 0.34757889370992145d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25529961229202813d, y: 0.8056187895100921d), radius: 0.8625024058606549d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8282941622718704d, y: 0.8921964971048145d), radius: 0.23548927227249172d),
},
            new NpgsqlCirclecircle0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15316180749212394d, y: 0.7471762644003644d), radius: 0.7228961272122958d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03513328969724938d, y: 0.7209653516754893d), radius: 0.42573735400452795d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8890790560380726d, y: 0.5037107866210535d), radius: 0.8854032314637381d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09627010757897203d, y: 0.6202559149567218d), radius: 0.5187724900389472d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4305605078286534d, y: 0.5484601687939258d), radius: 0.08456864705771938d),
},
            new NpgsqlCirclecircle0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8563770274701871d, y: 0.2184508981071126d), radius: 0.44359857375317346d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399113858954951d, y: 0.3685181666767481d), radius: 0.15085935478582224d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08786451298354359d, y: 0.4815076393760357d), radius: 0.4331821371039304d),
},
            new NpgsqlCirclecircle0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852985051160195d, y: 0.21981432805589096d), radius: 0.8358083514595297d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3938613341913536d, y: 0.8014693369976441d), radius: 0.014885992538855475d),
},
            new NpgsqlCirclecircle0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1793070983634686d, y: 0.6018864831159599d), radius: 0.14488543442527468d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5333500003490683d, y: 0.8925614204191942d), radius: 0.7378156428310183d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534717361304941d, y: 0.5086094421103203d), radius: 0.630809499311886d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3608199369340228d, y: 0.3456222878263022d), radius: 0.6613552780208253d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42044574271032475d, y: 0.04293567152704214d), radius: 0.13317497372092535d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9527807154335964d, y: 0.015697907686402668d), radius: 0.9929789802024964d),
},
            new NpgsqlCirclecircle0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7642197509895302d, y: 0.816648377273485d), radius: 0.4416092768312172d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6227585651389548d, y: 0.850044875143235d), radius: 0.03088931324795785d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42717242621353435d, y: 0.2435163132207735d), radius: 0.1629658214817834d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.981468709226177d, y: 0.06963775558562801d), radius: 0.27576801744075596d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6368036883960551d, y: 0.3303900780347693d), radius: 0.7125338820334262d),
},
            new NpgsqlCirclecircle0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426031781025309d, y: 0.9423095887657741d), radius: 0.6675543265277141d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.729928397760339d, y: 0.787575009842169d), radius: 0.5636557860487995d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985413450102593d, y: 0.28496466055663994d), radius: 0.04301595004077796d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5178889867178919d, y: 0.35517242189285414d), radius: 0.06916053785039222d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4275761939938645d, y: 0.4404875364999572d), radius: 0.094876340035985d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6811290891983504d, y: 0.7206649827872522d), radius: 0.6772214326597825d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2652030136198944d, y: 0.04433915041124248d), radius: 0.5005452946063181d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8071439613811402d, y: 0.8712288988807159d), radius: 0.4745773595316436d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005731114435186702d, y: 0.6047606601876344d), radius: 0.31283863617121477d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1722247452937148d, y: 0.433413689133766d), radius: 0.9324293634694538d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4481631184686531d, y: 0.17246396972539024d), radius: 0.4467169591428194d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06218136061471036d, y: 0.15558461604416762d), radius: 0.42836947212437493d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001028359934147d, y: 0.2828952511199705d), radius: 0.5306534232172718d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791519413888692d, y: 0.3874044785430243d), radius: 0.9677483472952794d),
},
            new NpgsqlCirclecircle0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3128696101378504d, y: 0.12875547918109687d), radius: 0.553600748343553d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834946644084946d, y: 0.7467799904461425d), radius: 0.8767032748276843d),
},
            new NpgsqlCirclecircle0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3119763675828445d, y: 0.8555250308134322d), radius: 0.5529871659867817d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3629739489595625d, y: 0.29019932804104864d), radius: 0.21947562192468595d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7558289314608858d, y: 0.2872376334059683d), radius: 0.522746096342882d),
},
            new NpgsqlCirclecircle0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3804871384213977d, y: 0.017754094769981354d), radius: 0.2962416653974912d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17862561505052288d, y: 0.6932835846973273d), radius: 0.9713614995237325d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.969843099959219d, y: 0.09237788525286306d), radius: 0.014807002185343032d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4586236023452487d, y: 0.5014671718048382d), radius: 0.3885069275924813d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46685315401611205d, y: 0.31294356096874054d), radius: 0.3138119783662112d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8282941622718704d, y: 0.8921964971048145d), radius: 0.23548927227249172d)));
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4305605078286534d, y: 0.5484601687939258d), radius: 0.08456864705771938d)));
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08786451298354359d, y: 0.4815076393760357d), radius: 0.4331821371039304d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 104;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 54;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 42;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 58, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 102, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3477228268769963d, y: 0.7456543872013471d), radius: 0.11104392032499932d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732117858175214d, y: 0.7662405451436475d), radius: 0.1599982945687729d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1815596536301729d, y: 0.8215616528676706d), radius: 0.25340036056205584d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0012815699371167d, y: 0.4158238968899809d), radius: 0.9032997314778772d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18620657224071768d, y: 0.28738864848455814d), radius: 0.2761991049567277d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24176611653991043d, y: 0.5092553723577633d), radius: 0.8176153346010135d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9619269790194109d, y: 0.7355476933025107d), radius: 0.6578500211856101d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5893548114891505d, y: 0.021321874698093546d), radius: 0.2385428770808038d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9974710064416434d, y: 0.407027037585709d), radius: 0.5560726334899639d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058537777957707426d, y: 0.20181025975836742d), radius: 0.25935368802861447d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692608470240547d, y: 0.48911234133687d), radius: 0.9183661486746829d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9972806411676046d, y: 0.039264641993132954d), radius: 0.09541227181999568d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.572738984287762d, y: 0.6924584370657628d), radius: 0.5536195744573555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46685315401611205d, y: 0.31294356096874054d), radius: 0.3138119783662112d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35582135904839085d, y: 0.5330207619372233d), radius: 0.32115050829808534d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572320764221576d, y: 0.5577466671531629d), radius: 0.8266059314740082d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32311516617583d, y: 0.23978348013338668d), radius: 0.34757889370992145d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25529961229202813d, y: 0.8056187895100921d), radius: 0.8625024058606549d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8282941622718704d, y: 0.8921964971048145d), radius: 0.23548927227249172d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15316180749212394d, y: 0.7471762644003644d), radius: 0.7228961272122958d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03513328969724938d, y: 0.7209653516754893d), radius: 0.42573735400452795d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8890790560380726d, y: 0.5037107866210535d), radius: 0.8854032314637381d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09627010757897203d, y: 0.6202559149567218d), radius: 0.5187724900389472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4305605078286534d, y: 0.5484601687939258d), radius: 0.08456864705771938d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8563770274701871d, y: 0.2184508981071126d), radius: 0.44359857375317346d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399113858954951d, y: 0.3685181666767481d), radius: 0.15085935478582224d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08786451298354359d, y: 0.4815076393760357d), radius: 0.4331821371039304d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852985051160195d, y: 0.21981432805589096d), radius: 0.8358083514595297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3938613341913536d, y: 0.8014693369976441d), radius: 0.014885992538855475d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1793070983634686d, y: 0.6018864831159599d), radius: 0.14488543442527468d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5333500003490683d, y: 0.8925614204191942d), radius: 0.7378156428310183d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534717361304941d, y: 0.5086094421103203d), radius: 0.630809499311886d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3608199369340228d, y: 0.3456222878263022d), radius: 0.6613552780208253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42044574271032475d, y: 0.04293567152704214d), radius: 0.13317497372092535d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9527807154335964d, y: 0.015697907686402668d), radius: 0.9929789802024964d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7642197509895302d, y: 0.816648377273485d), radius: 0.4416092768312172d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6227585651389548d, y: 0.850044875143235d), radius: 0.03088931324795785d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42717242621353435d, y: 0.2435163132207735d), radius: 0.1629658214817834d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.981468709226177d, y: 0.06963775558562801d), radius: 0.27576801744075596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6368036883960551d, y: 0.3303900780347693d), radius: 0.7125338820334262d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426031781025309d, y: 0.9423095887657741d), radius: 0.6675543265277141d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.729928397760339d, y: 0.787575009842169d), radius: 0.5636557860487995d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985413450102593d, y: 0.28496466055663994d), radius: 0.04301595004077796d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5178889867178919d, y: 0.35517242189285414d), radius: 0.06916053785039222d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4275761939938645d, y: 0.4404875364999572d), radius: 0.094876340035985d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6811290891983504d, y: 0.7206649827872522d), radius: 0.6772214326597825d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2652030136198944d, y: 0.04433915041124248d), radius: 0.5005452946063181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8071439613811402d, y: 0.8712288988807159d), radius: 0.4745773595316436d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005731114435186702d, y: 0.6047606601876344d), radius: 0.31283863617121477d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1722247452937148d, y: 0.433413689133766d), radius: 0.9324293634694538d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4481631184686531d, y: 0.17246396972539024d), radius: 0.4467169591428194d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06218136061471036d, y: 0.15558461604416762d), radius: 0.42836947212437493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001028359934147d, y: 0.2828952511199705d), radius: 0.5306534232172718d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791519413888692d, y: 0.3874044785430243d), radius: 0.9677483472952794d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3128696101378504d, y: 0.12875547918109687d), radius: 0.553600748343553d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834946644084946d, y: 0.7467799904461425d), radius: 0.8767032748276843d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3119763675828445d, y: 0.8555250308134322d), radius: 0.5529871659867817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3629739489595625d, y: 0.29019932804104864d), radius: 0.21947562192468595d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7558289314608858d, y: 0.2872376334059683d), radius: 0.522746096342882d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3804871384213977d, y: 0.017754094769981354d), radius: 0.2962416653974912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17862561505052288d, y: 0.6932835846973273d), radius: 0.9713614995237325d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.969843099959219d, y: 0.09237788525286306d), radius: 0.014807002185343032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4586236023452487d, y: 0.5014671718048382d), radius: 0.3885069275924813d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3477228268769963d, y: 0.7456543872013471d), radius: 0.11104392032499932d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732117858175214d, y: 0.7662405451436475d), radius: 0.1599982945687729d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1815596536301729d, y: 0.8215616528676706d), radius: 0.25340036056205584d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0012815699371167d, y: 0.4158238968899809d), radius: 0.9032997314778772d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18620657224071768d, y: 0.28738864848455814d), radius: 0.2761991049567277d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24176611653991043d, y: 0.5092553723577633d), radius: 0.8176153346010135d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9619269790194109d, y: 0.7355476933025107d), radius: 0.6578500211856101d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5893548114891505d, y: 0.021321874698093546d), radius: 0.2385428770808038d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9974710064416434d, y: 0.407027037585709d), radius: 0.5560726334899639d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058537777957707426d, y: 0.20181025975836742d), radius: 0.25935368802861447d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692608470240547d, y: 0.48911234133687d), radius: 0.9183661486746829d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9972806411676046d, y: 0.039264641993132954d), radius: 0.09541227181999568d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.572738984287762d, y: 0.6924584370657628d), radius: 0.5536195744573555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46685315401611205d, y: 0.31294356096874054d), radius: 0.3138119783662112d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35582135904839085d, y: 0.5330207619372233d), radius: 0.32115050829808534d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572320764221576d, y: 0.5577466671531629d), radius: 0.8266059314740082d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32311516617583d, y: 0.23978348013338668d), radius: 0.34757889370992145d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25529961229202813d, y: 0.8056187895100921d), radius: 0.8625024058606549d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8282941622718704d, y: 0.8921964971048145d), radius: 0.23548927227249172d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15316180749212394d, y: 0.7471762644003644d), radius: 0.7228961272122958d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03513328969724938d, y: 0.7209653516754893d), radius: 0.42573735400452795d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8890790560380726d, y: 0.5037107866210535d), radius: 0.8854032314637381d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09627010757897203d, y: 0.6202559149567218d), radius: 0.5187724900389472d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4305605078286534d, y: 0.5484601687939258d), radius: 0.08456864705771938d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8563770274701871d, y: 0.2184508981071126d), radius: 0.44359857375317346d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399113858954951d, y: 0.3685181666767481d), radius: 0.15085935478582224d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08786451298354359d, y: 0.4815076393760357d), radius: 0.4331821371039304d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852985051160195d, y: 0.21981432805589096d), radius: 0.8358083514595297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3938613341913536d, y: 0.8014693369976441d), radius: 0.014885992538855475d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1793070983634686d, y: 0.6018864831159599d), radius: 0.14488543442527468d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5333500003490683d, y: 0.8925614204191942d), radius: 0.7378156428310183d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534717361304941d, y: 0.5086094421103203d), radius: 0.630809499311886d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3608199369340228d, y: 0.3456222878263022d), radius: 0.6613552780208253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42044574271032475d, y: 0.04293567152704214d), radius: 0.13317497372092535d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9527807154335964d, y: 0.015697907686402668d), radius: 0.9929789802024964d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7642197509895302d, y: 0.816648377273485d), radius: 0.4416092768312172d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6227585651389548d, y: 0.850044875143235d), radius: 0.03088931324795785d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42717242621353435d, y: 0.2435163132207735d), radius: 0.1629658214817834d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.981468709226177d, y: 0.06963775558562801d), radius: 0.27576801744075596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6368036883960551d, y: 0.3303900780347693d), radius: 0.7125338820334262d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426031781025309d, y: 0.9423095887657741d), radius: 0.6675543265277141d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.729928397760339d, y: 0.787575009842169d), radius: 0.5636557860487995d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985413450102593d, y: 0.28496466055663994d), radius: 0.04301595004077796d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5178889867178919d, y: 0.35517242189285414d), radius: 0.06916053785039222d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4275761939938645d, y: 0.4404875364999572d), radius: 0.094876340035985d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6811290891983504d, y: 0.7206649827872522d), radius: 0.6772214326597825d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2652030136198944d, y: 0.04433915041124248d), radius: 0.5005452946063181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8071439613811402d, y: 0.8712288988807159d), radius: 0.4745773595316436d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005731114435186702d, y: 0.6047606601876344d), radius: 0.31283863617121477d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1722247452937148d, y: 0.433413689133766d), radius: 0.9324293634694538d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4481631184686531d, y: 0.17246396972539024d), radius: 0.4467169591428194d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06218136061471036d, y: 0.15558461604416762d), radius: 0.42836947212437493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001028359934147d, y: 0.2828952511199705d), radius: 0.5306534232172718d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791519413888692d, y: 0.3874044785430243d), radius: 0.9677483472952794d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3128696101378504d, y: 0.12875547918109687d), radius: 0.553600748343553d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834946644084946d, y: 0.7467799904461425d), radius: 0.8767032748276843d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3119763675828445d, y: 0.8555250308134322d), radius: 0.5529871659867817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3629739489595625d, y: 0.29019932804104864d), radius: 0.21947562192468595d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7558289314608858d, y: 0.2872376334059683d), radius: 0.522746096342882d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3804871384213977d, y: 0.017754094769981354d), radius: 0.2962416653974912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17862561505052288d, y: 0.6932835846973273d), radius: 0.9713614995237325d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.969843099959219d, y: 0.09237788525286306d), radius: 0.014807002185343032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4586236023452487d, y: 0.5014671718048382d), radius: 0.3885069275924813d))));

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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0M>(15);

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
                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

