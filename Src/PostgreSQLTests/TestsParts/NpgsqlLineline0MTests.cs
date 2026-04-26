

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
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24617389780321663d, b: 0.5562625993898225d, c: 0.5663193183566727d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.47935105133617095d, b: 0.2548099212369125d, c: 0.6931286850409413d),
},
            new NpgsqlLineline0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7502152008510459d, b: 0.1653812065345429d, c: 0.1018782998279757d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7867574318649052d, b: 0.9259491526940159d, c: 0.8421299389759078d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5238970307298572d, b: 0.46254772708853165d, c: 0.40741665025170715d),
},
            new NpgsqlLineline0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.44943601378342846d, b: 0.1954179425864938d, c: 0.3113488737696922d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04903623861940376d, b: 0.5087964323373506d, c: 0.3348260267484887d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.14431138689070233d, b: 0.8865427383911618d, c: 0.9799348587620289d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8482308136530633d, b: 0.1722499914010932d, c: 0.33141836135233504d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5290443857305412d, b: 0.3849564090039054d, c: 0.9166230561947707d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9344929035348918d, b: 0.15188406647226949d, c: 0.5068958147433422d),
},
            new NpgsqlLineline0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10378913039864957d, b: 0.7425281397917652d, c: 0.614947096173867d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19882616538831954d, b: 0.5008043049966546d, c: 0.15365074522029343d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1405222014239379d, b: 0.24772682104409105d, c: 0.15701205370714422d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6234232190795487d, b: 0.4501625285879558d, c: 0.6724691691019833d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.938583596213211d, b: 0.4546744518165682d, c: 0.16443029342187232d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9963908496627452d, b: 0.4208706043007361d, c: 0.4116102817356807d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.37881237979347837d, b: 0.6524742067088378d, c: 0.6000927870079857d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04282919419186215d, b: 0.3310941663867718d, c: 0.884467007241726d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2621746846372236d, b: 0.8887256035970985d, c: 0.32459237720715073d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7312530950389575d, b: 0.21202711053050827d, c: 0.95424788074214d),
},
            new NpgsqlLineline0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7760146833836277d, b: 0.544508423485726d, c: 0.5563299970581755d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4265738123975177d, b: 0.21108923576294625d, c: 0.502305921566274d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6878815194661992d, b: 0.29902686721487715d, c: 0.5041876468676549d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45446693563444807d, b: 0.2082573032594266d, c: 0.30635924464542275d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.662645252373063d, b: 0.17721918330715447d, c: 0.05538381349130728d),
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5597159124703102d, b: 0.09125437857948293d, c: 0.3820536247665085d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17354580560863686d, b: 0.1617348635761764d, c: 0.8418182426238774d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6889864622213393d, b: 0.9170152769718387d, c: 0.4015852899214586d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5385943851870948d, b: 0.23374073103705462d, c: 0.6066822533402368d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9820844463402857d, b: 0.604512783066651d, c: 0.7725333623052361d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7370495187016678d, b: 0.8959155520103917d, c: 0.8938346684096484d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4061441092853675d, b: 0.9310817702462301d, c: 0.862580219868992d),
},
            new NpgsqlLineline0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0886677166721801d, b: 0.3690872769715817d, c: 0.8473580660978184d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.999248004166833d, b: 0.4028395323208208d, c: 0.9101896154469235d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9053145830797441d, b: 0.4521607268307385d, c: 0.7307637308183584d),
},
            new NpgsqlLineline0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9063850721113941d, b: 0.10940452977809112d, c: 0.6744559258219333d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7416925379515827d, b: 0.3626313327577054d, c: 0.17814198349875776d),
},
            new NpgsqlLineline0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.046852383531916564d, b: 0.28447083276598173d, c: 0.04233216130885753d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45954367548269537d, b: 0.2445378126981247d, c: 0.3367694937718527d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19054241639625813d, b: 0.6709331028025403d, c: 0.9754964728438024d),
},
            new NpgsqlLineline0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4108850756650462d, b: 0.7640579719226723d, c: 0.7373801363462077d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.48311046247873113d, b: 0.8441538296322543d, c: 0.8316163024059607d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6510222976784539d, b: 0.892095763231039d, c: 0.15282166536953745d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.008615983526862103d, b: 0.6903829239663587d, c: 0.6044345006198567d),
},
            new NpgsqlLineline0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03151069007898677d, b: 0.45122112588004926d, c: 0.5048025700912756d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5555670330140223d, b: 0.6391670763910022d, c: 0.044362054688286356d),
},
            new NpgsqlLineline0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8963106530133762d, b: 0.2851241130534504d, c: 0.6745105532400244d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24205801824224804d, b: 0.9808817669136111d, c: 0.9198424646088426d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9780262109468594d, b: 0.255428492447784d, c: 0.5047294516776908d),
},
            new NpgsqlLineline0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4962760441714039d, b: 0.8303943083388237d, c: 0.541142529286225d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3019619033585814d, b: 0.6821259277857519d, c: 0.633737022097644d),
},
            new NpgsqlLineline0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.29288612722398677d, b: 0.2376521734029694d, c: 0.8839523513221271d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.42193761613991254d, b: 0.546342349506732d, c: 0.11387246646562521d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5667434524560414d, b: 0.6395361016529204d, c: 0.6550852520799447d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.30176014155694053d, b: 0.6544040644501693d, c: 0.5795059455464d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9707763865535195d, b: 0.04434290823179443d, c: 0.9085958826526989d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5803146560770176d, b: 0.15541887429527146d, c: 0.37956955644364454d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12934753335269022d, b: 0.22204346436613542d, c: 0.4526426254759859d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6169073777743205d, b: 0.8150862585640486d, c: 0.7755701451584d),
},
            new NpgsqlLineline0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13546057489337726d, b: 0.2586592577956611d, c: 0.04177918336774589d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1607465193925237d, b: 0.03909433371128368d, c: 0.31912714405319176d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.874537475893037d, b: 0.5251344615591623d, c: 0.47490756261085354d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9344929035348918d, b: 0.15188406647226949d, c: 0.5068958147433422d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7312530950389575d, b: 0.21202711053050827d, c: 0.95424788074214d)));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 145, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 17, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 112, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 145, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlLineline0M.AssertModel(models[0],_testData[27], false);NpgsqlLineline0M.AssertModel(models[1],_testData[28], false);NpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLineline0M.AssertModel(models[0],_testData[16], false);NpgsqlLineline0M.AssertModel(models[1],_testData[17], false);NpgsqlLineline0M.AssertModel(models[2],_testData[18], false);NpgsqlLineline0M.AssertModel(models[3],_testData[19], false);NpgsqlLineline0M.AssertModel(models[4],_testData[20], false);NpgsqlLineline0M.AssertModel(models[5],_testData[21], false);NpgsqlLineline0M.AssertModel(models[6],_testData[22], false);NpgsqlLineline0M.AssertModel(models[7],_testData[23], false);NpgsqlLineline0M.AssertModel(models[8],_testData[24], false);NpgsqlLineline0M.AssertModel(models[9],_testData[25], false);NpgsqlLineline0M.AssertModel(models[10],_testData[26], false);NpgsqlLineline0M.AssertModel(models[11],_testData[27], false);NpgsqlLineline0M.AssertModel(models[12],_testData[28], false);NpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24617389780321663d, b: 0.5562625993898225d, c: 0.5663193183566727d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47935105133617095d, b: 0.2548099212369125d, c: 0.6931286850409413d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7502152008510459d, b: 0.1653812065345429d, c: 0.1018782998279757d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7867574318649052d, b: 0.9259491526940159d, c: 0.8421299389759078d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5238970307298572d, b: 0.46254772708853165d, c: 0.40741665025170715d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44943601378342846d, b: 0.1954179425864938d, c: 0.3113488737696922d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04903623861940376d, b: 0.5087964323373506d, c: 0.3348260267484887d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14431138689070233d, b: 0.8865427383911618d, c: 0.9799348587620289d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8482308136530633d, b: 0.1722499914010932d, c: 0.33141836135233504d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5290443857305412d, b: 0.3849564090039054d, c: 0.9166230561947707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9344929035348918d, b: 0.15188406647226949d, c: 0.5068958147433422d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10378913039864957d, b: 0.7425281397917652d, c: 0.614947096173867d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19882616538831954d, b: 0.5008043049966546d, c: 0.15365074522029343d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1405222014239379d, b: 0.24772682104409105d, c: 0.15701205370714422d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6234232190795487d, b: 0.4501625285879558d, c: 0.6724691691019833d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.938583596213211d, b: 0.4546744518165682d, c: 0.16443029342187232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9963908496627452d, b: 0.4208706043007361d, c: 0.4116102817356807d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37881237979347837d, b: 0.6524742067088378d, c: 0.6000927870079857d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04282919419186215d, b: 0.3310941663867718d, c: 0.884467007241726d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2621746846372236d, b: 0.8887256035970985d, c: 0.32459237720715073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7312530950389575d, b: 0.21202711053050827d, c: 0.95424788074214d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7760146833836277d, b: 0.544508423485726d, c: 0.5563299970581755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4265738123975177d, b: 0.21108923576294625d, c: 0.502305921566274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6878815194661992d, b: 0.29902686721487715d, c: 0.5041876468676549d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45446693563444807d, b: 0.2082573032594266d, c: 0.30635924464542275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.662645252373063d, b: 0.17721918330715447d, c: 0.05538381349130728d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5597159124703102d, b: 0.09125437857948293d, c: 0.3820536247665085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17354580560863686d, b: 0.1617348635761764d, c: 0.8418182426238774d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6889864622213393d, b: 0.9170152769718387d, c: 0.4015852899214586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5385943851870948d, b: 0.23374073103705462d, c: 0.6066822533402368d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9820844463402857d, b: 0.604512783066651d, c: 0.7725333623052361d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7370495187016678d, b: 0.8959155520103917d, c: 0.8938346684096484d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4061441092853675d, b: 0.9310817702462301d, c: 0.862580219868992d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0886677166721801d, b: 0.3690872769715817d, c: 0.8473580660978184d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.999248004166833d, b: 0.4028395323208208d, c: 0.9101896154469235d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9053145830797441d, b: 0.4521607268307385d, c: 0.7307637308183584d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9063850721113941d, b: 0.10940452977809112d, c: 0.6744559258219333d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7416925379515827d, b: 0.3626313327577054d, c: 0.17814198349875776d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.046852383531916564d, b: 0.28447083276598173d, c: 0.04233216130885753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45954367548269537d, b: 0.2445378126981247d, c: 0.3367694937718527d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19054241639625813d, b: 0.6709331028025403d, c: 0.9754964728438024d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4108850756650462d, b: 0.7640579719226723d, c: 0.7373801363462077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48311046247873113d, b: 0.8441538296322543d, c: 0.8316163024059607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6510222976784539d, b: 0.892095763231039d, c: 0.15282166536953745d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.008615983526862103d, b: 0.6903829239663587d, c: 0.6044345006198567d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03151069007898677d, b: 0.45122112588004926d, c: 0.5048025700912756d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5555670330140223d, b: 0.6391670763910022d, c: 0.044362054688286356d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8963106530133762d, b: 0.2851241130534504d, c: 0.6745105532400244d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24205801824224804d, b: 0.9808817669136111d, c: 0.9198424646088426d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9780262109468594d, b: 0.255428492447784d, c: 0.5047294516776908d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4962760441714039d, b: 0.8303943083388237d, c: 0.541142529286225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3019619033585814d, b: 0.6821259277857519d, c: 0.633737022097644d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29288612722398677d, b: 0.2376521734029694d, c: 0.8839523513221271d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42193761613991254d, b: 0.546342349506732d, c: 0.11387246646562521d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5667434524560414d, b: 0.6395361016529204d, c: 0.6550852520799447d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30176014155694053d, b: 0.6544040644501693d, c: 0.5795059455464d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9707763865535195d, b: 0.04434290823179443d, c: 0.9085958826526989d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5803146560770176d, b: 0.15541887429527146d, c: 0.37956955644364454d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12934753335269022d, b: 0.22204346436613542d, c: 0.4526426254759859d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6169073777743205d, b: 0.8150862585640486d, c: 0.7755701451584d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13546057489337726d, b: 0.2586592577956611d, c: 0.04177918336774589d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1607465193925237d, b: 0.03909433371128368d, c: 0.31912714405319176d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.874537475893037d, b: 0.5251344615591623d, c: 0.47490756261085354d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24617389780321663d, b: 0.5562625993898225d, c: 0.5663193183566727d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47935105133617095d, b: 0.2548099212369125d, c: 0.6931286850409413d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7502152008510459d, b: 0.1653812065345429d, c: 0.1018782998279757d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7867574318649052d, b: 0.9259491526940159d, c: 0.8421299389759078d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5238970307298572d, b: 0.46254772708853165d, c: 0.40741665025170715d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44943601378342846d, b: 0.1954179425864938d, c: 0.3113488737696922d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04903623861940376d, b: 0.5087964323373506d, c: 0.3348260267484887d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.14431138689070233d, b: 0.8865427383911618d, c: 0.9799348587620289d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8482308136530633d, b: 0.1722499914010932d, c: 0.33141836135233504d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5290443857305412d, b: 0.3849564090039054d, c: 0.9166230561947707d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9344929035348918d, b: 0.15188406647226949d, c: 0.5068958147433422d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10378913039864957d, b: 0.7425281397917652d, c: 0.614947096173867d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19882616538831954d, b: 0.5008043049966546d, c: 0.15365074522029343d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1405222014239379d, b: 0.24772682104409105d, c: 0.15701205370714422d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6234232190795487d, b: 0.4501625285879558d, c: 0.6724691691019833d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.938583596213211d, b: 0.4546744518165682d, c: 0.16443029342187232d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9963908496627452d, b: 0.4208706043007361d, c: 0.4116102817356807d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.37881237979347837d, b: 0.6524742067088378d, c: 0.6000927870079857d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04282919419186215d, b: 0.3310941663867718d, c: 0.884467007241726d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2621746846372236d, b: 0.8887256035970985d, c: 0.32459237720715073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7312530950389575d, b: 0.21202711053050827d, c: 0.95424788074214d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7760146833836277d, b: 0.544508423485726d, c: 0.5563299970581755d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4265738123975177d, b: 0.21108923576294625d, c: 0.502305921566274d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6878815194661992d, b: 0.29902686721487715d, c: 0.5041876468676549d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45446693563444807d, b: 0.2082573032594266d, c: 0.30635924464542275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.662645252373063d, b: 0.17721918330715447d, c: 0.05538381349130728d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5597159124703102d, b: 0.09125437857948293d, c: 0.3820536247665085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17354580560863686d, b: 0.1617348635761764d, c: 0.8418182426238774d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6889864622213393d, b: 0.9170152769718387d, c: 0.4015852899214586d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5385943851870948d, b: 0.23374073103705462d, c: 0.6066822533402368d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9820844463402857d, b: 0.604512783066651d, c: 0.7725333623052361d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7370495187016678d, b: 0.8959155520103917d, c: 0.8938346684096484d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4061441092853675d, b: 0.9310817702462301d, c: 0.862580219868992d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0886677166721801d, b: 0.3690872769715817d, c: 0.8473580660978184d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.999248004166833d, b: 0.4028395323208208d, c: 0.9101896154469235d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9053145830797441d, b: 0.4521607268307385d, c: 0.7307637308183584d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9063850721113941d, b: 0.10940452977809112d, c: 0.6744559258219333d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7416925379515827d, b: 0.3626313327577054d, c: 0.17814198349875776d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.046852383531916564d, b: 0.28447083276598173d, c: 0.04233216130885753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45954367548269537d, b: 0.2445378126981247d, c: 0.3367694937718527d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19054241639625813d, b: 0.6709331028025403d, c: 0.9754964728438024d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4108850756650462d, b: 0.7640579719226723d, c: 0.7373801363462077d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48311046247873113d, b: 0.8441538296322543d, c: 0.8316163024059607d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6510222976784539d, b: 0.892095763231039d, c: 0.15282166536953745d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.008615983526862103d, b: 0.6903829239663587d, c: 0.6044345006198567d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03151069007898677d, b: 0.45122112588004926d, c: 0.5048025700912756d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5555670330140223d, b: 0.6391670763910022d, c: 0.044362054688286356d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8963106530133762d, b: 0.2851241130534504d, c: 0.6745105532400244d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24205801824224804d, b: 0.9808817669136111d, c: 0.9198424646088426d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9780262109468594d, b: 0.255428492447784d, c: 0.5047294516776908d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4962760441714039d, b: 0.8303943083388237d, c: 0.541142529286225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3019619033585814d, b: 0.6821259277857519d, c: 0.633737022097644d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29288612722398677d, b: 0.2376521734029694d, c: 0.8839523513221271d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42193761613991254d, b: 0.546342349506732d, c: 0.11387246646562521d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5667434524560414d, b: 0.6395361016529204d, c: 0.6550852520799447d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.30176014155694053d, b: 0.6544040644501693d, c: 0.5795059455464d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9707763865535195d, b: 0.04434290823179443d, c: 0.9085958826526989d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5803146560770176d, b: 0.15541887429527146d, c: 0.37956955644364454d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12934753335269022d, b: 0.22204346436613542d, c: 0.4526426254759859d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6169073777743205d, b: 0.8150862585640486d, c: 0.7755701451584d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13546057489337726d, b: 0.2586592577956611d, c: 0.04177918336774589d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1607465193925237d, b: 0.03909433371128368d, c: 0.31912714405319176d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.874537475893037d, b: 0.5251344615591623d, c: 0.47490756261085354d))));

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlLineline0M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0M>(15);

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
                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[27],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[28],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

