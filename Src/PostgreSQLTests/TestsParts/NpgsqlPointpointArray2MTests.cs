

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapType: typeof(NpgsqlPointpointArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, 980446128, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, 259478330, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, 881123700, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, 632921285, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

}, null);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, 655729367, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

}, null);
                Assert.That(id, Is.EqualTo(655729367));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, 2026249571, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

});
                Assert.That(id, Is.EqualTo(2026249571));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 987106427, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

}, null);
                Assert.That(id, Is.EqualTo(987106427));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 233600875, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

});
                Assert.That(id, Is.EqualTo(233600875));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 1294332601, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

});
                Assert.That(id, Is.EqualTo(1294332601));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 1471583320, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

}, null);
                Assert.That(id, Is.EqualTo(1471583320));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 1805636242, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

});
                Assert.That(id, Is.EqualTo(1805636242));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 759164978, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

});
                Assert.That(id, Is.EqualTo(759164978));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 36799681, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

});
                Assert.That(id, Is.EqualTo(36799681));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 1770529295, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

});
                Assert.That(id, Is.EqualTo(1770529295));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, 1098439641, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

});
                Assert.That(id, Is.EqualTo(1098439641));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, 1451335460, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, 1155518955, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

}, 980446128);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, 1400663960, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, 1206478364, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

}, null, 259478330);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;
                NpgsqlPointpointArray2M model = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, 1400065734, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, 745338843, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

}, null, 881123700).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, 1735702673, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, 919739104, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

}, 632921285).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;
                NpgsqlPointpointArray2M model = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1905845621, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 430533599, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

}, 655729367).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1107833709, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1052831174, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

}, null, 2026249571).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 992098312, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1485763064, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

}, null, 987106427).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1892972460, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 199831145, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

}, 233600875).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1712896231, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 587546229, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

}, 1294332601).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 192276591, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 2115704647, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

}, 1471583320).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1362562604, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1680247433, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

}, 1805636242).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1831990807, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1745172708, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

}, null, 759164978).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1386539309, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 718088324, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

}, 36799681).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1060118430, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1472569213, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

}, 1770529295).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 2016160895, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, 1384624991, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

}, null, 1098439641).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)
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
                var models =  ((INpgsqlPointListpointArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)
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
                var models =  ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 1060118430);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(20));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

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
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

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
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 718088324);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

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
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

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
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)
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
                 foreach(var batchResult in ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 1905845621, 1107833709))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

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
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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
                await foreach(var batchResult in ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 1206478364, 1060118430))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(17));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

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
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

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
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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

                var importCollection = new List<NpgsqlPointpointArray2MI>(7);

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 36799681,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 233600875,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 259478330,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 632921285,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 655729367,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 759164978,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 881123700,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36799681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233600875));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

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
                Assert.That(model.Id, Is.EqualTo(259478330));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(632921285));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(655729367));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(759164978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(881123700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 980446128,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 987106427,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 1098439641,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 1294332601,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 1471583320,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 1770529295,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 1805636242,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

}
                });

                importCollection.Add(
                new NpgsqlPointpointArray2MI
                {
                    Id = 2026249571,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(36799681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233600875));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

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
                Assert.That(model.Id, Is.EqualTo(259478330));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(632921285));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(655729367));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(759164978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(881123700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980446128));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(987106427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098439641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294332601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1471583320));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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
                Assert.That(model.Id, Is.EqualTo(1770529295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1805636242));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026249571));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

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
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 192276591,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 199831145,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 233600875
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 430533599,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 655729367
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 587546229,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 1294332601
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 718088324,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 36799681
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 745338843,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 881123700
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 919739104,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 632921285
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 992098312,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1052831174,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 2026249571
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1060118430,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1107833709,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1155518955,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 980446128
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1206478364,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 259478330
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1362562604,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1384624991,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 1098439641
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1386539309,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1400065734,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1400663960,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1451335460,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1472569213,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 1770529295
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1485763064,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 987106427
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1680247433,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 1805636242
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1712896231,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1735702673,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1745172708,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 759164978
                    }

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1831990807,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1892972460,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 1905845621,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 2016160895,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlPointpointArray2M
                {
                    Id = 2115704647,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

},

                    ModelInner = new NpgsqlPointpointArray2MI 
                    {
                        Id = 1471583320
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(192276591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

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
                Assert.That(model.Id, Is.EqualTo(199831145));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(233600875));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(430533599));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(655729367));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

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


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(587546229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1294332601));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

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
                Assert.That(model.Id, Is.EqualTo(718088324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(36799681));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

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
                Assert.That(model.Id, Is.EqualTo(745338843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(881123700));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

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
                Assert.That(model.Id, Is.EqualTo(919739104));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(632921285));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

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
                Assert.That(model.Id, Is.EqualTo(992098312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

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
                Assert.That(model.Id, Is.EqualTo(1052831174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2026249571));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1060118430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

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
                Assert.That(model.Id, Is.EqualTo(1107833709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

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
                Assert.That(model.Id, Is.EqualTo(1155518955));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(980446128));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

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
                Assert.That(model.Id, Is.EqualTo(1206478364));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(259478330));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

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
                Assert.That(model.Id, Is.EqualTo(1362562604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

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


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384624991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1098439641));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386539309));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

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
                Assert.That(model.Id, Is.EqualTo(1400065734));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

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
                Assert.That(model.Id, Is.EqualTo(1400663960));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

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
                Assert.That(model.Id, Is.EqualTo(1451335460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

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
                Assert.That(model.Id, Is.EqualTo(1472569213));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1770529295));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

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
                Assert.That(model.Id, Is.EqualTo(1485763064));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(987106427));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

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
                Assert.That(model.Id, Is.EqualTo(1680247433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1805636242));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1712896231));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

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


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735702673));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

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


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1745172708));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(759164978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

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
                Assert.That(model.Id, Is.EqualTo(1831990807));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

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
                Assert.That(model.Id, Is.EqualTo(1892972460));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

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


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905845621));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2016160895));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2115704647));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471583320));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray2M>(30);

                expected.Add(
                    192276591,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 192276591,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    199831145,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 199831145,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 233600875,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

}
                        }

                    }
                );

                expected.Add(
                    430533599,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 430533599,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 655729367,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    587546229,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 587546229,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1294332601,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

}
                        }

                    }
                );

                expected.Add(
                    718088324,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 718088324,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 36799681,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

}
                        }

                    }
                );

                expected.Add(
                    745338843,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 745338843,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 881123700,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    919739104,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 919739104,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 632921285,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    992098312,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 992098312,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1052831174,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1052831174,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 2026249571,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

}
                        }

                    }
                );

                expected.Add(
                    1060118430,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1060118430,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1107833709,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1107833709,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1155518955,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1155518955,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 980446128,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1206478364,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1206478364,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 259478330,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1362562604,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1362562604,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1384624991,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1384624991,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1098439641,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

}
                        }

                    }
                );

                expected.Add(
                    1386539309,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1386539309,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1400065734,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1400065734,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1400663960,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1400663960,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1451335460,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1451335460,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1472569213,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1472569213,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1770529295,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

}
                        }

                    }
                );

                expected.Add(
                    1485763064,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1485763064,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 987106427,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1680247433,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1680247433,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1805636242,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

}
                        }

                    }
                );

                expected.Add(
                    1712896231,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1712896231,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735702673,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1735702673,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1745172708,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1745172708,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 759164978,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

}
                        }

                    }
                );

                expected.Add(
                    1831990807,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1831990807,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1892972460,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1892972460,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1905845621,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1905845621,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2016160895,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 2016160895,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2115704647,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 2115704647,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1471583320,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray2M>(30);

                expected.Add(
                    192276591,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 192276591,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4453237950328127d, y: 0.8740203380375651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.266687204863125d, y: 0.30243337269270243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1486408852624178d, y: 0.40604706075144614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357398755250725d, y: 0.7398036020947113d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    199831145,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 199831145,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6706603234499354d, y: 0.5126183432124414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647444279888321d, y: 0.8601905195302648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667309786939996d, y: 0.6687340120181011d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46004391535078615d, y: 0.4785440591183969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505230954086983d, y: 0.5816706700372535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05045137242537556d, y: 0.882115448505422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1820497850014844d, y: 0.8022669544406212d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 233600875,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

}
                        }

                    }
                );

                expected.Add(
                    430533599,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 430533599,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7686761142132187d, y: 0.8944931373545408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7539782382052217d, y: 0.95374309619105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028670818507699924d, y: 0.39686472310824483d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565570421154513d, y: 0.887914670066236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8688827885791822d, y: 0.4554391242447081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981736631972968d, y: 0.2217932958014559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45930524783403304d, y: 0.6421948342303729d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 655729367,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    587546229,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 587546229,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8157991003040558d, y: 0.2166485555215566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6592397839300159d, y: 0.2194001062326717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5924327057849366d, y: 0.7561728497785747d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8337450268228362d, y: 0.3278024256511498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7318484662150285d, y: 0.7917779622963333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040886085385704d, y: 0.17893701505811055d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1294332601,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

}
                        }

                    }
                );

                expected.Add(
                    718088324,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 718088324,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9961222631806927d, y: 0.10775021129541307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9402013895338955d, y: 0.08104410041472343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6149481443612318d, y: 0.23049259250412513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029422051747004296d, y: 0.8768606674620698d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10502393581093916d, y: 0.2903467694584356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8380520348937577d, y: 0.3026909200485871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.70209251996815d, y: 0.9539577461091271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1546311371859519d, y: 0.9187889861875114d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 36799681,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

}
                        }

                    }
                );

                expected.Add(
                    745338843,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 745338843,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5579701002334839d, y: 0.4567748473581098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.063490100549911d, y: 0.5069533282983729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14586423193620257d, y: 0.2861840290425508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23772579675165095d, y: 0.13541757971558022d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 881123700,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    919739104,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 919739104,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8459947201885185d, y: 0.5629822952704767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2053708338174507d, y: 0.43754887078357774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505421040358225d, y: 0.10217800260074184d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9773114121770053d, y: 0.777757113403348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06215992094699063d, y: 0.6426004379675042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05550699285705918d, y: 0.03193116993901679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8968076222411858d, y: 0.6991508041539508d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 632921285,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    992098312,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 992098312,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38733396892959726d, y: 0.44034810288909587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820124617499624d, y: 0.05668576404721104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452036695599987d, y: 0.43684688659450266d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1052831174,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1052831174,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19863394296231585d, y: 0.21385063494654122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07522937322923706d, y: 0.8867105662318285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4705705901647762d, y: 0.20532070356726895d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 2026249571,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

}
                        }

                    }
                );

                expected.Add(
                    1060118430,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1060118430,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9122844313840273d, y: 0.048441684433168875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16164400960598735d, y: 0.347795531232985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5755070006032431d, y: 0.2902965218115804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7719537143047301d, y: 0.75029162018811d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2026467167792606d, y: 0.5726632732899324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22017688355070386d, y: 0.14103665939044108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174699396770434d, y: 0.7477571171088634d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1107833709,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1107833709,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03199296565213339d, y: 0.4606196440892961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2821431176184779d, y: 0.7285674539486809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154547329637398d, y: 0.638021009012638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012836632906784384d, y: 0.257677626594246d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1155518955,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1155518955,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6952687877406559d, y: 0.5223710568769088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310037081324644d, y: 0.15546549075903415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23841803752551438d, y: 0.2105475599010327d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774032927341196d, y: 0.6677458192238143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2963894916983376d, y: 0.3852511114119692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33198294472304857d, y: 0.9823697973060671d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 980446128,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1206478364,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1206478364,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24933790465211803d, y: 0.6316971276315801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24633363631979976d, y: 0.2679505317113233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567527400290265d, y: 0.9816549859414986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4233531766248454d, y: 0.2473156089766667d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 259478330,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1362562604,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1362562604,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24778091179798112d, y: 0.2898760438831848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03873707809878191d, y: 0.07257975103565162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06449148647252512d, y: 0.45083669167133034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4237980058947747d, y: 0.7931830235042197d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1384624991,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1384624991,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2567763646912624d, y: 0.9814197434823236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1785487509548649d, y: 0.3743074786211167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33537654905264636d, y: 0.7693688450679129d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1098439641,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

}
                        }

                    }
                );

                expected.Add(
                    1386539309,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1386539309,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992880220327872d, y: 0.7034842662495668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14497499667307712d, y: 0.07010158721654125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4193734458483359d, y: 0.10254014474578343d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01092778533919625d, y: 0.4532869276120284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8710062796668483d, y: 0.8400351319942665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14986090929509732d, y: 0.23789992176188723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4761737911060906d, y: 0.32457472005218113d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1400065734,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1400065734,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8533530205416167d, y: 0.4526583674121303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225055900441254d, y: 0.5272833167114626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5496365331093598d, y: 0.39204346989918326d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1400663960,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1400663960,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13993059276992414d, y: 0.8246190492609685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06637462784796577d, y: 0.23777323102477832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6524536135623452d, y: 0.3531285216391088d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08364965701725158d, y: 0.3534680354297064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6822939426230346d, y: 0.29960490351854097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731653472398668d, y: 0.6649658171733128d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1451335460,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1451335460,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05682142129449197d, y: 0.33636838927694523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031910472038859d, y: 0.3208432622434201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07958043036898554d, y: 0.2942454091026415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506327385277157d, y: 0.25647759362997014d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.868605492374641d, y: 0.8996709511252481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6195038085530062d, y: 0.9659093401256577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3158079915950692d, y: 0.9749858690433909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473390951688358d, y: 0.8304124645107962d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1472569213,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1472569213,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21025936371197096d, y: 0.09364859107312484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12738257603354508d, y: 0.4074075097555312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6466313454692355d, y: 0.9225359238012795d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4656197133427201d, y: 0.5534008088097377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11777435951153259d, y: 0.17498355662269693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7221355248143141d, y: 0.09058470485047632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4310478249990606d, y: 0.6704870715827838d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1770529295,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

}
                        }

                    }
                );

                expected.Add(
                    1485763064,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1485763064,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356066939598904d, y: 0.1563327333424025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.997618224793451d, y: 0.06557263686305859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3572924710177081d, y: 0.289093054829035d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 987106427,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1680247433,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1680247433,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0907851992653611d, y: 0.6663011370687437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.824154560092669d, y: 0.7465308755040794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10119251229927717d, y: 0.02747737552831675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5896057208035148d, y: 0.9403889484217586d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6947812046483292d, y: 0.3116331922499712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32869220048474246d, y: 0.6537204007373414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1003748444218221d, y: 0.5681337541451561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26302623176674855d, y: 0.5874296947446871d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1805636242,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

}
                        }

                    }
                );

                expected.Add(
                    1712896231,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1712896231,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04200550038151374d, y: 0.012863493581339314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15965180808496637d, y: 0.9097385307203456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15912628129924966d, y: 0.38975858971113553d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3171928001583192d, y: 0.22438661905736434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09499606825212181d, y: 0.41844845493209215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13075789856153874d, y: 0.9612684133683279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1731867134806816d, y: 0.12149507747244825d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1735702673,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1735702673,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15533447688960422d, y: 0.9987443365507161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9159769543496623d, y: 0.6811748004769171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4410343071925057d, y: 0.5473806324648048d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1745172708,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1745172708,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3678760072339544d, y: 0.48444420934861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340779956518816d, y: 0.41252051881997875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3278221026215761d, y: 0.5973788768689084d),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 759164978,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

}
                        }

                    }
                );

                expected.Add(
                    1831990807,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1831990807,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7659505865622767d, y: 0.7970051857309755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.333343549583199d, y: 0.5952861156320168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4350942938416812d, y: 0.21983919683122177d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7571254505718986d, y: 0.8315042964431115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058820360366614d, y: 0.33123474433184785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732625341733513d, y: 0.8645132441723342d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1892972460,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1892972460,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09379622522633935d, y: 0.5353453788447881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647259312328575d, y: 0.5482467301168884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5470470312557296d, y: 0.821387449011844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179203753484309d, y: 0.9942473881580743d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7668622121385641d, y: 0.012145462400692586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6808591276403446d, y: 0.3397598291894497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49010384996061385d, y: 0.16994458652291888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8869592492416173d, y: 0.08300999386468921d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1905845621,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 1905845621,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46599082567330075d, y: 0.254575350493754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8406475309506024d, y: 0.5430134196684386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124944842506523d, y: 0.7226835987667096d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41661266161258137d, y: 0.9531331779095088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27973811279508576d, y: 0.6500868438767835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6940081944304934d, y: 0.53965101932404d),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2016160895,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 2016160895,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917543259649467d, y: 0.5102765888863531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2954738586013974d, y: 0.6025021875795817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00835551406992907d, y: 0.5403800540678103d),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2115704647,
                    new NpgsqlPointpointArray2M
                    {
                        Id = 2115704647,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7409408332742442d, y: 0.6835004103170225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10339469132401014d, y: 0.8668844379776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04043980164456229d, y: 0.4690232689475572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7761780031364132d, y: 0.36727198025597363d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3793831964573372d, y: 0.6189910613179662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3901429727498791d, y: 0.36271477904940785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612037897637202d, y: 0.392228927008511d),

},

                        ModelInner = new NpgsqlPointpointArray2MI
                        {
                            Id = 1471583320,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray2MI>(15);

                expected.Add(
                    36799681,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 36799681,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

}
                    }
                );

                expected.Add(
                    233600875,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 233600875,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

}
                    }
                );

                expected.Add(
                    259478330,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 259478330,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    632921285,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 632921285,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    655729367,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 655729367,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    759164978,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 759164978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

}
                    }
                );

                expected.Add(
                    881123700,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 881123700,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    980446128,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 980446128,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    987106427,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 987106427,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1098439641,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1098439641,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

}
                    }
                );

                expected.Add(
                    1294332601,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1294332601,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

}
                    }
                );

                expected.Add(
                    1471583320,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1471583320,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1770529295,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1770529295,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

}
                    }
                );

                expected.Add(
                    1805636242,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1805636242,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

}
                    }
                );

                expected.Add(
                    2026249571,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 2026249571,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

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

                var expected = new Dictionary<System.Int32,NpgsqlPointpointArray2MI>(15);

                expected.Add(
                    36799681,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 36799681,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5312723115023675d, y: 0.48431962705314724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780894854510044d, y: 0.611959267713968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.651285198924387d, y: 0.6227345967460617d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544156654170274d, y: 0.8642414562723273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1099850638441191d, y: 0.6801080944579359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5685875654289988d, y: 0.06537406351720854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2955252426753867d, y: 0.8809219289043816d),

}
                    }
                );

                expected.Add(
                    233600875,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 233600875,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3274764270818371d, y: 0.08705322576524765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6814137663788956d, y: 0.04473437211892184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45899882003848014d, y: 0.07996961342712805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061039248683929d, y: 0.493242050862594d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29370117630982495d, y: 0.7897123741201744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3731843290133403d, y: 0.27968223574567763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10590975496904909d, y: 0.3202338902298463d),

}
                    }
                );

                expected.Add(
                    259478330,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 259478330,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16676147655812013d, y: 0.12731271353975726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08708699791986396d, y: 0.9839648785128884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6242188673443375d, y: 0.18648183004536845d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    632921285,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 632921285,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42465212471840064d, y: 0.48666276359807736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9964414484928144d, y: 0.171652606672566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904152682661128d, y: 0.4901945862720881d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    655729367,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 655729367,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19397560238229272d, y: 0.02657115778741559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6856825470442929d, y: 0.11833179467614952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9158333245278916d, y: 0.757620367451503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20175286438027695d, y: 0.8892506843459983d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    759164978,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 759164978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7378104938801638d, y: 0.06519207299493779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23076224565984715d, y: 0.6609670449966485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673158708066211d, y: 0.2637463854668535d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9663493490351414d, y: 0.2772516956721651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16951454188193327d, y: 0.16435243908050035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8992860164226215d, y: 0.5040845625750039d),

}
                    }
                );

                expected.Add(
                    881123700,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 881123700,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5618458477907279d, y: 0.40132353523645803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9497549959628124d, y: 0.07306733990326886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9973145767824994d, y: 0.3889465979730451d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    980446128,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 980446128,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4708271516112782d, y: 0.9881815010929622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265832756120493d, y: 0.47475432370582826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20798262527036326d, y: 0.8104373314043003d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    987106427,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 987106427,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43377039562563d, y: 0.13415246047503493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396675146692631d, y: 0.2404209545696514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19685738609758052d, y: 0.47402131490768784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9315316134093033d, y: 0.5910087836063582d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1098439641,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1098439641,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40050460176500746d, y: 0.20368513980626413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19008997327353783d, y: 0.5472012672987087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8262543920206203d, y: 0.8467023665990695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7509629407326948d, y: 0.8394520976859576d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031873896102865285d, y: 0.5585305400704385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08698453630572911d, y: 0.30138477208490055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4338318618873863d, y: 0.10863485151217156d),

}
                    }
                );

                expected.Add(
                    1294332601,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1294332601,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07079536212133797d, y: 0.3669866048084669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4159441596641176d, y: 0.5063926180513207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2755979899537365d, y: 0.2817862966294882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9022397703259531d, y: 0.8062926799419013d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09367533293021368d, y: 0.4546767170341436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25631093412439543d, y: 0.374956994766916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4678697325032397d, y: 0.9675141214042273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46273416299498105d, y: 0.6016332979908063d),

}
                    }
                );

                expected.Add(
                    1471583320,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1471583320,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08235036956104869d, y: 0.0706166397036726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16165582125983147d, y: 0.22502481534173668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4297044583972487d, y: 0.07005768604940377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38058548094682765d, y: 0.5855476257827822d),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1770529295,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1770529295,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094844323207187d, y: 0.22280356027112425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16061835148911963d, y: 0.33799781243954397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41241827924046714d, y: 0.5707614249503968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503580529488597d, y: 0.6989709781690203d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6784147788325041d, y: 0.9547146716081625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989819174892892d, y: 0.07178524861568958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7358231445877143d, y: 0.824275492783079d),

}
                    }
                );

                expected.Add(
                    1805636242,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 1805636242,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063423513245012d, y: 0.4978251489193797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12682545629262376d, y: 0.9166123433370782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6607252678529129d, y: 0.8213105227348313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392831451703532d, y: 0.5051025187506974d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21229761569719585d, y: 0.3271013400668642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123037187007051d, y: 0.6219215197240071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6117712075681854d, y: 0.828703041464448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9347651269506426d, y: 0.24474229668288705d),

}
                    }
                );

                expected.Add(
                    2026249571,
                    new NpgsqlPointpointArray2MI
                    {
                        Id = 2026249571,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9096022292914377d, y: 0.8474907838519739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9043265926388065d, y: 0.7085974266509609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057107659010294d, y: 0.24820087384175382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6245289723559372d, y: 0.9626873339425984d),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329647318775663d, y: 0.1640327102982897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3769518853055538d, y: 0.7939382181898468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094974911819632d, y: 0.6720756163951952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018563751831194186d, y: 0.28781592285895996d),

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

