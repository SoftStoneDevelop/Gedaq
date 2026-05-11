

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17097283016556752d, y: 0.49432691039823295d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.47521089502212543d, y: 0.4235405646683694d),
},
            new NpgsqlPointpointE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9677796621287119d, y: 0.6445646492861205d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6294408981585023d, y: 0.8706923603059995d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.42368539742689404d, y: 0.1259756141063867d),
},
            new NpgsqlPointpointE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.032518123344240424d, y: 0.25387216477418206d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.606911317530642d, y: 0.656512688128944d),
},
            new NpgsqlPointpointE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.932319377844888d, y: 0.21941492908355265d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6577342624190768d, y: 0.18956222230675523d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.03250014385333244d, y: 0.35290532973847244d),
},
            new NpgsqlPointpointE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.07863787711216486d, y: 0.33253748318516707d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8023294722555353d, y: 0.9060381589411228d),
},
            new NpgsqlPointpointE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5071592984230963d, y: 0.02018474347164667d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4516227488944251d, y: 0.7446463037847361d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5601396659586733d, y: 0.14423954961198493d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.38306756035832845d, y: 0.45517171579897164d),
},
            new NpgsqlPointpointE0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3264962533636512d, y: 0.8212216852669889d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7935128633155882d, y: 0.47337254404683227d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.676967549126583d, y: 0.3277892251691802d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8070532067271136d, y: 0.06867089406989191d),
},
            new NpgsqlPointpointE0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5293361534309348d, y: 0.7393422271283597d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.0025229468686434053d, y: 0.7101550876167381d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.669145385786332d, y: 0.010654624835099713d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.737636662580995d, y: 0.46237999167720056d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6017930280881738d, y: 0.9057124088655258d),
},
            new NpgsqlPointpointE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.005327831002975403d, y: 0.3105734466780622d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2994234597761466d, y: 0.8760869237177618d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4777918328625719d, y: 0.9797194424518166d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9413019063464579d, y: 0.21735562408523001d),
},
            new NpgsqlPointpointE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6747265722926636d, y: 0.46436332189805196d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.48177679557446973d, y: 0.8010588387072789d),
},
            new NpgsqlPointpointE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.19473463018363424d, y: 0.9713778112512188d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7853378006381906d, y: 0.47755502510927783d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5574544753453335d, y: 0.4256417109995184d),
},
            new NpgsqlPointpointE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.23581798509732177d, y: 0.14970047131506725d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1094099290451297d, y: 0.3729717708770186d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5190906188518942d, y: 0.7975993510255363d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9507555731552584d, y: 0.12140087315699799d),
},
            new NpgsqlPointpointE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.872072433027681d, y: 0.9906128046942276d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6470070573480349d, y: 0.019648878418903615d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.21548940803843641d, y: 0.4644527513975467d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06790914817724991d, y: 0.5380968863226888d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.205417727067308d, y: 0.3309603156981833d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6880267644697441d, y: 0.46219333409628893d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9461165059597143d, y: 0.6251632347030087d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7716697404910065d, y: 0.6887918302557395d),
},
            new NpgsqlPointpointE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9145127513698401d, y: 0.09884030122573717d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6802022392275114d, y: 0.5248636749533898d),
},
            new NpgsqlPointpointE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7559339449573387d, y: 0.5048431869736536d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5950255978063812d, y: 0.9115860440033322d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7630841721679797d, y: 0.0219544904049509d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.15586571520793202d, y: 0.5704146568255207d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.40814770727072847d, y: 0.9246954804601207d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.35438238134269173d, y: 0.461494411678276d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9029917597872383d, y: 0.3331258749804865d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9176194883610725d, y: 0.6944341244978434d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2644320405045487d, y: 0.2337105326098089d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.14737213093865675d, y: 0.42833364395976836d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9736781292265664d, y: 0.287631157604087d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3033269146833819d, y: 0.48830300937542814d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5995562542733966d, y: 0.9177866055176604d),
},
            new NpgsqlPointpointE0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6059744176235623d, y: 0.30349369919358904d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.14574927949946614d, y: 0.011939298533451104d),
},
            new NpgsqlPointpointE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4240044740810883d, y: 0.9816725544091248d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.012410085209317634d, y: 0.8930491898659162d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.07130888333228502d, y: 0.0737821600489057d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointE0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.11545645757522538d, y: 0.8284980109852579d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7416624553262717d, y: 0.5138685527752936d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.31816642953652263d, y: 0.1733269426353412d),
},
            new NpgsqlPointpointE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8297374549928279d, y: 0.0858873514471784d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.04033357057520692d, y: 0.30842854066879144d),
},
            new NpgsqlPointpointE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5572351340652757d, y: 0.7577190075341981d),
    ModelInner = new NpgsqlPointpointE0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.21877017391191478d, y: 0.7820809036473517d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.10214228043934515d, y: 0.9659894805044511d),
},
            new NpgsqlPointpointE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6109802467117595d, y: 0.9761967980618302d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1672820211316972d, y: 0.2686061510267761d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8023294722555353d, y: 0.9060381589411228d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.38306756035832845d, y: 0.45517171579897164d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8070532067271136d, y: 0.06867089406989191d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6017930280881738d, y: 0.9057124088655258d)));
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.9413019063464579d, y: 0.21735562408523001d)));
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 82;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 134, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[29],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(models[3],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 70))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 9, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[9], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[10], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[11], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[12], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[13], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[14], false);
                NpgsqlPointpointE0M.AssertModel(models[6],_testData[15], false);
                NpgsqlPointpointE0M.AssertModel(models[7],_testData[16], false);
                NpgsqlPointpointE0M.AssertModel(models[8],_testData[17], false);
                NpgsqlPointpointE0M.AssertModel(models[9],_testData[18], false);
                NpgsqlPointpointE0M.AssertModel(models[10],_testData[19], false);
                NpgsqlPointpointE0M.AssertModel(models[11],_testData[20], false);
                NpgsqlPointpointE0M.AssertModel(models[12],_testData[21], false);
                NpgsqlPointpointE0M.AssertModel(models[13],_testData[22], false);
                NpgsqlPointpointE0M.AssertModel(models[14],_testData[23], false);
                NpgsqlPointpointE0M.AssertModel(models[15],_testData[24], false);
                NpgsqlPointpointE0M.AssertModel(models[16],_testData[25], false);
                NpgsqlPointpointE0M.AssertModel(models[17],_testData[26], false);
                NpgsqlPointpointE0M.AssertModel(models[18],_testData[27], false);
                NpgsqlPointpointE0M.AssertModel(models[19],_testData[28], false);
                NpgsqlPointpointE0M.AssertModel(models[20],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[21],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[22],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[23],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[24],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPointpointE0M.AssertModel(models[0],_testData[28], false);
                NpgsqlPointpointE0M.AssertModel(models[1],_testData[29], false);
                NpgsqlPointpointE0M.AssertModel(models[2],_testData[30], false);
                NpgsqlPointpointE0M.AssertModel(models[3],_testData[31], false);
                NpgsqlPointpointE0M.AssertModel(models[4],_testData[32], false);
                NpgsqlPointpointE0M.AssertModel(models[5],_testData[33], false);
                NpgsqlPointpointE0M.AssertModel(models[6],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17097283016556752d, y: 0.49432691039823295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47521089502212543d, y: 0.4235405646683694d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9677796621287119d, y: 0.6445646492861205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6294408981585023d, y: 0.8706923603059995d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42368539742689404d, y: 0.1259756141063867d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.032518123344240424d, y: 0.25387216477418206d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.606911317530642d, y: 0.656512688128944d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.932319377844888d, y: 0.21941492908355265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6577342624190768d, y: 0.18956222230675523d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03250014385333244d, y: 0.35290532973847244d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07863787711216486d, y: 0.33253748318516707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8023294722555353d, y: 0.9060381589411228d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5071592984230963d, y: 0.02018474347164667d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4516227488944251d, y: 0.7446463037847361d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5601396659586733d, y: 0.14423954961198493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38306756035832845d, y: 0.45517171579897164d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3264962533636512d, y: 0.8212216852669889d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7935128633155882d, y: 0.47337254404683227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.676967549126583d, y: 0.3277892251691802d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8070532067271136d, y: 0.06867089406989191d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5293361534309348d, y: 0.7393422271283597d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0025229468686434053d, y: 0.7101550876167381d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.669145385786332d, y: 0.010654624835099713d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.737636662580995d, y: 0.46237999167720056d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6017930280881738d, y: 0.9057124088655258d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.005327831002975403d, y: 0.3105734466780622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2994234597761466d, y: 0.8760869237177618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4777918328625719d, y: 0.9797194424518166d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9413019063464579d, y: 0.21735562408523001d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6747265722926636d, y: 0.46436332189805196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48177679557446973d, y: 0.8010588387072789d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19473463018363424d, y: 0.9713778112512188d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7853378006381906d, y: 0.47755502510927783d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5574544753453335d, y: 0.4256417109995184d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23581798509732177d, y: 0.14970047131506725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1094099290451297d, y: 0.3729717708770186d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5190906188518942d, y: 0.7975993510255363d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9507555731552584d, y: 0.12140087315699799d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.872072433027681d, y: 0.9906128046942276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6470070573480349d, y: 0.019648878418903615d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21548940803843641d, y: 0.4644527513975467d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06790914817724991d, y: 0.5380968863226888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.205417727067308d, y: 0.3309603156981833d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6880267644697441d, y: 0.46219333409628893d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9461165059597143d, y: 0.6251632347030087d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7716697404910065d, y: 0.6887918302557395d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9145127513698401d, y: 0.09884030122573717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6802022392275114d, y: 0.5248636749533898d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7559339449573387d, y: 0.5048431869736536d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5950255978063812d, y: 0.9115860440033322d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7630841721679797d, y: 0.0219544904049509d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15586571520793202d, y: 0.5704146568255207d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40814770727072847d, y: 0.9246954804601207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35438238134269173d, y: 0.461494411678276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9029917597872383d, y: 0.3331258749804865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9176194883610725d, y: 0.6944341244978434d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2644320405045487d, y: 0.2337105326098089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14737213093865675d, y: 0.42833364395976836d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9736781292265664d, y: 0.287631157604087d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3033269146833819d, y: 0.48830300937542814d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5995562542733966d, y: 0.9177866055176604d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6059744176235623d, y: 0.30349369919358904d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14574927949946614d, y: 0.011939298533451104d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4240044740810883d, y: 0.9816725544091248d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.012410085209317634d, y: 0.8930491898659162d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07130888333228502d, y: 0.0737821600489057d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11545645757522538d, y: 0.8284980109852579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7416624553262717d, y: 0.5138685527752936d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31816642953652263d, y: 0.1733269426353412d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8297374549928279d, y: 0.0858873514471784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04033357057520692d, y: 0.30842854066879144d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5572351340652757d, y: 0.7577190075341981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21877017391191478d, y: 0.7820809036473517d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10214228043934515d, y: 0.9659894805044511d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6109802467117595d, y: 0.9761967980618302d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1672820211316972d, y: 0.2686061510267761d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17097283016556752d, y: 0.49432691039823295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47521089502212543d, y: 0.4235405646683694d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9677796621287119d, y: 0.6445646492861205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6294408981585023d, y: 0.8706923603059995d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42368539742689404d, y: 0.1259756141063867d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.032518123344240424d, y: 0.25387216477418206d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.606911317530642d, y: 0.656512688128944d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.932319377844888d, y: 0.21941492908355265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6577342624190768d, y: 0.18956222230675523d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03250014385333244d, y: 0.35290532973847244d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07863787711216486d, y: 0.33253748318516707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8023294722555353d, y: 0.9060381589411228d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5071592984230963d, y: 0.02018474347164667d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4516227488944251d, y: 0.7446463037847361d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5601396659586733d, y: 0.14423954961198493d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38306756035832845d, y: 0.45517171579897164d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3264962533636512d, y: 0.8212216852669889d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7935128633155882d, y: 0.47337254404683227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.676967549126583d, y: 0.3277892251691802d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8070532067271136d, y: 0.06867089406989191d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5293361534309348d, y: 0.7393422271283597d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0025229468686434053d, y: 0.7101550876167381d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.669145385786332d, y: 0.010654624835099713d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.737636662580995d, y: 0.46237999167720056d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6017930280881738d, y: 0.9057124088655258d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.005327831002975403d, y: 0.3105734466780622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2994234597761466d, y: 0.8760869237177618d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4777918328625719d, y: 0.9797194424518166d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9413019063464579d, y: 0.21735562408523001d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6747265722926636d, y: 0.46436332189805196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48177679557446973d, y: 0.8010588387072789d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19473463018363424d, y: 0.9713778112512188d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7853378006381906d, y: 0.47755502510927783d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5574544753453335d, y: 0.4256417109995184d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.23581798509732177d, y: 0.14970047131506725d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1094099290451297d, y: 0.3729717708770186d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5190906188518942d, y: 0.7975993510255363d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9507555731552584d, y: 0.12140087315699799d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.872072433027681d, y: 0.9906128046942276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6470070573480349d, y: 0.019648878418903615d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21548940803843641d, y: 0.4644527513975467d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06790914817724991d, y: 0.5380968863226888d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.205417727067308d, y: 0.3309603156981833d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6880267644697441d, y: 0.46219333409628893d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9461165059597143d, y: 0.6251632347030087d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7716697404910065d, y: 0.6887918302557395d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9145127513698401d, y: 0.09884030122573717d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6802022392275114d, y: 0.5248636749533898d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7559339449573387d, y: 0.5048431869736536d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5950255978063812d, y: 0.9115860440033322d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7630841721679797d, y: 0.0219544904049509d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.15586571520793202d, y: 0.5704146568255207d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40814770727072847d, y: 0.9246954804601207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35438238134269173d, y: 0.461494411678276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9029917597872383d, y: 0.3331258749804865d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9176194883610725d, y: 0.6944341244978434d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2644320405045487d, y: 0.2337105326098089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14737213093865675d, y: 0.42833364395976836d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9736781292265664d, y: 0.287631157604087d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3033269146833819d, y: 0.48830300937542814d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5995562542733966d, y: 0.9177866055176604d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6059744176235623d, y: 0.30349369919358904d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14574927949946614d, y: 0.011939298533451104d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4240044740810883d, y: 0.9816725544091248d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.012410085209317634d, y: 0.8930491898659162d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07130888333228502d, y: 0.0737821600489057d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11545645757522538d, y: 0.8284980109852579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7416624553262717d, y: 0.5138685527752936d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31816642953652263d, y: 0.1733269426353412d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8297374549928279d, y: 0.0858873514471784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04033357057520692d, y: 0.30842854066879144d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5572351340652757d, y: 0.7577190075341981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.21877017391191478d, y: 0.7820809036473517d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10214228043934515d, y: 0.9659894805044511d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6109802467117595d, y: 0.9761967980618302d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1672820211316972d, y: 0.2686061510267761d))));

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

