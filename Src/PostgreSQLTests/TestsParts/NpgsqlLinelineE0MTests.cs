

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

        private readonly NpgsqlLinelineE0M[] _testData = new NpgsqlLinelineE0M[]
        {
            new NpgsqlLinelineE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3910155987753552d, b: 0.5608343556009571d, c: 0.8670649931073511d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7059926651426881d, b: 0.6401020050535996d, c: 0.5341954409388067d),
},
            new NpgsqlLinelineE0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4399264856267754d, b: 0.14013666587015727d, c: 0.5408714814353462d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6930946332396773d, b: 0.4531711837911284d, c: 0.7234072072550396d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.635885685049183d, b: 0.22225774488861383d, c: 0.3387824600679563d),
},
            new NpgsqlLinelineE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.09555414658205896d, b: 0.15755753283534724d, c: 0.13789868984652998d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6448759425499272d, b: 0.6813815547123414d, c: 0.463920960426894d),
},
            new NpgsqlLinelineE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.15720263353676034d, b: 0.44417911674573773d, c: 0.21009132217858562d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.07576234835081486d, b: 0.13344316465035977d, c: 0.5545374455109285d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.782697942554306d, b: 0.24870795259792267d, c: 0.5639782499543181d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9847826341684536d, b: 0.6557473463337944d, c: 0.8234533349116074d),
},
            new NpgsqlLinelineE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.694229659742841d, b: 0.8683208147757073d, c: 0.11129644153211704d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7120744985122225d, b: 0.994161490329734d, c: 0.6876916475094059d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6723153465129845d, b: 0.5954999713746427d, c: 0.281545391681001d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24455327611380484d, b: 0.3698409491667519d, c: 0.9117155750366839d),
},
            new NpgsqlLinelineE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1375743062514091d, b: 0.9993323584221339d, c: 0.8440530785848621d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5868795338430929d, b: 0.9037875847548092d, c: 0.9775802137568717d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8839214547983014d, b: 0.17535093442533078d, c: 0.6617192400392222d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.32754632091488545d, b: 0.9966310945821658d, c: 0.013704633235772867d),
},
            new NpgsqlLinelineE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5812840488570655d, b: 0.12943903914173016d, c: 0.8681901484843292d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3004871927256294d, b: 0.5457371833243789d, c: 0.07412460142383093d),
},
            new NpgsqlLinelineE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7110123823063073d, b: 0.5751062021046122d, c: 0.4749248568039002d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.666494244513042d, b: 0.3732682882291507d, c: 0.3331139100124253d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8963900327213238d, b: 0.627320221868566d, c: 0.4090566201719906d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3010189135783867d, b: 0.8457599865143673d, c: 0.8893579272928035d),
},
            new NpgsqlLinelineE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5611414120018826d, b: 0.8358773084165654d, c: 0.05344646885762516d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.994654244018035d, b: 0.8288899009569809d, c: 0.5187807334556259d),
},
            new NpgsqlLinelineE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04301191755061151d, b: 0.6494917775836102d, c: 0.2714532782871668d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6674876413840322d, b: 0.12696517514558936d, c: 0.0803123033501395d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08919744485794479d, b: 0.6992433869884658d, c: 0.7581996673428669d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8835325669304952d, b: 0.2533519655223051d, c: 0.6128946678273257d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9725766682473215d, b: 0.31421716255859d, c: 0.22990575975317773d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20133833516817456d, b: 0.45360195895351085d, c: 0.18503129011709696d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8935876263095649d, b: 0.918684300395107d, c: 0.5373661013609056d),
},
            new NpgsqlLinelineE0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.31722866163621954d, b: 0.24858908789485767d, c: 0.24449421855384113d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6725917911397191d, b: 0.10131448766607076d, c: 0.44397365775763054d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8756176040663384d, b: 0.597631260460708d, c: 0.21577515148425408d),
},
            new NpgsqlLinelineE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6945375041523398d, b: 0.045244198965797455d, c: 0.5297538301789271d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.04941675312903704d, b: 0.3811396048210558d, c: 0.43571453527940684d),
},
            new NpgsqlLinelineE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.739478362472513d, b: 0.7505022698934104d, c: 0.7605616252230037d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23219404965310542d, b: 0.6875999928553869d, c: 0.2561412136889486d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20148326376504555d, b: 0.30118424514811903d, c: 0.918451770783669d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.529967268938144d, b: 0.4777469271740652d, c: 0.33373122822676304d),
},
            new NpgsqlLinelineE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8198972777720995d, b: 0.2946941609326428d, c: 0.851498229547864d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8890503680852327d, b: 0.5313276068894268d, c: 0.7709320430671824d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25817813537076306d, b: 0.7122013239359978d, c: 0.9679594419002225d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.42239118265083064d, b: 0.5733657474240356d, c: 0.7567803986337106d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5873334577960315d, b: 0.8865081212358418d, c: 0.6856615260545654d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13106720133248317d, b: 0.983880064046747d, c: 0.21160410738339508d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1957608776577866d, b: 0.4599476567896271d, c: 0.11932880755432762d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45122508713537934d, b: 0.7159872970732892d, c: 0.4065258932323327d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3089557065135168d, b: 0.7998580926432458d, c: 0.38304985355952836d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.38654256848906265d, b: 0.23087866197715268d, c: 0.7505975154517883d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.47786765339954174d, b: 0.49852197995762815d, c: 0.9301285354208901d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4718383459470529d, b: 0.2568854574934266d, c: 0.7628882162091449d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.06199302489610059d, b: 0.3598478613411312d, c: 0.47820885297449245d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03735518260523152d, b: 0.5925598026876009d, c: 0.6398774182865187d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9792258631598211d, b: 0.27058091057822775d, c: 0.3262281303688326d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4586062325143593d, b: 0.9567787305598693d, c: 0.5146503074993538d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.12965005713809252d, b: 0.8813501769324001d, c: 0.4970633147261797d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4184521147498588d, b: 0.2014222027020912d, c: 0.29182070403487603d),
},
            new NpgsqlLinelineE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9797567913689639d, b: 0.8360951416598789d, c: 0.11310116235625978d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2089758984253799d, b: 0.9453789512445792d, c: 0.006767523102140571d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4748003851286272d, b: 0.47448985436863833d, c: 0.16765283126279085d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.38808515350547834d, b: 0.6666293066297377d, c: 0.029431572379395088d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.17067319365274536d, b: 0.024644320397538166d, c: 0.023825935550983668d),
},
            new NpgsqlLinelineE0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.516273358999501d, b: 0.7318948638392945d, c: 0.46258057225645177d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.05833265541315735d, b: 0.4390112503298307d, c: 0.9881927602494165d),
},
            new NpgsqlLinelineE0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12960242901993646d, b: 0.6437013813165127d, c: 0.9128337317575866d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6715115004074401d, b: 0.6325241100506082d, c: 0.8125995791432549d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.44279770740185886d, b: 0.6584027521314046d, c: 0.8003125756283447d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.917663111893128d, b: 0.49975674914011725d, c: 0.49436885154069965d),
},
            new NpgsqlLinelineE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4004399351481337d, b: 0.23025230905653338d, c: 0.016393723183989795d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5482944736698284d, b: 0.3007290715126796d, c: 0.6485767919497398d),
},
            new NpgsqlLinelineE0M
{
    Id = 185,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6282540564599435d, b: 0.6932769867847224d, c: 0.46221991520598327d),
    ModelInner = new NpgsqlLinelineE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8553453612904598d, b: 0.3344785124311592d, c: 0.8870670965130829d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.21047586275572672d, b: 0.8115690256859738d, c: 0.6666216003711579d),
},
    NullableValue = null,
},
            new NpgsqlLinelineE0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.766970030179988d, b: 0.7025981067686132d, c: 0.3449231624409448d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.42108846338176d, b: 0.44415703961343156d, c: 0.8816970491916275d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0mi(
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
INSERT INTO public.npgsqllinelinee0mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
INSERT INTO public.npgsqllinelinee0mi(
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
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
                methodParametrName: "npgsqllinelinee0mi_id", 
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
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.24455327611380484d, b: 0.3698409491667519d, c: 0.9117155750366839d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.32754632091488545d, b: 0.9966310945821658d, c: 0.013704633235772867d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
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
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                methodParametrName: "npgsqllinelinee0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3004871927256294d, b: 0.5457371833243789d, c: 0.07412460142383093d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.3010189135783867d, b: 0.8457599865143673d, c: 0.8893579272928035d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.994654244018035d, b: 0.8288899009569809d, c: 0.5187807334556259d)));
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
                List<NpgsqlLinelineE0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineE0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinee0m(
	id,
    value,
    nullablevalue,
    npgsqllinelinee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllinelinee0mi_id
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
                parametrName: "npgsqllinelinee0mi_id", 
                methodParametrName: "npgsqllinelinee0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M), typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineE0M>();
                var models2 = new List<FlatNpgsqlLinelineE0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 119, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var firstItems2 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineE0M)],
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 72, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 35, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 113, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
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
FROM public.npgsqllinelinee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems1 = new List<FlatNpgsqlLinelineE0M>();
                var secondItems2 = new List<FlatNpgsqlLinelineE0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[14],_testData[34], false);
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
                    NpgsqlLinelineE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 113, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[19], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[20], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[21], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[22], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[23], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[24], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[25], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[26], false);
                NpgsqlLinelineE0M.AssertModel(models[8],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[9],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[10],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[11],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[12],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[13],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[14],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlLinelineE0M.AssertModel(models[0],_testData[27], false);
                NpgsqlLinelineE0M.AssertModel(models[1],_testData[28], false);
                NpgsqlLinelineE0M.AssertModel(models[2],_testData[29], false);
                NpgsqlLinelineE0M.AssertModel(models[3],_testData[30], false);
                NpgsqlLinelineE0M.AssertModel(models[4],_testData[31], false);
                NpgsqlLinelineE0M.AssertModel(models[5],_testData[32], false);
                NpgsqlLinelineE0M.AssertModel(models[6],_testData[33], false);
                NpgsqlLinelineE0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqllinelinee0m m
LEFT JOIN public.npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3910155987753552d, b: 0.5608343556009571d, c: 0.8670649931073511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7059926651426881d, b: 0.6401020050535996d, c: 0.5341954409388067d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4399264856267754d, b: 0.14013666587015727d, c: 0.5408714814353462d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6930946332396773d, b: 0.4531711837911284d, c: 0.7234072072550396d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.635885685049183d, b: 0.22225774488861383d, c: 0.3387824600679563d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09555414658205896d, b: 0.15755753283534724d, c: 0.13789868984652998d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6448759425499272d, b: 0.6813815547123414d, c: 0.463920960426894d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15720263353676034d, b: 0.44417911674573773d, c: 0.21009132217858562d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07576234835081486d, b: 0.13344316465035977d, c: 0.5545374455109285d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.782697942554306d, b: 0.24870795259792267d, c: 0.5639782499543181d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9847826341684536d, b: 0.6557473463337944d, c: 0.8234533349116074d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.694229659742841d, b: 0.8683208147757073d, c: 0.11129644153211704d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7120744985122225d, b: 0.994161490329734d, c: 0.6876916475094059d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6723153465129845d, b: 0.5954999713746427d, c: 0.281545391681001d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24455327611380484d, b: 0.3698409491667519d, c: 0.9117155750366839d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1375743062514091d, b: 0.9993323584221339d, c: 0.8440530785848621d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5868795338430929d, b: 0.9037875847548092d, c: 0.9775802137568717d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8839214547983014d, b: 0.17535093442533078d, c: 0.6617192400392222d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32754632091488545d, b: 0.9966310945821658d, c: 0.013704633235772867d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5812840488570655d, b: 0.12943903914173016d, c: 0.8681901484843292d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3004871927256294d, b: 0.5457371833243789d, c: 0.07412460142383093d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7110123823063073d, b: 0.5751062021046122d, c: 0.4749248568039002d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.666494244513042d, b: 0.3732682882291507d, c: 0.3331139100124253d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8963900327213238d, b: 0.627320221868566d, c: 0.4090566201719906d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3010189135783867d, b: 0.8457599865143673d, c: 0.8893579272928035d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5611414120018826d, b: 0.8358773084165654d, c: 0.05344646885762516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.994654244018035d, b: 0.8288899009569809d, c: 0.5187807334556259d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04301191755061151d, b: 0.6494917775836102d, c: 0.2714532782871668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6674876413840322d, b: 0.12696517514558936d, c: 0.0803123033501395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08919744485794479d, b: 0.6992433869884658d, c: 0.7581996673428669d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8835325669304952d, b: 0.2533519655223051d, c: 0.6128946678273257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9725766682473215d, b: 0.31421716255859d, c: 0.22990575975317773d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20133833516817456d, b: 0.45360195895351085d, c: 0.18503129011709696d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8935876263095649d, b: 0.918684300395107d, c: 0.5373661013609056d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.31722866163621954d, b: 0.24858908789485767d, c: 0.24449421855384113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6725917911397191d, b: 0.10131448766607076d, c: 0.44397365775763054d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8756176040663384d, b: 0.597631260460708d, c: 0.21577515148425408d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6945375041523398d, b: 0.045244198965797455d, c: 0.5297538301789271d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04941675312903704d, b: 0.3811396048210558d, c: 0.43571453527940684d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.739478362472513d, b: 0.7505022698934104d, c: 0.7605616252230037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23219404965310542d, b: 0.6875999928553869d, c: 0.2561412136889486d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20148326376504555d, b: 0.30118424514811903d, c: 0.918451770783669d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.529967268938144d, b: 0.4777469271740652d, c: 0.33373122822676304d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8198972777720995d, b: 0.2946941609326428d, c: 0.851498229547864d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8890503680852327d, b: 0.5313276068894268d, c: 0.7709320430671824d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25817813537076306d, b: 0.7122013239359978d, c: 0.9679594419002225d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42239118265083064d, b: 0.5733657474240356d, c: 0.7567803986337106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5873334577960315d, b: 0.8865081212358418d, c: 0.6856615260545654d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13106720133248317d, b: 0.983880064046747d, c: 0.21160410738339508d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1957608776577866d, b: 0.4599476567896271d, c: 0.11932880755432762d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45122508713537934d, b: 0.7159872970732892d, c: 0.4065258932323327d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3089557065135168d, b: 0.7998580926432458d, c: 0.38304985355952836d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38654256848906265d, b: 0.23087866197715268d, c: 0.7505975154517883d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47786765339954174d, b: 0.49852197995762815d, c: 0.9301285354208901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4718383459470529d, b: 0.2568854574934266d, c: 0.7628882162091449d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06199302489610059d, b: 0.3598478613411312d, c: 0.47820885297449245d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03735518260523152d, b: 0.5925598026876009d, c: 0.6398774182865187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9792258631598211d, b: 0.27058091057822775d, c: 0.3262281303688326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4586062325143593d, b: 0.9567787305598693d, c: 0.5146503074993538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12965005713809252d, b: 0.8813501769324001d, c: 0.4970633147261797d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4184521147498588d, b: 0.2014222027020912d, c: 0.29182070403487603d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9797567913689639d, b: 0.8360951416598789d, c: 0.11310116235625978d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2089758984253799d, b: 0.9453789512445792d, c: 0.006767523102140571d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4748003851286272d, b: 0.47448985436863833d, c: 0.16765283126279085d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38808515350547834d, b: 0.6666293066297377d, c: 0.029431572379395088d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17067319365274536d, b: 0.024644320397538166d, c: 0.023825935550983668d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.516273358999501d, b: 0.7318948638392945d, c: 0.46258057225645177d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05833265541315735d, b: 0.4390112503298307d, c: 0.9881927602494165d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12960242901993646d, b: 0.6437013813165127d, c: 0.9128337317575866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6715115004074401d, b: 0.6325241100506082d, c: 0.8125995791432549d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44279770740185886d, b: 0.6584027521314046d, c: 0.8003125756283447d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.917663111893128d, b: 0.49975674914011725d, c: 0.49436885154069965d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4004399351481337d, b: 0.23025230905653338d, c: 0.016393723183989795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5482944736698284d, b: 0.3007290715126796d, c: 0.6485767919497398d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6282540564599435d, b: 0.6932769867847224d, c: 0.46221991520598327d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8553453612904598d, b: 0.3344785124311592d, c: 0.8870670965130829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21047586275572672d, b: 0.8115690256859738d, c: 0.6666216003711579d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.766970030179988d, b: 0.7025981067686132d, c: 0.3449231624409448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42108846338176d, b: 0.44415703961343156d, c: 0.8816970491916275d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3910155987753552d, b: 0.5608343556009571d, c: 0.8670649931073511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7059926651426881d, b: 0.6401020050535996d, c: 0.5341954409388067d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4399264856267754d, b: 0.14013666587015727d, c: 0.5408714814353462d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6930946332396773d, b: 0.4531711837911284d, c: 0.7234072072550396d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.635885685049183d, b: 0.22225774488861383d, c: 0.3387824600679563d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09555414658205896d, b: 0.15755753283534724d, c: 0.13789868984652998d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6448759425499272d, b: 0.6813815547123414d, c: 0.463920960426894d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15720263353676034d, b: 0.44417911674573773d, c: 0.21009132217858562d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07576234835081486d, b: 0.13344316465035977d, c: 0.5545374455109285d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.782697942554306d, b: 0.24870795259792267d, c: 0.5639782499543181d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9847826341684536d, b: 0.6557473463337944d, c: 0.8234533349116074d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.694229659742841d, b: 0.8683208147757073d, c: 0.11129644153211704d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7120744985122225d, b: 0.994161490329734d, c: 0.6876916475094059d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6723153465129845d, b: 0.5954999713746427d, c: 0.281545391681001d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24455327611380484d, b: 0.3698409491667519d, c: 0.9117155750366839d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1375743062514091d, b: 0.9993323584221339d, c: 0.8440530785848621d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5868795338430929d, b: 0.9037875847548092d, c: 0.9775802137568717d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8839214547983014d, b: 0.17535093442533078d, c: 0.6617192400392222d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.32754632091488545d, b: 0.9966310945821658d, c: 0.013704633235772867d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5812840488570655d, b: 0.12943903914173016d, c: 0.8681901484843292d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3004871927256294d, b: 0.5457371833243789d, c: 0.07412460142383093d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7110123823063073d, b: 0.5751062021046122d, c: 0.4749248568039002d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.666494244513042d, b: 0.3732682882291507d, c: 0.3331139100124253d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8963900327213238d, b: 0.627320221868566d, c: 0.4090566201719906d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3010189135783867d, b: 0.8457599865143673d, c: 0.8893579272928035d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5611414120018826d, b: 0.8358773084165654d, c: 0.05344646885762516d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.994654244018035d, b: 0.8288899009569809d, c: 0.5187807334556259d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04301191755061151d, b: 0.6494917775836102d, c: 0.2714532782871668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6674876413840322d, b: 0.12696517514558936d, c: 0.0803123033501395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08919744485794479d, b: 0.6992433869884658d, c: 0.7581996673428669d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8835325669304952d, b: 0.2533519655223051d, c: 0.6128946678273257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9725766682473215d, b: 0.31421716255859d, c: 0.22990575975317773d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20133833516817456d, b: 0.45360195895351085d, c: 0.18503129011709696d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8935876263095649d, b: 0.918684300395107d, c: 0.5373661013609056d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.31722866163621954d, b: 0.24858908789485767d, c: 0.24449421855384113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6725917911397191d, b: 0.10131448766607076d, c: 0.44397365775763054d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8756176040663384d, b: 0.597631260460708d, c: 0.21577515148425408d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6945375041523398d, b: 0.045244198965797455d, c: 0.5297538301789271d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04941675312903704d, b: 0.3811396048210558d, c: 0.43571453527940684d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.739478362472513d, b: 0.7505022698934104d, c: 0.7605616252230037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23219404965310542d, b: 0.6875999928553869d, c: 0.2561412136889486d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20148326376504555d, b: 0.30118424514811903d, c: 0.918451770783669d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.529967268938144d, b: 0.4777469271740652d, c: 0.33373122822676304d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8198972777720995d, b: 0.2946941609326428d, c: 0.851498229547864d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8890503680852327d, b: 0.5313276068894268d, c: 0.7709320430671824d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25817813537076306d, b: 0.7122013239359978d, c: 0.9679594419002225d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42239118265083064d, b: 0.5733657474240356d, c: 0.7567803986337106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5873334577960315d, b: 0.8865081212358418d, c: 0.6856615260545654d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13106720133248317d, b: 0.983880064046747d, c: 0.21160410738339508d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1957608776577866d, b: 0.4599476567896271d, c: 0.11932880755432762d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45122508713537934d, b: 0.7159872970732892d, c: 0.4065258932323327d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3089557065135168d, b: 0.7998580926432458d, c: 0.38304985355952836d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38654256848906265d, b: 0.23087866197715268d, c: 0.7505975154517883d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47786765339954174d, b: 0.49852197995762815d, c: 0.9301285354208901d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4718383459470529d, b: 0.2568854574934266d, c: 0.7628882162091449d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.06199302489610059d, b: 0.3598478613411312d, c: 0.47820885297449245d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03735518260523152d, b: 0.5925598026876009d, c: 0.6398774182865187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9792258631598211d, b: 0.27058091057822775d, c: 0.3262281303688326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4586062325143593d, b: 0.9567787305598693d, c: 0.5146503074993538d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12965005713809252d, b: 0.8813501769324001d, c: 0.4970633147261797d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4184521147498588d, b: 0.2014222027020912d, c: 0.29182070403487603d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9797567913689639d, b: 0.8360951416598789d, c: 0.11310116235625978d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2089758984253799d, b: 0.9453789512445792d, c: 0.006767523102140571d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4748003851286272d, b: 0.47448985436863833d, c: 0.16765283126279085d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38808515350547834d, b: 0.6666293066297377d, c: 0.029431572379395088d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17067319365274536d, b: 0.024644320397538166d, c: 0.023825935550983668d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.516273358999501d, b: 0.7318948638392945d, c: 0.46258057225645177d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.05833265541315735d, b: 0.4390112503298307d, c: 0.9881927602494165d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12960242901993646d, b: 0.6437013813165127d, c: 0.9128337317575866d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6715115004074401d, b: 0.6325241100506082d, c: 0.8125995791432549d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44279770740185886d, b: 0.6584027521314046d, c: 0.8003125756283447d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.917663111893128d, b: 0.49975674914011725d, c: 0.49436885154069965d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4004399351481337d, b: 0.23025230905653338d, c: 0.016393723183989795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5482944736698284d, b: 0.3007290715126796d, c: 0.6485767919497398d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6282540564599435d, b: 0.6932769867847224d, c: 0.46221991520598327d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8553453612904598d, b: 0.3344785124311592d, c: 0.8870670965130829d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21047586275572672d, b: 0.8115690256859738d, c: 0.6666216003711579d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.766970030179988d, b: 0.7025981067686132d, c: 0.3449231624409448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42108846338176d, b: 0.44415703961343156d, c: 0.8816970491916275d))));

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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
COPY public.binary_npgsqllinelinee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MI),
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
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
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
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MI>(2);
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
                    NpgsqlLinelineE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineE0MIWA),
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineE0MIWA
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
                    NpgsqlLinelineE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineE0M),
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
FROM public.binary_npgsqllinelinee0m m
LEFT JOIN public.binary_npgsqllinelinee0mi mi ON mi.id = m.npgsqllinelinee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                var importCollection = new List<NpgsqlLinelineE0M>();
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
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineE0M>();
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
                    NpgsqlLinelineE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineE0M)],
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
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlLinelineE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqllinelinee0mi
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI), typeof(NpgsqlLinelineE0MI)],
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MI>();
                var models2 = new List<NpgsqlLinelineE0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MI)],
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
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlLinelineE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA), typeof(NpgsqlLinelineE0MIWA)],
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineE0MIWA>();
                var models2 = new List<NpgsqlLinelineE0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineE0MIWA)],
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlLinelineE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

