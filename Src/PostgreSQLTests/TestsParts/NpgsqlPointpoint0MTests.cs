

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
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4795460584847441d, y: 0.8035510598658191d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8352682484915485d, y: 0.762096755068409d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.48191430192772367d, y: 0.6601371213616579d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9293580540751806d, y: 0.9425817409271672d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8724967723197616d, y: 0.41201602284222605d),
},
            new NpgsqlPointpoint0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9132954198541016d, y: 0.9165907379238146d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8680139921213935d, y: 0.39723834413954817d),
},
            new NpgsqlPointpoint0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16686656045940518d, y: 0.7763216187549021d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5928058880836826d, y: 0.37063024179512016d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6788670493833128d, y: 0.048897105715803635d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13338142758947713d, y: 0.5281719396669566d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8740987749440303d, y: 0.43583851234430715d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7200000825426233d, y: 0.6789382439172139d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7767753823801887d, y: 0.5138509785649624d),
},
            new NpgsqlPointpoint0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37685350066161405d, y: 0.5957721584189931d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3379571826061786d, y: 0.014559393121512443d),
},
            new NpgsqlPointpoint0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9290102444320774d, y: 0.2052022061087374d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9857952414551259d, y: 0.4211442253489426d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8956999045625429d, y: 0.9869120842414943d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6348261407947924d, y: 0.7121830757720442d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.19302868732047096d, y: 0.23297327866597917d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9701726626235991d, y: 0.6399860267847106d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.08560596909349849d, y: 0.466410643486162d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1862959904763687d, y: 0.7745867471923876d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5866577207349801d, y: 0.9436101152913129d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7522437396369661d, y: 0.5660589977014072d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5969627103931461d, y: 0.649870129350224d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5204050122794389d, y: 0.24069940274852697d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1360594642103632d, y: 0.4916198525748787d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06318182585589105d, y: 0.027277454244773902d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7985901575259895d, y: 0.26071181044258573d),
},
            new NpgsqlPointpoint0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8614062786366994d, y: 0.737673209778251d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2141744866697347d, y: 0.6077410642614901d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9437609302926129d, y: 0.025463382854040706d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5979718150032474d, y: 0.841717641479079d),
},
            new NpgsqlPointpoint0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1128263225501146d, y: 0.7618610215434698d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.823070797476223d, y: 0.4516052465026531d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.41895465252769204d, y: 0.6795429410859979d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.09893839028289608d, y: 0.8703273441575261d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.06791196779010866d, y: 0.4751186266650512d),
},
            new NpgsqlPointpoint0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1777994451548096d, y: 0.1341202992945313d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9671704380826563d, y: 0.9052076728857968d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8452959052939008d, y: 0.8075730815875449d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.14248118534687415d, y: 0.19424898800924495d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2994043343895407d, y: 0.5428483582373557d),
},
            new NpgsqlPointpoint0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5356367279601039d, y: 0.03954787075763855d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3192357363445024d, y: 0.18908361747125146d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22106794307458344d, y: 0.42267489282484305d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23021963309750393d, y: 0.6513385364626537d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.39750476184408656d, y: 0.976863931219209d),
},
            new NpgsqlPointpoint0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9073259132414563d, y: 0.15358331105956613d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9372625950196317d, y: 0.7523293797132428d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.34425521768164813d, y: 0.35119205594835d),
},
            new NpgsqlPointpoint0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4104052207336778d, y: 0.7909149455530844d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6408370699969126d, y: 0.957158011428757d),
},
            new NpgsqlPointpoint0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9850991997652189d, y: 0.7371824697818076d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12228262863234651d, y: 0.6933324100328078d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6396330826823232d, y: 0.9964020428379841d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4945527792047675d, y: 0.5748385940655362d),
},
            new NpgsqlPointpoint0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.033156421004756575d, y: 0.3090310273409175d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9231688058223873d, y: 0.8947480967485222d),
},
            new NpgsqlPointpoint0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.817808448482734d, y: 0.6417901630225595d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8245147511901285d, y: 0.015467865507381218d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4238180554295232d, y: 0.13943224345011673d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4904202133120876d, y: 0.33199987170839185d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8166160507611719d, y: 0.05523095402043998d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6835957754553597d, y: 0.9566861998725422d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8144601956286761d, y: 0.73980611370849d),
},
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7767753823801887d, y: 0.5138509785649624d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3379571826061786d, y: 0.014559393121512443d)));
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((INpgsqlPointSingleTypepoint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);
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

                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
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
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelBatchAsync(connection, 82, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[2], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[3], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[4], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[5], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[6], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[23],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[24],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[25],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[26],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelBatch(connection, 21, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[4], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[5], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[6], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[23],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[24],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4795460584847441d, y: 0.8035510598658191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8352682484915485d, y: 0.762096755068409d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48191430192772367d, y: 0.6601371213616579d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9293580540751806d, y: 0.9425817409271672d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8724967723197616d, y: 0.41201602284222605d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9132954198541016d, y: 0.9165907379238146d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8680139921213935d, y: 0.39723834413954817d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16686656045940518d, y: 0.7763216187549021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5928058880836826d, y: 0.37063024179512016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6788670493833128d, y: 0.048897105715803635d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13338142758947713d, y: 0.5281719396669566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8740987749440303d, y: 0.43583851234430715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7200000825426233d, y: 0.6789382439172139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7767753823801887d, y: 0.5138509785649624d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37685350066161405d, y: 0.5957721584189931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3379571826061786d, y: 0.014559393121512443d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9290102444320774d, y: 0.2052022061087374d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9857952414551259d, y: 0.4211442253489426d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8956999045625429d, y: 0.9869120842414943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6348261407947924d, y: 0.7121830757720442d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19302868732047096d, y: 0.23297327866597917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9701726626235991d, y: 0.6399860267847106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08560596909349849d, y: 0.466410643486162d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1862959904763687d, y: 0.7745867471923876d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5866577207349801d, y: 0.9436101152913129d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7522437396369661d, y: 0.5660589977014072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5969627103931461d, y: 0.649870129350224d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5204050122794389d, y: 0.24069940274852697d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1360594642103632d, y: 0.4916198525748787d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06318182585589105d, y: 0.027277454244773902d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7985901575259895d, y: 0.26071181044258573d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8614062786366994d, y: 0.737673209778251d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2141744866697347d, y: 0.6077410642614901d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9437609302926129d, y: 0.025463382854040706d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5979718150032474d, y: 0.841717641479079d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1128263225501146d, y: 0.7618610215434698d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.823070797476223d, y: 0.4516052465026531d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41895465252769204d, y: 0.6795429410859979d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09893839028289608d, y: 0.8703273441575261d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06791196779010866d, y: 0.4751186266650512d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1777994451548096d, y: 0.1341202992945313d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9671704380826563d, y: 0.9052076728857968d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8452959052939008d, y: 0.8075730815875449d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14248118534687415d, y: 0.19424898800924495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2994043343895407d, y: 0.5428483582373557d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5356367279601039d, y: 0.03954787075763855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3192357363445024d, y: 0.18908361747125146d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22106794307458344d, y: 0.42267489282484305d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23021963309750393d, y: 0.6513385364626537d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39750476184408656d, y: 0.976863931219209d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9073259132414563d, y: 0.15358331105956613d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9372625950196317d, y: 0.7523293797132428d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34425521768164813d, y: 0.35119205594835d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4104052207336778d, y: 0.7909149455530844d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6408370699969126d, y: 0.957158011428757d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9850991997652189d, y: 0.7371824697818076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12228262863234651d, y: 0.6933324100328078d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6396330826823232d, y: 0.9964020428379841d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4945527792047675d, y: 0.5748385940655362d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.033156421004756575d, y: 0.3090310273409175d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9231688058223873d, y: 0.8947480967485222d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.817808448482734d, y: 0.6417901630225595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8245147511901285d, y: 0.015467865507381218d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4238180554295232d, y: 0.13943224345011673d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4904202133120876d, y: 0.33199987170839185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8166160507611719d, y: 0.05523095402043998d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6835957754553597d, y: 0.9566861998725422d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8144601956286761d, y: 0.73980611370849d))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4795460584847441d, y: 0.8035510598658191d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8352682484915485d, y: 0.762096755068409d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48191430192772367d, y: 0.6601371213616579d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9293580540751806d, y: 0.9425817409271672d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8724967723197616d, y: 0.41201602284222605d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9132954198541016d, y: 0.9165907379238146d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8680139921213935d, y: 0.39723834413954817d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16686656045940518d, y: 0.7763216187549021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5928058880836826d, y: 0.37063024179512016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6788670493833128d, y: 0.048897105715803635d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13338142758947713d, y: 0.5281719396669566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8740987749440303d, y: 0.43583851234430715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7200000825426233d, y: 0.6789382439172139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7767753823801887d, y: 0.5138509785649624d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37685350066161405d, y: 0.5957721584189931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3379571826061786d, y: 0.014559393121512443d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9290102444320774d, y: 0.2052022061087374d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9857952414551259d, y: 0.4211442253489426d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8956999045625429d, y: 0.9869120842414943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6348261407947924d, y: 0.7121830757720442d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19302868732047096d, y: 0.23297327866597917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9701726626235991d, y: 0.6399860267847106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08560596909349849d, y: 0.466410643486162d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1862959904763687d, y: 0.7745867471923876d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5866577207349801d, y: 0.9436101152913129d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7522437396369661d, y: 0.5660589977014072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5969627103931461d, y: 0.649870129350224d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5204050122794389d, y: 0.24069940274852697d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1360594642103632d, y: 0.4916198525748787d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06318182585589105d, y: 0.027277454244773902d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7985901575259895d, y: 0.26071181044258573d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8614062786366994d, y: 0.737673209778251d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2141744866697347d, y: 0.6077410642614901d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9437609302926129d, y: 0.025463382854040706d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5979718150032474d, y: 0.841717641479079d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1128263225501146d, y: 0.7618610215434698d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.823070797476223d, y: 0.4516052465026531d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41895465252769204d, y: 0.6795429410859979d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09893839028289608d, y: 0.8703273441575261d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06791196779010866d, y: 0.4751186266650512d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1777994451548096d, y: 0.1341202992945313d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9671704380826563d, y: 0.9052076728857968d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8452959052939008d, y: 0.8075730815875449d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14248118534687415d, y: 0.19424898800924495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2994043343895407d, y: 0.5428483582373557d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5356367279601039d, y: 0.03954787075763855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3192357363445024d, y: 0.18908361747125146d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22106794307458344d, y: 0.42267489282484305d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23021963309750393d, y: 0.6513385364626537d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39750476184408656d, y: 0.976863931219209d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9073259132414563d, y: 0.15358331105956613d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9372625950196317d, y: 0.7523293797132428d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34425521768164813d, y: 0.35119205594835d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4104052207336778d, y: 0.7909149455530844d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6408370699969126d, y: 0.957158011428757d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9850991997652189d, y: 0.7371824697818076d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12228262863234651d, y: 0.6933324100328078d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6396330826823232d, y: 0.9964020428379841d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4945527792047675d, y: 0.5748385940655362d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.033156421004756575d, y: 0.3090310273409175d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9231688058223873d, y: 0.8947480967485222d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.817808448482734d, y: 0.6417901630225595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8245147511901285d, y: 0.015467865507381218d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4238180554295232d, y: 0.13943224345011673d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4904202133120876d, y: 0.33199987170839185d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8166160507611719d, y: 0.05523095402043998d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6835957754553597d, y: 0.9566861998725422d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8144601956286761d, y: 0.73980611370849d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpoint0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpoint0M>(15);

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
                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpoint0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpoint0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpoint0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpoint0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpoint0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpoint0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpoint0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpoint0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpoint0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpoint0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpoint0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpoint0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpoint0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpoint0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpoint0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

