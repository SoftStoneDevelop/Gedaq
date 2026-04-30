

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
    internal partial interface INpgsqlPointSingleTypepoint
    {
    }
    
    internal partial class NpgsqlPointSingleTypepoint : INpgsqlPointSingleTypepoint
    {


#region TestData

        private readonly NpgsqlPointpoint0M[] _testData = new NpgsqlPointpoint0M[]
        {
            new NpgsqlPointpoint0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5455085400605056d, y: 0.15592577227829452d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.013625531065797891d, y: 0.8547392753560122d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.39349290941358184d, y: 0.6937175606706193d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.03960818176149061d, y: 0.4091367140987533d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.08421349294196856d, y: 0.6524641504953081d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8024405866294219d, y: 0.40090234755309273d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4918893790898142d, y: 0.21576815742811595d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.11036575741237808d, y: 0.5648579532895345d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2098188738722574d, y: 0.21108001890723538d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3431894788543989d, y: 0.832758805107763d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17585355803571767d, y: 0.6491102038937436d),
},
            new NpgsqlPointpoint0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7687869992047296d, y: 0.9533185903280641d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6271171564576263d, y: 0.45594673792510865d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6142263006560786d, y: 0.35290138568542573d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.36429144384022316d, y: 0.24321614611532705d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5390059153811739d, y: 0.6002396327600898d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6891261088757201d, y: 0.1848957473453332d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6923138165507411d, y: 0.3430201174704509d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8671222790487834d, y: 0.48781365632519935d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22304982937911044d, y: 0.3453076139971587d),
},
            new NpgsqlPointpoint0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.00029902944067916604d, y: 0.5123267054538759d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29846701176243917d, y: 0.7771794043481213d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7239597565906382d, y: 0.9364765003445142d),
},
            new NpgsqlPointpoint0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3451870653339061d, y: 0.6898808499529736d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.44740493106287915d, y: 0.22406402337091702d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.25112613042712006d, y: 0.2010119956571238d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4042721656106947d, y: 0.730331172068921d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8934652409074939d, y: 0.47692411266593937d),
},
            new NpgsqlPointpoint0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.42973473414251473d, y: 0.5696614451208456d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5357191005202607d, y: 0.43163823216377784d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3583516700612345d, y: 0.02268682211630091d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9441676894140825d, y: 0.6110638991453324d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7586128310267651d, y: 0.5818383807391542d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06391942444781584d, y: 0.31340515011058123d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4860912178556488d, y: 0.28922317314467727d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3420976610185128d, y: 0.9472324687028397d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.00392397550225998d, y: 0.400566773251399d),
},
            new NpgsqlPointpoint0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.876794553886877d, y: 0.16463066929720394d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1351089084249193d, y: 0.36006893936100803d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.05349077691757764d, y: 0.3442382197158358d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.03999282274128457d, y: 0.884660419253322d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4047198346185582d, y: 0.9212656070271434d),
},
            new NpgsqlPointpoint0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7859590031121305d, y: 0.16376880347940936d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9757596182757848d, y: 0.599967579931962d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7354200480373361d, y: 0.8566787814458946d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.11317888135774179d, y: 0.07835603151241821d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29694734918227805d, y: 0.10346478822426208d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5138992315566542d, y: 0.09051295509948609d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6870720916370147d, y: 0.029660859198301637d),
},
            new NpgsqlPointpoint0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.21454669463258147d, y: 0.815549920718999d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.26083569281023244d, y: 0.2978117372758462d),
},
            new NpgsqlPointpoint0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7279817266198149d, y: 0.3375313812110575d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6041434736875845d, y: 0.3169302014991048d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9062245904353378d, y: 0.3004437382773979d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.009103718938904937d, y: 0.6427201326098396d),
},
            new NpgsqlPointpoint0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8127740867962495d, y: 0.525268392850413d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.856553160178379d, y: 0.8117145216710607d),
},
            new NpgsqlPointpoint0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7678001495698942d, y: 0.5302901770792176d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.48861297676779514d, y: 0.3915713580075745d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1073603855360683d, y: 0.07476054426626555d),
},
            new NpgsqlPointpoint0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2064428619674371d, y: 0.44373061725377216d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8295089835228004d, y: 0.1551955990690692d),
},
            new NpgsqlPointpoint0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5297640401198839d, y: 0.22354608449862345d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.004550013415938414d, y: 0.9079781728880153d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2611150001890947d, y: 0.6529211698385958d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8407314841663515d, y: 0.5785837248920978d),
},
            new NpgsqlPointpoint0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13048168384351d, y: 0.7196282719029028d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9955821217005033d, y: 0.09081657226320239d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29044710249048933d, y: 0.10775151231948987d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1662465149804404d, y: 0.45058688897498755d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.213980075113944d, y: 0.28496979316541027d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.69479000872355d, y: 0.610361582587202d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5311204949235075d, y: 0.0025436271737916405d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.21482078546341943d, y: 0.485630703802411d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3280725069083926d, y: 0.8214370344728565d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.17585355803571767d, y: 0.6491102038937436d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22304982937911044d, y: 0.3453076139971587d)));
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7239597565906382d, y: 0.9364765003445142d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpoint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPoint), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpointpoint0mi_id", 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 161;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 25, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 76, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5455085400605056d, y: 0.15592577227829452d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013625531065797891d, y: 0.8547392753560122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39349290941358184d, y: 0.6937175606706193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03960818176149061d, y: 0.4091367140987533d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08421349294196856d, y: 0.6524641504953081d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8024405866294219d, y: 0.40090234755309273d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4918893790898142d, y: 0.21576815742811595d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11036575741237808d, y: 0.5648579532895345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2098188738722574d, y: 0.21108001890723538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3431894788543989d, y: 0.832758805107763d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17585355803571767d, y: 0.6491102038937436d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7687869992047296d, y: 0.9533185903280641d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6271171564576263d, y: 0.45594673792510865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6142263006560786d, y: 0.35290138568542573d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36429144384022316d, y: 0.24321614611532705d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5390059153811739d, y: 0.6002396327600898d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6891261088757201d, y: 0.1848957473453332d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6923138165507411d, y: 0.3430201174704509d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8671222790487834d, y: 0.48781365632519935d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22304982937911044d, y: 0.3453076139971587d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00029902944067916604d, y: 0.5123267054538759d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29846701176243917d, y: 0.7771794043481213d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7239597565906382d, y: 0.9364765003445142d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3451870653339061d, y: 0.6898808499529736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44740493106287915d, y: 0.22406402337091702d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.25112613042712006d, y: 0.2010119956571238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4042721656106947d, y: 0.730331172068921d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8934652409074939d, y: 0.47692411266593937d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42973473414251473d, y: 0.5696614451208456d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5357191005202607d, y: 0.43163823216377784d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3583516700612345d, y: 0.02268682211630091d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9441676894140825d, y: 0.6110638991453324d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7586128310267651d, y: 0.5818383807391542d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06391942444781584d, y: 0.31340515011058123d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4860912178556488d, y: 0.28922317314467727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3420976610185128d, y: 0.9472324687028397d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00392397550225998d, y: 0.400566773251399d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.876794553886877d, y: 0.16463066929720394d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1351089084249193d, y: 0.36006893936100803d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05349077691757764d, y: 0.3442382197158358d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03999282274128457d, y: 0.884660419253322d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4047198346185582d, y: 0.9212656070271434d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7859590031121305d, y: 0.16376880347940936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9757596182757848d, y: 0.599967579931962d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7354200480373361d, y: 0.8566787814458946d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11317888135774179d, y: 0.07835603151241821d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29694734918227805d, y: 0.10346478822426208d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5138992315566542d, y: 0.09051295509948609d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6870720916370147d, y: 0.029660859198301637d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21454669463258147d, y: 0.815549920718999d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26083569281023244d, y: 0.2978117372758462d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7279817266198149d, y: 0.3375313812110575d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6041434736875845d, y: 0.3169302014991048d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9062245904353378d, y: 0.3004437382773979d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.009103718938904937d, y: 0.6427201326098396d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8127740867962495d, y: 0.525268392850413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.856553160178379d, y: 0.8117145216710607d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7678001495698942d, y: 0.5302901770792176d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48861297676779514d, y: 0.3915713580075745d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1073603855360683d, y: 0.07476054426626555d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2064428619674371d, y: 0.44373061725377216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8295089835228004d, y: 0.1551955990690692d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5297640401198839d, y: 0.22354608449862345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.004550013415938414d, y: 0.9079781728880153d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2611150001890947d, y: 0.6529211698385958d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8407314841663515d, y: 0.5785837248920978d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13048168384351d, y: 0.7196282719029028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9955821217005033d, y: 0.09081657226320239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29044710249048933d, y: 0.10775151231948987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1662465149804404d, y: 0.45058688897498755d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.213980075113944d, y: 0.28496979316541027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.69479000872355d, y: 0.610361582587202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5311204949235075d, y: 0.0025436271737916405d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21482078546341943d, y: 0.485630703802411d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3280725069083926d, y: 0.8214370344728565d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5455085400605056d, y: 0.15592577227829452d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013625531065797891d, y: 0.8547392753560122d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39349290941358184d, y: 0.6937175606706193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03960818176149061d, y: 0.4091367140987533d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08421349294196856d, y: 0.6524641504953081d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8024405866294219d, y: 0.40090234755309273d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4918893790898142d, y: 0.21576815742811595d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11036575741237808d, y: 0.5648579532895345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2098188738722574d, y: 0.21108001890723538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3431894788543989d, y: 0.832758805107763d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17585355803571767d, y: 0.6491102038937436d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7687869992047296d, y: 0.9533185903280641d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6271171564576263d, y: 0.45594673792510865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6142263006560786d, y: 0.35290138568542573d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36429144384022316d, y: 0.24321614611532705d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5390059153811739d, y: 0.6002396327600898d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6891261088757201d, y: 0.1848957473453332d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6923138165507411d, y: 0.3430201174704509d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8671222790487834d, y: 0.48781365632519935d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22304982937911044d, y: 0.3453076139971587d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00029902944067916604d, y: 0.5123267054538759d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29846701176243917d, y: 0.7771794043481213d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7239597565906382d, y: 0.9364765003445142d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3451870653339061d, y: 0.6898808499529736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44740493106287915d, y: 0.22406402337091702d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.25112613042712006d, y: 0.2010119956571238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4042721656106947d, y: 0.730331172068921d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8934652409074939d, y: 0.47692411266593937d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42973473414251473d, y: 0.5696614451208456d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5357191005202607d, y: 0.43163823216377784d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3583516700612345d, y: 0.02268682211630091d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9441676894140825d, y: 0.6110638991453324d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7586128310267651d, y: 0.5818383807391542d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06391942444781584d, y: 0.31340515011058123d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4860912178556488d, y: 0.28922317314467727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3420976610185128d, y: 0.9472324687028397d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00392397550225998d, y: 0.400566773251399d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.876794553886877d, y: 0.16463066929720394d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1351089084249193d, y: 0.36006893936100803d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05349077691757764d, y: 0.3442382197158358d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03999282274128457d, y: 0.884660419253322d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4047198346185582d, y: 0.9212656070271434d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7859590031121305d, y: 0.16376880347940936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9757596182757848d, y: 0.599967579931962d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7354200480373361d, y: 0.8566787814458946d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11317888135774179d, y: 0.07835603151241821d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29694734918227805d, y: 0.10346478822426208d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5138992315566542d, y: 0.09051295509948609d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6870720916370147d, y: 0.029660859198301637d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21454669463258147d, y: 0.815549920718999d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26083569281023244d, y: 0.2978117372758462d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7279817266198149d, y: 0.3375313812110575d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6041434736875845d, y: 0.3169302014991048d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9062245904353378d, y: 0.3004437382773979d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.009103718938904937d, y: 0.6427201326098396d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8127740867962495d, y: 0.525268392850413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.856553160178379d, y: 0.8117145216710607d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7678001495698942d, y: 0.5302901770792176d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48861297676779514d, y: 0.3915713580075745d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1073603855360683d, y: 0.07476054426626555d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2064428619674371d, y: 0.44373061725377216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8295089835228004d, y: 0.1551955990690692d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5297640401198839d, y: 0.22354608449862345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.004550013415938414d, y: 0.9079781728880153d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2611150001890947d, y: 0.6529211698385958d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8407314841663515d, y: 0.5785837248920978d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13048168384351d, y: 0.7196282719029028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9955821217005033d, y: 0.09081657226320239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29044710249048933d, y: 0.10775151231948987d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1662465149804404d, y: 0.45058688897498755d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.213980075113944d, y: 0.28496979316541027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.69479000872355d, y: 0.610361582587202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5311204949235075d, y: 0.0025436271737916405d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21482078546341943d, y: 0.485630703802411d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3280725069083926d, y: 0.8214370344728565d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
FROM public.binary_npgsqlpointpoint0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI), typeof(NpgsqlPointpoint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                await ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

