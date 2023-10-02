

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                )
            ]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, 1858135340, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, 1939791617, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

}, null);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, 301053925, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, 2139604047, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

});
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, 1747762986, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

});
                Assert.That(id, Is.EqualTo(1747762986));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, 519607739, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

}, null);
                Assert.That(id, Is.EqualTo(519607739));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 382234532, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

});
                Assert.That(id, Is.EqualTo(382234532));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 1890399090, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

}, null);
                Assert.That(id, Is.EqualTo(1890399090));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 773476809, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

});
                Assert.That(id, Is.EqualTo(773476809));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 1917217219, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

});
                Assert.That(id, Is.EqualTo(1917217219));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 712340574, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

});
                Assert.That(id, Is.EqualTo(712340574));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 1784345669, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

}, null);
                Assert.That(id, Is.EqualTo(1784345669));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 718813719, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

});
                Assert.That(id, Is.EqualTo(718813719));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 495562811, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

}, null);
                Assert.That(id, Is.EqualTo(495562811));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, 1291985428, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

}, null);
                Assert.That(id, Is.EqualTo(1291985428));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, 1190953060, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, 83045935, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

}, 1858135340);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, 219852537, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, 535759397, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

}, 1939791617);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;

                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, 1221402448, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

}));

                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, 2065889853, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

}, null, 301053925);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;

                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, 1596184667, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, 1959363099, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

}, 2139604047);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;
                NpgsqlPointpointArray1M model = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, 1630050347, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, 1242381576, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

}, 1747762986).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, 187986717, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, 1755115710, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

}, 519607739).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;
                NpgsqlPointpointArray1M model = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1276744727, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 23792754, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

}, null, 382234532).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1480010978, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1831929267, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

}, null, 1890399090).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1130295598, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 2114153667, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

}, 773476809).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1959324091, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 949301491, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

}, null, 1917217219).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1102983378, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1211222858, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

}, null, 712340574).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1881714840, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 2035211304, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

}, null, 1784345669).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 401203173, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1882173678, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

}, null, 718813719).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 594599349, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1862419805, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

}, null, 495562811).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1516523775, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

}, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, 1403244991, 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

}, 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

}, 1291985428).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 1102983378);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 1755115710);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(9));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatch(connection, 594599349, 1959363099))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }
                    
                    //todo return false
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
                await foreach(var batchResult in ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatchAsync(connection, 1831929267, 949301491))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(7);

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 301053925,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 382234532,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 495562811,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 519607739,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 712340574,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 718813719,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 773476809,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(301053925));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382234532));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495562811));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(519607739));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(712340574));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(718813719));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773476809));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1291985428,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1747762986,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1784345669,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1858135340,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1890399090,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1917217219,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 1939791617,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray1MI
                {
                    Id = 2139604047,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(301053925));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382234532));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495562811));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(519607739));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(712340574));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(718813719));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773476809));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1291985428));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1747762986));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784345669));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858135340));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1890399090));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1917217219));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1939791617));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139604047));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 23792754,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 382234532
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 83045935,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1858135340
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 187986717,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 219852537,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 401203173,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 535759397,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1939791617
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 594599349,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 949301491,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1917217219
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1102983378,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1130295598,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1190953060,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1211222858,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 712340574
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1221402448,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1242381576,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1747762986
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1276744727,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1403244991,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1291985428
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1480010978,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1516523775,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1596184667,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1630050347,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1755115710,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 519607739
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1831929267,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1890399090
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1862419805,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 495562811
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1881714840,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1882173678,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 718813719
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1959324091,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 1959363099,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 2139604047
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 2035211304,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 1784345669
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 2065889853,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 301053925
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray1M
                {
                    Id = 2114153667,
                    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

},

                    ModelInner = new NpgsqlPointpointArray1MI 
                    {
                        Id = 773476809
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(23792754));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(382234532));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83045935));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1858135340));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187986717));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(219852537));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401203173));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(535759397));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939791617));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594599349));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(949301491));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1917217219));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102983378));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1130295598));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190953060));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211222858));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(712340574));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1221402448));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242381576));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1747762986));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276744727));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1403244991));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1291985428));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1480010978));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1516523775));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1596184667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630050347));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1755115710));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519607739));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831929267));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1890399090));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1862419805));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(495562811));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1881714840));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1882173678));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718813719));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959324091));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1959363099));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2139604047));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035211304));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784345669));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2065889853));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301053925));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2114153667));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(773476809));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray1M>(30);

                expected.Add(
                    23792754,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 23792754,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 382234532,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

}
                        }

                    }
                );

                expected.Add(
                    83045935,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 83045935,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1858135340,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    187986717,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 187986717,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    219852537,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 219852537,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    401203173,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 401203173,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    535759397,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 535759397,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1939791617,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    594599349,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 594599349,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    949301491,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 949301491,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1917217219,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

}
                        }

                    }
                );

                expected.Add(
                    1102983378,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1102983378,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1130295598,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1130295598,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1190953060,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1190953060,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1211222858,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1211222858,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 712340574,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

}
                        }

                    }
                );

                expected.Add(
                    1221402448,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1221402448,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1242381576,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1242381576,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1747762986,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

}
                        }

                    }
                );

                expected.Add(
                    1276744727,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1276744727,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1403244991,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1403244991,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1291985428,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1480010978,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1480010978,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1516523775,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1516523775,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1596184667,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1596184667,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1630050347,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1630050347,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1755115710,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1755115710,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 519607739,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1831929267,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1831929267,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1890399090,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1862419805,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1862419805,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 495562811,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1881714840,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1881714840,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1882173678,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1882173678,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 718813719,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

}
                        }

                    }
                );

                expected.Add(
                    1959324091,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1959324091,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1959363099,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1959363099,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 2139604047,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

}
                        }

                    }
                );

                expected.Add(
                    2035211304,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2035211304,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1784345669,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2065889853,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2065889853,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 301053925,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2114153667,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2114153667,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 773476809,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

}
                        }

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray1M>(30);

                expected.Add(
                    23792754,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 23792754,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5562927571280859d, y: 0.07862453441311668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7638069128211047d, y: 0.24600602193708687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6830352672855682d, y: 0.8987283831562355d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 382234532,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

}
                        }

                    }
                );

                expected.Add(
                    83045935,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 83045935,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113928044865339d, y: 0.35076948879098413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7733106703008112d, y: 0.3567089315675631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0071206967429485735d, y: 0.7746131330729771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9666680920582631d, y: 0.020291767322908827d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.161541403867552d, y: 0.7768099968118186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751590139504352d, y: 0.3359026741879034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.172938218851864d, y: 0.09488060047193736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5579105379367194d, y: 0.7924185753033125d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1858135340,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    187986717,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 187986717,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6301958528632357d, y: 0.024158156078824877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5510324896834554d, y: 0.1291486815680828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05245167707398002d, y: 0.04581947379063933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08593683077274439d, y: 0.31116238315295386d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    219852537,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 219852537,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803390781467205d, y: 0.774995604738474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46369561193939346d, y: 0.6358455048937994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6724827914626401d, y: 0.3121880295437398d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2016062083144814d, y: 0.32738881719854396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04039726116145881d, y: 0.016016861346053735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624834144907171d, y: 0.06468854322917494d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    401203173,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 401203173,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561142946343136d, y: 0.24284290497607397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.818441737721973d, y: 0.6437930031456187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993854679134037d, y: 0.6884619828567389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04710857352264597d, y: 0.9162438783220559d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    535759397,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 535759397,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3133057813574799d, y: 0.615723039012171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09428286365465233d, y: 0.8226077135634515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950604931344773d, y: 0.35176877045950883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8559368195626974d, y: 0.7970296920239138d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17681478561028563d, y: 0.8329888009895496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1810243794672105d, y: 0.7231698431318949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39482889356528883d, y: 0.06889534384321694d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1939791617,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    594599349,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 594599349,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12755145335025453d, y: 0.6742828098514982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2032847379527507d, y: 0.5365138547972216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8370007997253941d, y: 0.8530582349857713d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6484937644522649d, y: 0.7838048266312541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043471100817530584d, y: 0.5058437057290018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5626559420521242d, y: 0.9153717408059451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7350100358952811d, y: 0.7637057428004144d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    949301491,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 949301491,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46479982736744485d, y: 0.7128580804526541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21458043406825633d, y: 0.5365352403891471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44895344826617745d, y: 0.8592385098841064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850309302135799d, y: 0.6805904230897197d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1917217219,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

}
                        }

                    }
                );

                expected.Add(
                    1102983378,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1102983378,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1503684839219921d, y: 0.7174040637269778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677910547061898d, y: 0.5315383102459538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8163104300940538d, y: 0.8935479727061957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035301134130153d, y: 0.9644189898728103d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8268853600133892d, y: 0.8629575894545569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379660873969896d, y: 0.7850753631252742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05520033257298684d, y: 0.0945916966454946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852134818529654d, y: 0.12140465903815956d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1130295598,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1130295598,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8573092681422292d, y: 0.8119300495010427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25973996929735765d, y: 0.2776883324051348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9760290092300558d, y: 0.8052203813473305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6823792002004562d, y: 0.39150667517666904d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1190953060,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1190953060,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4917783637934722d, y: 0.5486514838061225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24727808620964475d, y: 0.5717587081342078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22587840209109833d, y: 0.2491536323450737d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1211222858,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1211222858,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5644357585900189d, y: 0.6916234914727698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407695213918316d, y: 0.5761310626751065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6961639776018453d, y: 0.3672327968857757d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 712340574,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

}
                        }

                    }
                );

                expected.Add(
                    1221402448,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1221402448,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.280708942856535d, y: 0.5755345899326784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6772747467822808d, y: 0.9058029437719828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831262084559295d, y: 0.9732185439382891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19956883720935836d, y: 0.5374040358969746d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9346072474277531d, y: 0.7595558070234127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.331406358227584d, y: 0.44021069271740165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021975715582837507d, y: 0.8887814108179292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02760428930225045d, y: 0.05071089908330073d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1242381576,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1242381576,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840275266812877d, y: 0.6407813736887352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183705479828152d, y: 0.6312904294748348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2584714294175504d, y: 0.023407344840399857d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6489696460949187d, y: 0.608621963873251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267059881712416d, y: 0.5127716108527249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2150602429989712d, y: 0.7146918535310409d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1747762986,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

}
                        }

                    }
                );

                expected.Add(
                    1276744727,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1276744727,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876930590199522d, y: 0.3430839661333417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2403358660491992d, y: 0.014612283297328332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12181946325225346d, y: 0.16613762998866244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17891470849240987d, y: 0.4747033618347055d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1403244991,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1403244991,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24926425465859914d, y: 0.2485912194371902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008533331366294195d, y: 0.7214055085001972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.165637235502598d, y: 0.6520723796056311d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9064180295505573d, y: 0.9500895146036001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.026655628013089183d, y: 0.0049751285660223354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3083378153238234d, y: 0.4188211958459698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48637290444451475d, y: 0.317185063761528d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1291985428,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1480010978,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1480010978,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.027262436877779073d, y: 0.7520064569974634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2685985089327626d, y: 0.7914712315331491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6530399945042621d, y: 0.8784076337623379d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1516523775,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1516523775,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3684767310592586d, y: 0.3969893961726575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36074420121276907d, y: 0.788161994387007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8908934737093641d, y: 0.7288385567808952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40511984335493d, y: 0.9968590395356697d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840867867472741d, y: 0.9777211010059199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946858129364552d, y: 0.42804976070725886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8964120883521633d, y: 0.015000011701131633d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1596184667,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1596184667,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1198381897842078d, y: 0.32725499060121177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9417003343009996d, y: 0.4298468190113681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2945917902522911d, y: 0.7157065205222244d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1630050347,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1630050347,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7828791200586436d, y: 0.639680711265751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1047182065175003d, y: 0.16441688533758847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666156532431534d, y: 0.05263796883307348d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3881629521276747d, y: 0.9352287483191574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0453052905798752d, y: 0.8178802186061348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08479266058074098d, y: 0.5431057088458184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566782677428029d, y: 0.06446911752252849d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1755115710,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1755115710,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009137302827408322d, y: 0.440411312353602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10019833464891603d, y: 0.8457321168073695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2931781297099909d, y: 0.5678848628453144d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027218339667213d, y: 0.17083870403610057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4842568045094562d, y: 0.7391022231992891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03575626685748079d, y: 0.6158452004150935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8820260398849833d, y: 0.9945914030847581d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 519607739,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1831929267,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1831929267,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6463215970309545d, y: 0.7599801940966854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7370261521392992d, y: 0.9104015428199767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11976564572007731d, y: 0.09885240259520256d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1890399090,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1862419805,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1862419805,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.900103211589127d, y: 0.7046804683005903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3350563145762102d, y: 0.7837346007711371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9994455373482537d, y: 0.3983336338592768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9246405773975207d, y: 0.17288955287735674d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 495562811,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1881714840,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1881714840,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20100648344635574d, y: 0.7794682475420297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7198726205767496d, y: 0.5341120865300589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3454793978293451d, y: 0.05891669442986969d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6986859291097892d, y: 0.2564130395543802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5808273943871638d, y: 0.9594896193514199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49770310051465727d, y: 0.47187644086597147d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1882173678,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1882173678,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4947095993569809d, y: 0.7538894363012982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3230435016803489d, y: 0.7919395744156218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4586034619742917d, y: 0.6941493549294062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4247781646763974d, y: 0.5896194564877426d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 718813719,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

}
                        }

                    }
                );

                expected.Add(
                    1959324091,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1959324091,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141180249340453d, y: 0.44786647650464506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8656093602360461d, y: 0.44001106393573697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30721815722470536d, y: 0.816661677802968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458739366011509d, y: 0.9332596785491948d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9692622226318226d, y: 0.6401526384984445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9854351986609362d, y: 0.309588267049121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8676072179633955d, y: 0.23547732224692242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487243976877279d, y: 0.8098464544327025d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1959363099,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 1959363099,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6216973493909014d, y: 0.2505343330660734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567542558154323d, y: 0.6909837510886686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3963566844039512d, y: 0.18231050138780402d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12923738344299962d, y: 0.2476120196608408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29073661375646787d, y: 0.988410671734612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11097402664429545d, y: 0.7058093020026243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13772454409869073d, y: 0.6528922749676597d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 2139604047,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

}
                        }

                    }
                );

                expected.Add(
                    2035211304,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2035211304,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188171378187817d, y: 0.6281101324991212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389085848303361d, y: 0.5874431112233083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870824939378122d, y: 0.9665200546865258d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 1784345669,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2065889853,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2065889853,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030731477112886374d, y: 0.05353388478347765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603421207754669d, y: 0.8574813598142872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0898331453875667d, y: 0.8778814799266623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2698693543287636d, y: 0.9414957403133201d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 301053925,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2114153667,
                    new NpgsqlPointpointArray1M
                    {
                        Id = 2114153667,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6473940186269928d, y: 0.49100761102681445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2569675761531631d, y: 0.30164659430031227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07555574247861674d, y: 0.2558418849119706d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39130281782254306d, y: 0.5108112803307124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10290036099996058d, y: 0.7036867536361263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22653572970038338d, y: 0.036340956972525706d),

},

                        ModelInner = new NpgsqlPointpointArray1MI
                        {
                            Id = 773476809,
                            Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

}
                        }

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlPoint[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray1MI>(15);

                expected.Add(
                    301053925,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 301053925,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    382234532,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 382234532,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

}
                    }
                );

                expected.Add(
                    495562811,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 495562811,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    519607739,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 519607739,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    712340574,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 712340574,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

}
                    }
                );

                expected.Add(
                    718813719,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 718813719,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

}
                    }
                );

                expected.Add(
                    773476809,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 773476809,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

}
                    }
                );

                expected.Add(
                    1291985428,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1291985428,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1747762986,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1747762986,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

}
                    }
                );

                expected.Add(
                    1784345669,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1784345669,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1858135340,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1858135340,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1890399090,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1890399090,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1917217219,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1917217219,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

}
                    }
                );

                expected.Add(
                    1939791617,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1939791617,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2139604047,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 2139604047,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

}
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray1MI>(15);

                expected.Add(
                    301053925,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 301053925,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14784962163375903d, y: 0.8596565809292304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5868894291449532d, y: 0.22109149584560728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570628920180694d, y: 0.3622017923534312d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    382234532,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 382234532,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37542155380805176d, y: 0.29501615598912345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19334779021552773d, y: 0.6507420966073283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652808236229793d, y: 0.9422540734675386d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3529308009975505d, y: 0.3290818238860528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32094785656601754d, y: 0.09233116523266438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9797585872773623d, y: 0.5586619681733054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962689777757876d, y: 0.5460618175388795d),

}
                    }
                );

                expected.Add(
                    495562811,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 495562811,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6654250382765838d, y: 0.7050258396701286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1005041373854737d, y: 0.33354382960963946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0232615923672842d, y: 0.9316900784568088d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    519607739,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 519607739,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5465657644120503d, y: 0.06648015492326509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07950230199740138d, y: 0.48032195322556104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3991377262529655d, y: 0.8477412886082921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5503000057976988d, y: 0.018987242598087817d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    712340574,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 712340574,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17446570044076626d, y: 0.41348101603500453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03403298720238457d, y: 0.6076236826959976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633450695168322d, y: 0.6864544913279882d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.252570439331975d, y: 0.940907338766205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08723016250820004d, y: 0.6996845687726044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20480424812839004d, y: 0.04443015743811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7778036151274389d, y: 0.2592735064221654d),

}
                    }
                );

                expected.Add(
                    718813719,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 718813719,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2229538913748762d, y: 0.8846268506937444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823709392417303d, y: 0.4913415146889395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89504939763488d, y: 0.30143799881708744d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2973788629933345d, y: 0.5930161594014279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8933331665382261d, y: 0.48361454531796333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9218774482304666d, y: 0.9161688487246082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17051305627776658d, y: 0.4273856843802428d),

}
                    }
                );

                expected.Add(
                    773476809,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 773476809,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.967138762060288d, y: 0.8233574457284403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18846055795873284d, y: 0.08427567697532012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5454058775724588d, y: 0.7033656064169501d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008152094566451051d, y: 0.9570182273530852d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3293745911756756d, y: 0.5556627717018677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1222131705591083d, y: 0.8219483612293764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8270523151699705d, y: 0.5350889525884257d),

}
                    }
                );

                expected.Add(
                    1291985428,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1291985428,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5360374051617106d, y: 0.11885855793303313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5788421231371602d, y: 0.9527725363837128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052676934161626665d, y: 0.5095397374577713d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1747762986,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1747762986,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09350038097297952d, y: 0.005588015862955209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4518076238581613d, y: 0.3849106298187952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2505823936305669d, y: 0.408768951448257d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01980041316751513d, y: 0.6474972857737028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6548980053048237d, y: 0.41584216100695104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1986132138122254d, y: 0.00585127095732485d),

}
                    }
                );

                expected.Add(
                    1784345669,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1784345669,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5794371955368288d, y: 0.07109077980515344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12900596443844015d, y: 0.8857045058811791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2118898855330541d, y: 0.013317981097367593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17168664273658585d, y: 0.03190345466033995d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1858135340,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1858135340,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18357855616905028d, y: 0.3849817163606072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306787155375975d, y: 0.47975407389103086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6494192257398248d, y: 0.5756275236266811d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1890399090,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1890399090,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36607788453952184d, y: 0.5185704962924461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422308922581664d, y: 0.8529950318920995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27171213719455634d, y: 0.8186722730864184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336024650047527d, y: 0.8787684397835768d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1917217219,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1917217219,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43135185750179506d, y: 0.9115886050055289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4743614022763317d, y: 0.3564946966806243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15609500021241574d, y: 0.2948093758853888d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5380257539368182d, y: 0.6989071538176613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9810838664685954d, y: 0.3961448520599048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5319995599944838d, y: 0.013443285097159974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7258009663214737d, y: 0.9741080605304316d),

}
                    }
                );

                expected.Add(
                    1939791617,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 1939791617,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8387147517252255d, y: 0.32736292253887056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515505599696292d, y: 0.5748037804564875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6921840060781032d, y: 0.09379415413273384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9906174006955188d, y: 0.45709555442435734d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2139604047,
                    new NpgsqlPointpointArray1MI
                    {
                        Id = 2139604047,
                        Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0443316354445249d, y: 0.9417220672067014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3517316890662229d, y: 0.6638348575887275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229446735092101d, y: 0.7259380537687742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038650731030212104d, y: 0.18912586682280785d),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432596706814401d, y: 0.3686647345968782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31529133118292507d, y: 0.5583132723772491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3037501896173729d, y: 0.3531638546316196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46095813532946006d, y: 0.7945498729341482d),

}
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

