

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

        private readonly NpgsqlPointpointE0M[] _testData = new NpgsqlPointpointE0M[]
        {
            new NpgsqlPointpointE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3188853205154827d, y: 0.42263186040714973d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.39675994379752866d, y: 0.11162468779119683d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.030568932976266616d, y: 0.9222044103310524d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.057686957499982205d, y: 0.6413596217726036d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5139483296082157d, y: 0.605175155343569d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.829492383059905d, y: 0.9472556214030442d),
},
            new NpgsqlPointpointE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.30147330413311724d, y: 0.7808483044438215d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3518819557741637d, y: 0.03530832918174176d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1976333941779752d, y: 0.2647813050362765d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22344664376432166d, y: 0.3895008758578654d),
},
            new NpgsqlPointpointE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6252998522832288d, y: 0.2728262905015052d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.008266038793165675d, y: 0.6070014244796468d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8542868026415971d, y: 0.11863165375118845d),
},
            new NpgsqlPointpointE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.41804303685241895d, y: 0.22130175957747344d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.05384680928156149d, y: 0.9164253936424237d),
},
            new NpgsqlPointpointE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2894007356357722d, y: 0.7729700299851485d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9491048289765729d, y: 0.708461249608859d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.562007640761506d, y: 0.47931098509844705d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6263224630648261d, y: 0.5417428830211214d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13721096507987296d, y: 0.9472886660144288d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9468240370598128d, y: 0.995906537271954d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12345410574429272d, y: 0.5730517620217396d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8346385206251608d, y: 0.2563882516410645d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8585916195437472d, y: 0.9085272255796712d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.22580800072784835d, y: 0.9631263349561116d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.09319983589752312d, y: 0.48934845221521217d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.04483502519341931d, y: 0.15563350620312666d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.24311988439569654d, y: 0.8176861632361014d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7799378602480367d, y: 0.8144085471139545d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6700642375448739d, y: 0.02030629932636918d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.742619247786203d, y: 0.47684318391037417d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5670719863264132d, y: 0.5217380820452516d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8316676257097628d, y: 0.4384030637453923d),
},
            new NpgsqlPointpointE0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9754810462611245d, y: 0.7158531992622941d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2529712141478412d, y: 0.06910026397642d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9693146591720536d, y: 0.9333152278034147d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8032735451796998d, y: 0.3715483221538003d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6001611923189017d, y: 0.8093940706167386d),
},
            new NpgsqlPointpointE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.15967173171986426d, y: 0.14194262724746298d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.15590733543992863d, y: 0.7645534490526243d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.27608274210030215d, y: 0.8347500460638948d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8846998454198617d, y: 0.7967567766486949d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.13306425200125926d, y: 0.6416307724688907d),
},
            new NpgsqlPointpointE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6122649287054023d, y: 0.7456875090962776d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.037651754495924616d, y: 0.8420183282962921d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13356291112367946d, y: 0.9072191641330114d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9338905685431859d, y: 0.6472130442817184d),
},
            new NpgsqlPointpointE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8416049809527407d, y: 0.1753455568176795d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5295731348727705d, y: 0.5811793306212371d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13783768070554925d, y: 0.5872029155656614d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.45044493241193373d, y: 0.1011826211747533d),
},
            new NpgsqlPointpointE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7302523837029744d, y: 0.0457701113718616d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7515887384028889d, y: 0.6008100496076805d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2124040982095391d, y: 0.5690918274143199d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6112417005884323d, y: 0.42998330113523875d),
},
            new NpgsqlPointpointE0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6949094317991837d, y: 0.3334732050153376d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.034277494993249724d, y: 0.6532245962777482d),
},
            new NpgsqlPointpointE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9788831049205655d, y: 0.28717455807577663d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.10777239950319095d, y: 0.9387956458369857d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.26806303713884483d, y: 0.8615351541500081d),
},
            new NpgsqlPointpointE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5934158219877214d, y: 0.7098992830456549d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8044950795249003d, y: 0.8032578243174283d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7443460539071612d, y: 0.5285937363801843d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9675605574648399d, y: 0.6168931521242996d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8644511843212559d, y: 0.3925294086353579d),
},
            new NpgsqlPointpointE0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17145155730957395d, y: 0.5044150717485244d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.31658796720175675d, y: 0.9608047527991698d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.07377631831929732d, y: 0.7081083956668973d),
},
            new NpgsqlPointpointE0M
{
    Id = 177,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7447858463955987d, y: 0.31859696621226496d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 180,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3400698293148021d, y: 0.12158377686046595d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37269748354853127d, y: 0.2013248212865768d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5475917528635061d, y: 0.5539433102566749d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2791888535737628d, y: 0.800401875051449d),
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
INSERT INTO public.npgsqlpointpointe0m(
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
INSERT INTO public.npgsqlpointpointe0m(
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
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.22344664376432166d, y: 0.3895008758578654d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8542868026415971d, y: 0.11863165375118845d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.05384680928156149d, y: 0.9164253936424237d)));
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
INSERT INTO public.npgsqlpointpointe0m(
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
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointE0M> models = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointE0M> models = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointe0m(
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
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M), typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
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
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
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
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M), typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M), typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
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
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
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

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[29],_testData[34], false);
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M), typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointE0M>();
                var models2 = new List<FlatNpgsqlPointpointE0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 176, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var firstItems2 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 177, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointE0M)],
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 176, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
FROM public.npgsqlpointpointe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems1 = new List<FlatNpgsqlPointpointE0M>();
                var secondItems2 = new List<FlatNpgsqlPointpointE0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 177, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[34], false);
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
                    NpgsqlPointpointE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 68, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[34], false);
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[26], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[27], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[28], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[6],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[7],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpointpointe0m m
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3188853205154827d, y: 0.42263186040714973d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39675994379752866d, y: 0.11162468779119683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.030568932976266616d, y: 0.9222044103310524d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.057686957499982205d, y: 0.6413596217726036d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5139483296082157d, y: 0.605175155343569d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.829492383059905d, y: 0.9472556214030442d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30147330413311724d, y: 0.7808483044438215d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3518819557741637d, y: 0.03530832918174176d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1976333941779752d, y: 0.2647813050362765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22344664376432166d, y: 0.3895008758578654d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6252998522832288d, y: 0.2728262905015052d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.008266038793165675d, y: 0.6070014244796468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8542868026415971d, y: 0.11863165375118845d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41804303685241895d, y: 0.22130175957747344d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05384680928156149d, y: 0.9164253936424237d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2894007356357722d, y: 0.7729700299851485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9491048289765729d, y: 0.708461249608859d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.562007640761506d, y: 0.47931098509844705d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6263224630648261d, y: 0.5417428830211214d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13721096507987296d, y: 0.9472886660144288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9468240370598128d, y: 0.995906537271954d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12345410574429272d, y: 0.5730517620217396d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8346385206251608d, y: 0.2563882516410645d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8585916195437472d, y: 0.9085272255796712d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22580800072784835d, y: 0.9631263349561116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09319983589752312d, y: 0.48934845221521217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04483502519341931d, y: 0.15563350620312666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24311988439569654d, y: 0.8176861632361014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7799378602480367d, y: 0.8144085471139545d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6700642375448739d, y: 0.02030629932636918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.742619247786203d, y: 0.47684318391037417d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5670719863264132d, y: 0.5217380820452516d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8316676257097628d, y: 0.4384030637453923d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9754810462611245d, y: 0.7158531992622941d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2529712141478412d, y: 0.06910026397642d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9693146591720536d, y: 0.9333152278034147d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8032735451796998d, y: 0.3715483221538003d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6001611923189017d, y: 0.8093940706167386d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15967173171986426d, y: 0.14194262724746298d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15590733543992863d, y: 0.7645534490526243d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27608274210030215d, y: 0.8347500460638948d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8846998454198617d, y: 0.7967567766486949d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13306425200125926d, y: 0.6416307724688907d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6122649287054023d, y: 0.7456875090962776d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.037651754495924616d, y: 0.8420183282962921d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13356291112367946d, y: 0.9072191641330114d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9338905685431859d, y: 0.6472130442817184d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8416049809527407d, y: 0.1753455568176795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5295731348727705d, y: 0.5811793306212371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13783768070554925d, y: 0.5872029155656614d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45044493241193373d, y: 0.1011826211747533d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7302523837029744d, y: 0.0457701113718616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7515887384028889d, y: 0.6008100496076805d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2124040982095391d, y: 0.5690918274143199d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6112417005884323d, y: 0.42998330113523875d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6949094317991837d, y: 0.3334732050153376d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.034277494993249724d, y: 0.6532245962777482d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9788831049205655d, y: 0.28717455807577663d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10777239950319095d, y: 0.9387956458369857d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26806303713884483d, y: 0.8615351541500081d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5934158219877214d, y: 0.7098992830456549d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8044950795249003d, y: 0.8032578243174283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7443460539071612d, y: 0.5285937363801843d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9675605574648399d, y: 0.6168931521242996d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8644511843212559d, y: 0.3925294086353579d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17145155730957395d, y: 0.5044150717485244d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31658796720175675d, y: 0.9608047527991698d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07377631831929732d, y: 0.7081083956668973d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7447858463955987d, y: 0.31859696621226496d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3400698293148021d, y: 0.12158377686046595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37269748354853127d, y: 0.2013248212865768d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5475917528635061d, y: 0.5539433102566749d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2791888535737628d, y: 0.800401875051449d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3188853205154827d, y: 0.42263186040714973d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39675994379752866d, y: 0.11162468779119683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.030568932976266616d, y: 0.9222044103310524d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.057686957499982205d, y: 0.6413596217726036d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5139483296082157d, y: 0.605175155343569d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.829492383059905d, y: 0.9472556214030442d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30147330413311724d, y: 0.7808483044438215d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3518819557741637d, y: 0.03530832918174176d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1976333941779752d, y: 0.2647813050362765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22344664376432166d, y: 0.3895008758578654d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6252998522832288d, y: 0.2728262905015052d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.008266038793165675d, y: 0.6070014244796468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8542868026415971d, y: 0.11863165375118845d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41804303685241895d, y: 0.22130175957747344d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05384680928156149d, y: 0.9164253936424237d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2894007356357722d, y: 0.7729700299851485d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9491048289765729d, y: 0.708461249608859d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.562007640761506d, y: 0.47931098509844705d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6263224630648261d, y: 0.5417428830211214d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13721096507987296d, y: 0.9472886660144288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9468240370598128d, y: 0.995906537271954d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12345410574429272d, y: 0.5730517620217396d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8346385206251608d, y: 0.2563882516410645d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8585916195437472d, y: 0.9085272255796712d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22580800072784835d, y: 0.9631263349561116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09319983589752312d, y: 0.48934845221521217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04483502519341931d, y: 0.15563350620312666d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24311988439569654d, y: 0.8176861632361014d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7799378602480367d, y: 0.8144085471139545d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6700642375448739d, y: 0.02030629932636918d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.742619247786203d, y: 0.47684318391037417d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5670719863264132d, y: 0.5217380820452516d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8316676257097628d, y: 0.4384030637453923d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9754810462611245d, y: 0.7158531992622941d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2529712141478412d, y: 0.06910026397642d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9693146591720536d, y: 0.9333152278034147d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8032735451796998d, y: 0.3715483221538003d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6001611923189017d, y: 0.8093940706167386d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15967173171986426d, y: 0.14194262724746298d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15590733543992863d, y: 0.7645534490526243d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27608274210030215d, y: 0.8347500460638948d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8846998454198617d, y: 0.7967567766486949d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13306425200125926d, y: 0.6416307724688907d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6122649287054023d, y: 0.7456875090962776d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.037651754495924616d, y: 0.8420183282962921d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13356291112367946d, y: 0.9072191641330114d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9338905685431859d, y: 0.6472130442817184d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8416049809527407d, y: 0.1753455568176795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5295731348727705d, y: 0.5811793306212371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13783768070554925d, y: 0.5872029155656614d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45044493241193373d, y: 0.1011826211747533d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7302523837029744d, y: 0.0457701113718616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7515887384028889d, y: 0.6008100496076805d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2124040982095391d, y: 0.5690918274143199d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6112417005884323d, y: 0.42998330113523875d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6949094317991837d, y: 0.3334732050153376d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.034277494993249724d, y: 0.6532245962777482d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9788831049205655d, y: 0.28717455807577663d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10777239950319095d, y: 0.9387956458369857d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26806303713884483d, y: 0.8615351541500081d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5934158219877214d, y: 0.7098992830456549d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8044950795249003d, y: 0.8032578243174283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7443460539071612d, y: 0.5285937363801843d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9675605574648399d, y: 0.6168931521242996d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8644511843212559d, y: 0.3925294086353579d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17145155730957395d, y: 0.5044150717485244d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31658796720175675d, y: 0.9608047527991698d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07377631831929732d, y: 0.7081083956668973d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7447858463955987d, y: 0.31859696621226496d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3400698293148021d, y: 0.12158377686046595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37269748354853127d, y: 0.2013248212865768d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5475917528635061d, y: 0.5539433102566749d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2791888535737628d, y: 0.800401875051449d))));

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
COPY public.binary_npgsqlpointpointe0m
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
            queryMapType: typeof(NpgsqlPointpointE0M),
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
FROM public.binary_npgsqlpointpointe0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
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
                var importCollection = new List<NpgsqlPointpointE0M>();
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
                    NpgsqlPointpointE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointE0M>();
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
                    NpgsqlPointpointE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointe0m
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
            queryMapTypes: [typeof(NpgsqlPointpointE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPointpointE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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

