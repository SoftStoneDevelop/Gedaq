

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3325261379518558d, b: 0.12266475187146197d, c: 0.34477878092779246d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05670694428446976d, b: 0.9477624776506917d, c: 0.35552080129293395d),
},
            new NpgsqlLineline0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6595022670319598d, b: 0.694443427401111d, c: 0.9017854397162502d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20137269473905095d, b: 0.03895458864298973d, c: 0.26465496840608227d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.03486485255302085d, b: 0.37775187291438217d, c: 0.7573571351760975d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4471721211152757d, b: 0.9711300168594986d, c: 0.5953434947327029d),
},
            new NpgsqlLineline0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.38810061559495035d, b: 0.2328868131711802d, c: 0.24278106882631012d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9657452940366116d, b: 0.14830851176625104d, c: 0.9269963296815017d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20976324711946903d, b: 0.0906208040902533d, c: 0.4510824029427646d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9006790773588522d, b: 0.28669765585186135d, c: 0.6231441724647895d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.49852011192328494d, b: 0.7132047500233203d, c: 0.08291914884911944d),
},
            new NpgsqlLineline0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8908133875551758d, b: 0.04137055131968781d, c: 0.35239679390122425d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9170923892937914d, b: 0.7703412620333829d, c: 0.04138676714955203d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7837448809139799d, b: 0.2412821266109928d, c: 0.09177857476115847d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8221932067792652d, b: 0.8439507814828837d, c: 0.3790138184735492d),
},
            new NpgsqlLineline0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.76668601159252d, b: 0.031104210667907806d, c: 0.30245936802401385d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1506933020013539d, b: 0.26774122860534066d, c: 0.8589308876954784d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17456609070664664d, b: 0.3583849935405897d, c: 0.5428554884841705d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10082565671686239d, b: 0.7041973555359902d, c: 0.8082593444830998d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7204397916533064d, b: 0.12385210766838994d, c: 0.7055633767423265d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40157215719442163d, b: 0.2443075301528469d, c: 0.9986740532760107d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8214122237825475d, b: 0.6909042759239757d, c: 0.5651840145914572d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14892504977118315d, b: 0.6645084669638756d, c: 0.29012206204024704d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29744822818962224d, b: 0.24027183420418896d, c: 0.8358654652662478d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1942126373523061d, b: 0.4611681622442133d, c: 0.5131210925124243d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.641360174584705d, b: 0.3115519914080155d, c: 0.8779338345606673d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23540104840848053d, b: 0.5377723742561962d, c: 0.051215064480100936d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37015495907874085d, b: 0.48449407850892d, c: 0.6233532267545645d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20321336830450631d, b: 0.6934766703888289d, c: 0.6828987319255885d),
},
            new NpgsqlLineline0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6447145845035046d, b: 0.9807073038067327d, c: 0.2895712894419359d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.27936162587688684d, b: 0.39664373538507136d, c: 0.13981587865574951d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4317716941039771d, b: 0.3934358913983199d, c: 0.9513374945003541d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.03346110542892833d, b: 0.2256583747755314d, c: 0.9206528379888905d),
},
            new NpgsqlLineline0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7356975654769226d, b: 0.3868243276832767d, c: 0.9871948107504686d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6443462635813388d, b: 0.9230535924011072d, c: 0.04211643694111711d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12473510445105218d, b: 0.7968709896587974d, c: 0.998406539723536d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.13369457584992173d, b: 0.5484051199444008d, c: 0.5114069197733657d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2587249731630128d, b: 0.5490389864558765d, c: 0.49366090703756504d),
},
            new NpgsqlLineline0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3888914468052673d, b: 0.09000976442918263d, c: 0.6135540998983083d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1276498912018319d, b: 0.44482077012658106d, c: 0.15129632864428222d),
},
            new NpgsqlLineline0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0324126103649367d, b: 0.4348666554457231d, c: 0.1558997049342865d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9604913735695539d, b: 0.45766264419126557d, c: 0.6213724685897616d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3214448978526159d, b: 0.27052205725080236d, c: 0.8739421502189243d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6239242086745838d, b: 0.40509921133640303d, c: 0.7399095276132387d),
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2759467383619265d, b: 0.7628493494587631d, c: 0.0878458202443061d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.25833652349686453d, b: 0.2055022324572463d, c: 0.720927708173913d),
},
            new NpgsqlLineline0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.11926102975329189d, b: 0.7542702860173018d, c: 0.4803606812831066d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5743060328858084d, b: 0.47802022890601337d, c: 0.8972186867216969d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7123768904537078d, b: 0.05072440987095339d, c: 0.31828036971503615d),
},
            new NpgsqlLineline0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3916317526697267d, b: 0.4794616797549176d, c: 0.2410710602301196d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9543746398215484d, b: 0.01603436570978456d, c: 0.3725359253598248d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5462073344480499d, b: 0.6366885560581581d, c: 0.057297909108482536d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6887002419350978d, b: 0.5000584519170513d, c: 0.20800941097564707d),
},
            new NpgsqlLineline0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.667410585517988d, b: 0.45104448335220704d, c: 0.11527946803040823d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3214277013549037d, b: 0.41901735043180266d, c: 0.26087462050644694d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.32365812399878613d, b: 0.8834078060702754d, c: 0.9574398390052846d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4888969800902496d, b: 0.19450032130591122d, c: 0.636431459714213d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23285793456695836d, b: 0.49806800538433826d, c: 0.9522719666018313d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.733253310068621d, b: 0.3857846334720767d, c: 0.5264985205047683d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9726828864639621d, b: 0.7545204794546734d, c: 0.6927332172833388d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5863293165341262d, b: 0.7404195662088853d, c: 0.24732459967672915d),
},
            new NpgsqlLineline0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6541461034296788d, b: 0.24738382611010268d, c: 0.25920710834746896d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4761406037822521d, b: 0.5426787735558347d, c: 0.44960251439699483d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2223123749769027d, b: 0.3834291772794741d, c: 0.6482549870173532d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20429618795401439d, b: 0.6651917531105749d, c: 0.1800491540531456d),
},
            new NpgsqlLineline0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06724699009921764d, b: 0.0200654276233605d, c: 0.2792931919408651d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2502811038103706d, b: 0.010363637919236335d, c: 0.9376057261793346d),
},
            new NpgsqlLineline0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9831415715430665d, b: 0.6653968290448135d, c: 0.9775620696172951d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2774195172129811d, b: 0.7927692252547004d, c: 0.6843243010305441d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.908012097554313d, b: 0.007249221127653693d, c: 0.7637666729159777d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.0016613140929387926d, b: 0.8577591970613169d, c: 0.9479586993969974d),
},
            new NpgsqlLineline0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6540610055569036d, b: 0.10892986836686425d, c: 0.8683043280226929d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9253455629498922d, b: 0.44853357870539334d, c: 0.9475136535077124d),
},
            new NpgsqlLineline0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6613020631008996d, b: 0.9283525923294068d, c: 0.14433783569296366d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6227395659962394d, b: 0.7824345708915209d, c: 0.03357877156355937d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6767925891335494d, b: 0.8814191632656033d, c: 0.2780341388967048d),
},
            new NpgsqlLineline0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.622924699655735d, b: 0.544128700991108d, c: 0.25687294507267977d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3782862323879824d, b: 0.36475372358706215d, c: 0.7183035669385187d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.49852011192328494d, b: 0.7132047500233203d, c: 0.08291914884911944d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.8221932067792652d, b: 0.8439507814828837d, c: 0.3790138184735492d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 18;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 39, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 114, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 167, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 114, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 65, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3325261379518558d, b: 0.12266475187146197d, c: 0.34477878092779246d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05670694428446976d, b: 0.9477624776506917d, c: 0.35552080129293395d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6595022670319598d, b: 0.694443427401111d, c: 0.9017854397162502d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20137269473905095d, b: 0.03895458864298973d, c: 0.26465496840608227d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03486485255302085d, b: 0.37775187291438217d, c: 0.7573571351760975d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4471721211152757d, b: 0.9711300168594986d, c: 0.5953434947327029d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38810061559495035d, b: 0.2328868131711802d, c: 0.24278106882631012d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9657452940366116d, b: 0.14830851176625104d, c: 0.9269963296815017d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20976324711946903d, b: 0.0906208040902533d, c: 0.4510824029427646d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9006790773588522d, b: 0.28669765585186135d, c: 0.6231441724647895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49852011192328494d, b: 0.7132047500233203d, c: 0.08291914884911944d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8908133875551758d, b: 0.04137055131968781d, c: 0.35239679390122425d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9170923892937914d, b: 0.7703412620333829d, c: 0.04138676714955203d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7837448809139799d, b: 0.2412821266109928d, c: 0.09177857476115847d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8221932067792652d, b: 0.8439507814828837d, c: 0.3790138184735492d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.76668601159252d, b: 0.031104210667907806d, c: 0.30245936802401385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1506933020013539d, b: 0.26774122860534066d, c: 0.8589308876954784d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17456609070664664d, b: 0.3583849935405897d, c: 0.5428554884841705d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10082565671686239d, b: 0.7041973555359902d, c: 0.8082593444830998d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7204397916533064d, b: 0.12385210766838994d, c: 0.7055633767423265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40157215719442163d, b: 0.2443075301528469d, c: 0.9986740532760107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8214122237825475d, b: 0.6909042759239757d, c: 0.5651840145914572d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14892504977118315d, b: 0.6645084669638756d, c: 0.29012206204024704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29744822818962224d, b: 0.24027183420418896d, c: 0.8358654652662478d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1942126373523061d, b: 0.4611681622442133d, c: 0.5131210925124243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.641360174584705d, b: 0.3115519914080155d, c: 0.8779338345606673d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23540104840848053d, b: 0.5377723742561962d, c: 0.051215064480100936d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37015495907874085d, b: 0.48449407850892d, c: 0.6233532267545645d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20321336830450631d, b: 0.6934766703888289d, c: 0.6828987319255885d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6447145845035046d, b: 0.9807073038067327d, c: 0.2895712894419359d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27936162587688684d, b: 0.39664373538507136d, c: 0.13981587865574951d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4317716941039771d, b: 0.3934358913983199d, c: 0.9513374945003541d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03346110542892833d, b: 0.2256583747755314d, c: 0.9206528379888905d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7356975654769226d, b: 0.3868243276832767d, c: 0.9871948107504686d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6443462635813388d, b: 0.9230535924011072d, c: 0.04211643694111711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12473510445105218d, b: 0.7968709896587974d, c: 0.998406539723536d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13369457584992173d, b: 0.5484051199444008d, c: 0.5114069197733657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2587249731630128d, b: 0.5490389864558765d, c: 0.49366090703756504d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3888914468052673d, b: 0.09000976442918263d, c: 0.6135540998983083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1276498912018319d, b: 0.44482077012658106d, c: 0.15129632864428222d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0324126103649367d, b: 0.4348666554457231d, c: 0.1558997049342865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9604913735695539d, b: 0.45766264419126557d, c: 0.6213724685897616d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214448978526159d, b: 0.27052205725080236d, c: 0.8739421502189243d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6239242086745838d, b: 0.40509921133640303d, c: 0.7399095276132387d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2759467383619265d, b: 0.7628493494587631d, c: 0.0878458202443061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25833652349686453d, b: 0.2055022324572463d, c: 0.720927708173913d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11926102975329189d, b: 0.7542702860173018d, c: 0.4803606812831066d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5743060328858084d, b: 0.47802022890601337d, c: 0.8972186867216969d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7123768904537078d, b: 0.05072440987095339d, c: 0.31828036971503615d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3916317526697267d, b: 0.4794616797549176d, c: 0.2410710602301196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9543746398215484d, b: 0.01603436570978456d, c: 0.3725359253598248d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5462073344480499d, b: 0.6366885560581581d, c: 0.057297909108482536d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6887002419350978d, b: 0.5000584519170513d, c: 0.20800941097564707d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.667410585517988d, b: 0.45104448335220704d, c: 0.11527946803040823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214277013549037d, b: 0.41901735043180266d, c: 0.26087462050644694d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32365812399878613d, b: 0.8834078060702754d, c: 0.9574398390052846d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4888969800902496d, b: 0.19450032130591122d, c: 0.636431459714213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23285793456695836d, b: 0.49806800538433826d, c: 0.9522719666018313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.733253310068621d, b: 0.3857846334720767d, c: 0.5264985205047683d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9726828864639621d, b: 0.7545204794546734d, c: 0.6927332172833388d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5863293165341262d, b: 0.7404195662088853d, c: 0.24732459967672915d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6541461034296788d, b: 0.24738382611010268d, c: 0.25920710834746896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4761406037822521d, b: 0.5426787735558347d, c: 0.44960251439699483d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2223123749769027d, b: 0.3834291772794741d, c: 0.6482549870173532d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20429618795401439d, b: 0.6651917531105749d, c: 0.1800491540531456d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06724699009921764d, b: 0.0200654276233605d, c: 0.2792931919408651d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2502811038103706d, b: 0.010363637919236335d, c: 0.9376057261793346d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9831415715430665d, b: 0.6653968290448135d, c: 0.9775620696172951d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2774195172129811d, b: 0.7927692252547004d, c: 0.6843243010305441d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.908012097554313d, b: 0.007249221127653693d, c: 0.7637666729159777d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0016613140929387926d, b: 0.8577591970613169d, c: 0.9479586993969974d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6540610055569036d, b: 0.10892986836686425d, c: 0.8683043280226929d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9253455629498922d, b: 0.44853357870539334d, c: 0.9475136535077124d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6613020631008996d, b: 0.9283525923294068d, c: 0.14433783569296366d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6227395659962394d, b: 0.7824345708915209d, c: 0.03357877156355937d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6767925891335494d, b: 0.8814191632656033d, c: 0.2780341388967048d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.622924699655735d, b: 0.544128700991108d, c: 0.25687294507267977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3782862323879824d, b: 0.36475372358706215d, c: 0.7183035669385187d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3325261379518558d, b: 0.12266475187146197d, c: 0.34477878092779246d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05670694428446976d, b: 0.9477624776506917d, c: 0.35552080129293395d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6595022670319598d, b: 0.694443427401111d, c: 0.9017854397162502d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20137269473905095d, b: 0.03895458864298973d, c: 0.26465496840608227d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03486485255302085d, b: 0.37775187291438217d, c: 0.7573571351760975d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4471721211152757d, b: 0.9711300168594986d, c: 0.5953434947327029d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38810061559495035d, b: 0.2328868131711802d, c: 0.24278106882631012d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9657452940366116d, b: 0.14830851176625104d, c: 0.9269963296815017d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20976324711946903d, b: 0.0906208040902533d, c: 0.4510824029427646d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9006790773588522d, b: 0.28669765585186135d, c: 0.6231441724647895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49852011192328494d, b: 0.7132047500233203d, c: 0.08291914884911944d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8908133875551758d, b: 0.04137055131968781d, c: 0.35239679390122425d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9170923892937914d, b: 0.7703412620333829d, c: 0.04138676714955203d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7837448809139799d, b: 0.2412821266109928d, c: 0.09177857476115847d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8221932067792652d, b: 0.8439507814828837d, c: 0.3790138184735492d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.76668601159252d, b: 0.031104210667907806d, c: 0.30245936802401385d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1506933020013539d, b: 0.26774122860534066d, c: 0.8589308876954784d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17456609070664664d, b: 0.3583849935405897d, c: 0.5428554884841705d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10082565671686239d, b: 0.7041973555359902d, c: 0.8082593444830998d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7204397916533064d, b: 0.12385210766838994d, c: 0.7055633767423265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40157215719442163d, b: 0.2443075301528469d, c: 0.9986740532760107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8214122237825475d, b: 0.6909042759239757d, c: 0.5651840145914572d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14892504977118315d, b: 0.6645084669638756d, c: 0.29012206204024704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29744822818962224d, b: 0.24027183420418896d, c: 0.8358654652662478d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1942126373523061d, b: 0.4611681622442133d, c: 0.5131210925124243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.641360174584705d, b: 0.3115519914080155d, c: 0.8779338345606673d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23540104840848053d, b: 0.5377723742561962d, c: 0.051215064480100936d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37015495907874085d, b: 0.48449407850892d, c: 0.6233532267545645d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20321336830450631d, b: 0.6934766703888289d, c: 0.6828987319255885d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6447145845035046d, b: 0.9807073038067327d, c: 0.2895712894419359d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27936162587688684d, b: 0.39664373538507136d, c: 0.13981587865574951d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4317716941039771d, b: 0.3934358913983199d, c: 0.9513374945003541d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03346110542892833d, b: 0.2256583747755314d, c: 0.9206528379888905d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7356975654769226d, b: 0.3868243276832767d, c: 0.9871948107504686d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6443462635813388d, b: 0.9230535924011072d, c: 0.04211643694111711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12473510445105218d, b: 0.7968709896587974d, c: 0.998406539723536d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13369457584992173d, b: 0.5484051199444008d, c: 0.5114069197733657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2587249731630128d, b: 0.5490389864558765d, c: 0.49366090703756504d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3888914468052673d, b: 0.09000976442918263d, c: 0.6135540998983083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1276498912018319d, b: 0.44482077012658106d, c: 0.15129632864428222d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0324126103649367d, b: 0.4348666554457231d, c: 0.1558997049342865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9604913735695539d, b: 0.45766264419126557d, c: 0.6213724685897616d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214448978526159d, b: 0.27052205725080236d, c: 0.8739421502189243d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6239242086745838d, b: 0.40509921133640303d, c: 0.7399095276132387d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2759467383619265d, b: 0.7628493494587631d, c: 0.0878458202443061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25833652349686453d, b: 0.2055022324572463d, c: 0.720927708173913d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11926102975329189d, b: 0.7542702860173018d, c: 0.4803606812831066d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5743060328858084d, b: 0.47802022890601337d, c: 0.8972186867216969d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7123768904537078d, b: 0.05072440987095339d, c: 0.31828036971503615d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3916317526697267d, b: 0.4794616797549176d, c: 0.2410710602301196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9543746398215484d, b: 0.01603436570978456d, c: 0.3725359253598248d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5462073344480499d, b: 0.6366885560581581d, c: 0.057297909108482536d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6887002419350978d, b: 0.5000584519170513d, c: 0.20800941097564707d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.667410585517988d, b: 0.45104448335220704d, c: 0.11527946803040823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3214277013549037d, b: 0.41901735043180266d, c: 0.26087462050644694d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32365812399878613d, b: 0.8834078060702754d, c: 0.9574398390052846d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4888969800902496d, b: 0.19450032130591122d, c: 0.636431459714213d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23285793456695836d, b: 0.49806800538433826d, c: 0.9522719666018313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.733253310068621d, b: 0.3857846334720767d, c: 0.5264985205047683d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9726828864639621d, b: 0.7545204794546734d, c: 0.6927332172833388d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5863293165341262d, b: 0.7404195662088853d, c: 0.24732459967672915d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6541461034296788d, b: 0.24738382611010268d, c: 0.25920710834746896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4761406037822521d, b: 0.5426787735558347d, c: 0.44960251439699483d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2223123749769027d, b: 0.3834291772794741d, c: 0.6482549870173532d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20429618795401439d, b: 0.6651917531105749d, c: 0.1800491540531456d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06724699009921764d, b: 0.0200654276233605d, c: 0.2792931919408651d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2502811038103706d, b: 0.010363637919236335d, c: 0.9376057261793346d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9831415715430665d, b: 0.6653968290448135d, c: 0.9775620696172951d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2774195172129811d, b: 0.7927692252547004d, c: 0.6843243010305441d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.908012097554313d, b: 0.007249221127653693d, c: 0.7637666729159777d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0016613140929387926d, b: 0.8577591970613169d, c: 0.9479586993969974d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6540610055569036d, b: 0.10892986836686425d, c: 0.8683043280226929d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9253455629498922d, b: 0.44853357870539334d, c: 0.9475136535077124d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6613020631008996d, b: 0.9283525923294068d, c: 0.14433783569296366d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6227395659962394d, b: 0.7824345708915209d, c: 0.03357877156355937d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6767925891335494d, b: 0.8814191632656033d, c: 0.2780341388967048d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.622924699655735d, b: 0.544128700991108d, c: 0.25687294507267977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3782862323879824d, b: 0.36475372358706215d, c: 0.7183035669385187d))));

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI), typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

