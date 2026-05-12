

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
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.15305748260726026d, y: 0.32915679093675765d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9365687368828626d, y: 0.7017403808570465d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5763257048983356d, y: 0.7125606827583153d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.39643385266706954d, y: 0.4507162221540968d),
},
            new NpgsqlPointpointE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.31408925236107565d, y: 0.1352673119258695d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8276028037871084d, y: 0.3517260994022112d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5822802214745073d, y: 0.05658814971633419d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5602919886728607d, y: 0.9712327268386284d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8469463239283805d, y: 0.8602762757663838d),
},
            new NpgsqlPointpointE0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3938077530506112d, y: 0.05501669204749393d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.44766099192195186d, y: 0.2989393110426618d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.013556205223383744d, y: 0.3997263443980398d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5585535909259934d, y: 0.2069109843013469d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7204420077709928d, y: 0.43502223473099333d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.05307003361043394d, y: 0.8419812407544225d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6624788604174228d, y: 0.007916182035473507d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3718942407512328d, y: 0.32592351602870817d),
},
            new NpgsqlPointpointE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5720097805073163d, y: 0.22931317481683355d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.056517844912866044d, y: 0.46164269002993497d),
},
            new NpgsqlPointpointE0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.011850812445553083d, y: 0.7821680247257908d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1284416562935109d, y: 0.2638734729149462d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7371030488720182d, y: 0.8254861245437117d),
},
            new NpgsqlPointpointE0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.624607973367119d, y: 0.303682801235449d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6601549525156553d, y: 0.3031024227335587d),
},
            new NpgsqlPointpointE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.46625046609809007d, y: 0.08313594083609044d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3063493462257376d, y: 0.20779760886135135d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5661329541557337d, y: 0.3814162161800143d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06678493752056958d, y: 0.3165500337864443d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6994219770749046d, y: 0.440162798303121d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.36059756430454837d, y: 0.2529091973898199d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7979251555634974d, y: 0.71181173464646d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.48319573572031993d, y: 0.6183977691688958d),
},
            new NpgsqlPointpointE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24899427287914289d, y: 0.19755117966244218d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6424669959572481d, y: 0.1627336335155054d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9516876732900506d, y: 0.872183115064054d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5397798064709551d, y: 0.11098712369322783d),
},
            new NpgsqlPointpointE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6835053305181407d, y: 0.9304464324055027d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4775453748621892d, y: 0.8397662734352154d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.30883190446539444d, y: 0.45776574858876173d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8114149289738908d, y: 0.7487539188179392d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8188091178927851d, y: 0.22570416587794595d),
},
            new NpgsqlPointpointE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8357335279421925d, y: 0.9059610351031514d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5972081781084285d, y: 0.751383330303202d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8316009609158757d, y: 0.12136163488477814d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.41836879776391345d, y: 0.6362404657908822d),
},
            new NpgsqlPointpointE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4855333754234401d, y: 0.7374222290042628d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8653181653762358d, y: 0.9942171536575688d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.42021480870802197d, y: 0.5549588639734861d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29869134179951196d, y: 0.5874200735822988d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8254104166160517d, y: 0.22475492709803624d),
},
            new NpgsqlPointpointE0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6051707814512888d, y: 0.04070827471057714d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9200650842513003d, y: 0.2263402405730216d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22923377976475967d, y: 0.1192191117030833d),
},
            new NpgsqlPointpointE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.023184399739926476d, y: 0.8615418223012784d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7648041357541928d, y: 0.23739883795359396d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5180031189707696d, y: 0.7728180187091238d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3201609069784166d, y: 0.47143610561564897d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5959062576853698d, y: 0.6569823926530463d),
},
            new NpgsqlPointpointE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.13834350886550495d, y: 0.11306758183282128d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.957867757898665d, y: 0.5153807291361763d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2555045509964755d, y: 0.12918420440869072d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7555775358362163d, y: 0.12197193506567572d),
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.199579454350867d, y: 0.46221621133934343d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.27530256779658924d, y: 0.5582148742538179d),
},
            new NpgsqlPointpointE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.874919630697966d, y: 0.5950698633510612d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8460957535761268d, y: 0.28296975007980885d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6954925482612782d, y: 0.4856240069527732d),
},
            new NpgsqlPointpointE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6911962266414851d, y: 0.6867779628884093d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.979939572944429d, y: 0.9041131713614767d),
},
            new NpgsqlPointpointE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4436948625927919d, y: 0.6844151100570816d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.22225737730226092d, y: 0.6811796806798573d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17787978293727869d, y: 0.7486370252907815d),
},
            new NpgsqlPointpointE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8655524136087029d, y: 0.09890229981371823d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9599681274757015d, y: 0.2617225480857377d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7644763848982017d, y: 0.5026207826110675d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4866308198053848d, y: 0.7972938043591831d),
},
            new NpgsqlPointpointE0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7414244690547567d, y: 0.23709297873775348d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointe0mi(
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
INSERT INTO public.npgsqlpointpointe0mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointE0MI)],
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
INSERT INTO public.npgsqlpointpointe0mi(
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
    npgsqlpointpointe0mi_id
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
                methodParametrName: "npgsqlpointpointe0mi_id", 
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
    npgsqlpointpointe0mi_id
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
    npgsqlpointpointe0mi_id,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8469463239283805d, y: 0.8602762757663838d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3718942407512328d, y: 0.32592351602870817d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointe0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointe0mi_id
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
    npgsqlpointpointe0mi_id,
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
                methodParametrName: "npgsqlpointpointe0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.056517844912866044d, y: 0.46164269002993497d)));
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7371030488720182d, y: 0.8254861245437117d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6601549525156553d, y: 0.3031024227335587d)));
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
    npgsqlpointpointe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpointe0mi_id
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
                parametrName: "npgsqlpointpointe0mi_id", 
                methodParametrName: "npgsqlpointpointe0mi_id", 
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
LEFT JOIN public.npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
LEFT JOIN public.npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[21],_testData[34], false);
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
LEFT JOIN public.npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[22],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[32],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 145, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 73, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 145, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[34], false);
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
LEFT JOIN public.npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 155, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 60, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[15], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[16], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[17], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[18], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[19], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[20], false);
                NpgsqlPointpointE0M.AssertModel(models[6],_testData[21], false);
                NpgsqlPointpointE0M.AssertModel(models[7],_testData[22], false);
                NpgsqlPointpointE0M.AssertModel(models[8],_testData[23], false);
                NpgsqlPointpointE0M.AssertModel(models[9],_testData[24], false);
                NpgsqlPointpointE0M.AssertModel(models[10],_testData[25], false);
                NpgsqlPointpointE0M.AssertModel(models[11],_testData[26], false);
                NpgsqlPointpointE0M.AssertModel(models[12],_testData[27], false);
                NpgsqlPointpointE0M.AssertModel(models[13],_testData[28], false);
                NpgsqlPointpointE0M.AssertModel(models[14],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[15],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[16],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[17],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[18],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[1], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[2], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[3], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[4], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[5], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[6], false);
                NpgsqlPointpointE0M.AssertModel(models[6],_testData[7], false);
                NpgsqlPointpointE0M.AssertModel(models[7],_testData[8], false);
                NpgsqlPointpointE0M.AssertModel(models[8],_testData[9], false);
                NpgsqlPointpointE0M.AssertModel(models[9],_testData[10], false);
                NpgsqlPointpointE0M.AssertModel(models[10],_testData[11], false);
                NpgsqlPointpointE0M.AssertModel(models[11],_testData[12], false);
                NpgsqlPointpointE0M.AssertModel(models[12],_testData[13], false);
                NpgsqlPointpointE0M.AssertModel(models[13],_testData[14], false);
                NpgsqlPointpointE0M.AssertModel(models[14],_testData[15], false);
                NpgsqlPointpointE0M.AssertModel(models[15],_testData[16], false);
                NpgsqlPointpointE0M.AssertModel(models[16],_testData[17], false);
                NpgsqlPointpointE0M.AssertModel(models[17],_testData[18], false);
                NpgsqlPointpointE0M.AssertModel(models[18],_testData[19], false);
                NpgsqlPointpointE0M.AssertModel(models[19],_testData[20], false);
                NpgsqlPointpointE0M.AssertModel(models[20],_testData[21], false);
                NpgsqlPointpointE0M.AssertModel(models[21],_testData[22], false);
                NpgsqlPointpointE0M.AssertModel(models[22],_testData[23], false);
                NpgsqlPointpointE0M.AssertModel(models[23],_testData[24], false);
                NpgsqlPointpointE0M.AssertModel(models[24],_testData[25], false);
                NpgsqlPointpointE0M.AssertModel(models[25],_testData[26], false);
                NpgsqlPointpointE0M.AssertModel(models[26],_testData[27], false);
                NpgsqlPointpointE0M.AssertModel(models[27],_testData[28], false);
                NpgsqlPointpointE0M.AssertModel(models[28],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[29],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[30],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[31],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[32],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[33],_testData[34], false);
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
LEFT JOIN public.npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15305748260726026d, y: 0.32915679093675765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9365687368828626d, y: 0.7017403808570465d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5763257048983356d, y: 0.7125606827583153d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39643385266706954d, y: 0.4507162221540968d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31408925236107565d, y: 0.1352673119258695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8276028037871084d, y: 0.3517260994022112d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5822802214745073d, y: 0.05658814971633419d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5602919886728607d, y: 0.9712327268386284d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8469463239283805d, y: 0.8602762757663838d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3938077530506112d, y: 0.05501669204749393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44766099192195186d, y: 0.2989393110426618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013556205223383744d, y: 0.3997263443980398d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5585535909259934d, y: 0.2069109843013469d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7204420077709928d, y: 0.43502223473099333d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05307003361043394d, y: 0.8419812407544225d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6624788604174228d, y: 0.007916182035473507d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3718942407512328d, y: 0.32592351602870817d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5720097805073163d, y: 0.22931317481683355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.056517844912866044d, y: 0.46164269002993497d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.011850812445553083d, y: 0.7821680247257908d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1284416562935109d, y: 0.2638734729149462d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7371030488720182d, y: 0.8254861245437117d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.624607973367119d, y: 0.303682801235449d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6601549525156553d, y: 0.3031024227335587d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46625046609809007d, y: 0.08313594083609044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3063493462257376d, y: 0.20779760886135135d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5661329541557337d, y: 0.3814162161800143d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06678493752056958d, y: 0.3165500337864443d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6994219770749046d, y: 0.440162798303121d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36059756430454837d, y: 0.2529091973898199d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7979251555634974d, y: 0.71181173464646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48319573572031993d, y: 0.6183977691688958d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24899427287914289d, y: 0.19755117966244218d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6424669959572481d, y: 0.1627336335155054d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9516876732900506d, y: 0.872183115064054d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5397798064709551d, y: 0.11098712369322783d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6835053305181407d, y: 0.9304464324055027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4775453748621892d, y: 0.8397662734352154d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30883190446539444d, y: 0.45776574858876173d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8114149289738908d, y: 0.7487539188179392d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8188091178927851d, y: 0.22570416587794595d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8357335279421925d, y: 0.9059610351031514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5972081781084285d, y: 0.751383330303202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8316009609158757d, y: 0.12136163488477814d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41836879776391345d, y: 0.6362404657908822d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4855333754234401d, y: 0.7374222290042628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8653181653762358d, y: 0.9942171536575688d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42021480870802197d, y: 0.5549588639734861d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29869134179951196d, y: 0.5874200735822988d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8254104166160517d, y: 0.22475492709803624d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6051707814512888d, y: 0.04070827471057714d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9200650842513003d, y: 0.2263402405730216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22923377976475967d, y: 0.1192191117030833d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.023184399739926476d, y: 0.8615418223012784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7648041357541928d, y: 0.23739883795359396d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5180031189707696d, y: 0.7728180187091238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3201609069784166d, y: 0.47143610561564897d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5959062576853698d, y: 0.6569823926530463d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13834350886550495d, y: 0.11306758183282128d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.957867757898665d, y: 0.5153807291361763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2555045509964755d, y: 0.12918420440869072d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7555775358362163d, y: 0.12197193506567572d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.199579454350867d, y: 0.46221621133934343d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27530256779658924d, y: 0.5582148742538179d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.874919630697966d, y: 0.5950698633510612d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8460957535761268d, y: 0.28296975007980885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6954925482612782d, y: 0.4856240069527732d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6911962266414851d, y: 0.6867779628884093d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.979939572944429d, y: 0.9041131713614767d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4436948625927919d, y: 0.6844151100570816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22225737730226092d, y: 0.6811796806798573d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17787978293727869d, y: 0.7486370252907815d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8655524136087029d, y: 0.09890229981371823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9599681274757015d, y: 0.2617225480857377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7644763848982017d, y: 0.5026207826110675d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4866308198053848d, y: 0.7972938043591831d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7414244690547567d, y: 0.23709297873775348d))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15305748260726026d, y: 0.32915679093675765d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9365687368828626d, y: 0.7017403808570465d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5763257048983356d, y: 0.7125606827583153d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39643385266706954d, y: 0.4507162221540968d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31408925236107565d, y: 0.1352673119258695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8276028037871084d, y: 0.3517260994022112d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5822802214745073d, y: 0.05658814971633419d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5602919886728607d, y: 0.9712327268386284d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8469463239283805d, y: 0.8602762757663838d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3938077530506112d, y: 0.05501669204749393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44766099192195186d, y: 0.2989393110426618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.013556205223383744d, y: 0.3997263443980398d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5585535909259934d, y: 0.2069109843013469d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7204420077709928d, y: 0.43502223473099333d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05307003361043394d, y: 0.8419812407544225d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6624788604174228d, y: 0.007916182035473507d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3718942407512328d, y: 0.32592351602870817d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5720097805073163d, y: 0.22931317481683355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.056517844912866044d, y: 0.46164269002993497d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.011850812445553083d, y: 0.7821680247257908d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1284416562935109d, y: 0.2638734729149462d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7371030488720182d, y: 0.8254861245437117d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.624607973367119d, y: 0.303682801235449d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6601549525156553d, y: 0.3031024227335587d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.46625046609809007d, y: 0.08313594083609044d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3063493462257376d, y: 0.20779760886135135d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5661329541557337d, y: 0.3814162161800143d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06678493752056958d, y: 0.3165500337864443d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6994219770749046d, y: 0.440162798303121d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36059756430454837d, y: 0.2529091973898199d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7979251555634974d, y: 0.71181173464646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48319573572031993d, y: 0.6183977691688958d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24899427287914289d, y: 0.19755117966244218d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6424669959572481d, y: 0.1627336335155054d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9516876732900506d, y: 0.872183115064054d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5397798064709551d, y: 0.11098712369322783d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6835053305181407d, y: 0.9304464324055027d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4775453748621892d, y: 0.8397662734352154d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30883190446539444d, y: 0.45776574858876173d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8114149289738908d, y: 0.7487539188179392d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8188091178927851d, y: 0.22570416587794595d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8357335279421925d, y: 0.9059610351031514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5972081781084285d, y: 0.751383330303202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8316009609158757d, y: 0.12136163488477814d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41836879776391345d, y: 0.6362404657908822d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4855333754234401d, y: 0.7374222290042628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8653181653762358d, y: 0.9942171536575688d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42021480870802197d, y: 0.5549588639734861d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29869134179951196d, y: 0.5874200735822988d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8254104166160517d, y: 0.22475492709803624d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6051707814512888d, y: 0.04070827471057714d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9200650842513003d, y: 0.2263402405730216d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22923377976475967d, y: 0.1192191117030833d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.023184399739926476d, y: 0.8615418223012784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7648041357541928d, y: 0.23739883795359396d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5180031189707696d, y: 0.7728180187091238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3201609069784166d, y: 0.47143610561564897d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5959062576853698d, y: 0.6569823926530463d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.13834350886550495d, y: 0.11306758183282128d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.957867757898665d, y: 0.5153807291361763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2555045509964755d, y: 0.12918420440869072d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7555775358362163d, y: 0.12197193506567572d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.199579454350867d, y: 0.46221621133934343d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.27530256779658924d, y: 0.5582148742538179d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.874919630697966d, y: 0.5950698633510612d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8460957535761268d, y: 0.28296975007980885d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6954925482612782d, y: 0.4856240069527732d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6911962266414851d, y: 0.6867779628884093d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.979939572944429d, y: 0.9041131713614767d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4436948625927919d, y: 0.6844151100570816d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22225737730226092d, y: 0.6811796806798573d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17787978293727869d, y: 0.7486370252907815d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8655524136087029d, y: 0.09890229981371823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9599681274757015d, y: 0.2617225480857377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7644763848982017d, y: 0.5026207826110675d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4866308198053848d, y: 0.7972938043591831d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7414244690547567d, y: 0.23709297873775348d))));//Value

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
FROM public.binary_npgsqlpointpointe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
            queryMapType: typeof(NpgsqlPointpointE0MIWA),
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
            queryMapType: typeof(NpgsqlPointpointE0MIWA),
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MI)],
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
COPY public.binary_npgsqlpointpointe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointE0MI),
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
                var importCollection = new List<NpgsqlPointpointE0MI>(2);
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
                    NpgsqlPointpointE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointE0MI>(2);
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
                    NpgsqlPointpointE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
COPY public.binary_npgsqlpointpointe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointE0MIWA),
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointE0MIWA
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
                    NpgsqlPointpointE0MIWA.AssertModel(actual, expect, false);
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
npgsqlpointpointe0mi_id,
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
LEFT JOIN public.binary_npgsqlpointpointe0mi mi ON mi.id = m.npgsqlpointpointe0mi_id
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
    npgsqlpointpointe0mi_id,
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
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA), typeof(NpgsqlPointpointE0MIWA)],
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA), typeof(NpgsqlPointpointE0MIWA)],
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpointpointe0mi
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MI), typeof(NpgsqlPointpointE0MI)],
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
                var models1 = new List<NpgsqlPointpointE0MI>();
                var models2 = new List<NpgsqlPointpointE0MI>();
                await ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointE0MI>();
                var models2 = new List<NpgsqlPointpointE0MI>();
                ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MI)],
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
                    NpgsqlPointpointE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPointpointE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA), typeof(NpgsqlPointpointE0MIWA)],
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointE0MIWA>();
                var models2 = new List<NpgsqlPointpointE0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointE0MIWA)],
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPointpointE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

