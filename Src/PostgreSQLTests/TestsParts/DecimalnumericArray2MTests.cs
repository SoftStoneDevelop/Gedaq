

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.107735938206995m,

0.630080022503043m,

0.528601108607064m,

0.768179047415817m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.978971060642927m,

0.341148582772291m,

0.971924722411189m,

0.83209523227313m,

},
},
            new DecimalnumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.424701429510608m,

0.159840980604666m,

0.677141531305979m,

0.325410710786347m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.847454421874876m,

0.00164783095747401m,

0.17094333811041m,

0.100377138720352m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.368312633446531m,

0.887913295060985m,

0.596924401663751m,

0.578022308536836m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.643977425137728m,

0.731718747932274m,

0.239162450321461m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.855175528190309m,

0.0757267929289083m,

0.472454128766953m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17525610343436m,

0.671309523835601m,

0.0906722590020609m,

0.496333512194226m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.495706400585122m,

0.135397718120468m,

0.818154478037447m,

},
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.393299416187154m,

0.541319168689562m,

0.305494849529407m,

0.590112863863566m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0826200224547895m,

0.364180684664184m,

0.496819229535484m,

0.907924143128449m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.748590799068701m,

0.519771953158802m,

0.512368146968341m,

0.0544621665991355m,

},
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.539124358381687m,

0.791064114122017m,

0.518318437761368m,

0.12146472376625m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.529492361119941m,

0.997768649485617m,

0.682043462565249m,

},
},
            new DecimalnumericArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.251435166485291m,

0.210005301974628m,

0.914772865984406m,

0.354659724727491m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.584246495930253m,

0.581021129689646m,

0.719880351951032m,

0.76889967938558m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.433015696418838m,

0.954245745346794m,

0.661080697275162m,

0.764216299997077m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.321217729264614m,

0.82449377495399m,

0.332546788695518m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.243212124343072m,

0.881343025434816m,

0.0236801808078682m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.161944388110367m,

0.355674216887454m,

0.200002189245548m,

0.852609807012124m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.437835873669934m,

0.774327735226043m,

0.161687315002128m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.322133436793312m,

0.910876120554101m,

0.669909320491915m,

0.56805145123564m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.296753306354842m,

0.921966768245347m,

0.327246103361829m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.695010976670755m,

0.292050149806529m,

0.259720042802188m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.614411863463883m,

0.373210129374993m,

0.708261966534353m,

},
},
            new DecimalnumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.109233927451435m,

0.914085004853118m,

0.188734205937004m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.00321360364749201m,

0.228251118174767m,

0.722466160667142m,

0.712634510351329m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.609393225615724m,

0.496623012720018m,

0.390662046510439m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.975385725339551m,

0.65652625492509m,

0.948531151250507m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.825702121071271m,

0.00371638203881053m,

0.214672226160665m,

0.401323645242498m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.182809646870169m,

0.466971140302964m,

0.828821726940473m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.642448297399225m,

0.660273830684896m,

0.635283370618948m,

0.412268229859713m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.910772061377518m,

0.234328560749017m,

0.927913549309582m,

},
},
            new DecimalnumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.44054268353742m,

0.643129919697214m,

0.911641733915526m,

0.269988540088325m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0923933311119901m,

0.660785993271987m,

0.353740205998835m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.659667266750962m,

0.320062200127566m,

0.0133740017126633m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.766913938520138m,

0.514854427662007m,

0.62095610724983m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.633811542266051m,

0.479715352181975m,

0.489129552832956m,

0.44341716064437m,

},
},
            new DecimalnumericArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.397899586321014m,

0.019743489988898m,

0.896300936604894m,

0.758532956149244m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0806123627414739m,

0.277734267219077m,

0.952176419965464m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.849496563829517m,

0.9103448500107m,

0.68665268016449m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.989257758333814m,

0.285982627163103m,

0.870299257693074m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.540812503999988m,

0.337660338457867m,

0.981880726452712m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874016775113989m,

0.454437566055753m,

0.929782518212184m,

0.877708332005063m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.486009267069118m,

0.601578287410514m,

0.040139751758377m,

0.481708372382205m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.338991566001368m,

0.987035881961034m,

0.750725399010034m,

0.243796162387467m,

},
},
            new DecimalnumericArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.00508674640899176m,

0.00464497004229669m,

0.513466006673007m,

0.593916533299405m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.979783568452362m,

0.61563257466287m,

0.112003679477991m,

0.382787103494188m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.552386659420827m,

0.0409753331341642m,

0.275794777926777m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.396878294528142m,

0.664507004478328m,

0.932874637592932m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.694274230120277m,

0.0318259618773202m,

0.385749139225801m,

0.196821317757715m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.294538560028258m,

0.0485793090876511m,

0.904673453144225m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.339764782713934m,

0.64570389185422m,

0.430174593708769m,

},
},
            new DecimalnumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93128438328915m,

0.637544327546847m,

0.402132758050783m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.851556230087514m,

0.586408690468326m,

0.897275537070813m,

},
},
            new DecimalnumericArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.216442634164883m,

0.929291373478166m,

0.649056743439079m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.284341816952426m,

0.304811410284721m,

0.267716434022846m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.559284617837588m,

0.861722527861913m,

0.317518006985622m,

0.0201208352088968m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.448185839495606m,

0.903573657195833m,

0.643942617995996m,

0.233360025210435m,

},
},
            new DecimalnumericArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.491167978943692m,

0.805896281411788m,

0.1444484843544m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.790172759568023m,

0.716888254898609m,

0.0150561320442285m,

0.554429174169969m,

},
},
            new DecimalnumericArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0862195933825144m,

0.196892982534813m,

0.624412657430691m,

0.201955928015312m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.505014778974731m,

0.0380109113232013m,

0.673245239632331m,

0.147773145450178m,

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 121;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 145, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 13, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[30], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 123, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 128, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 64, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
DecimalnumericArray2M.AssertModel(models[0],_testData[23], false);DecimalnumericArray2M.AssertModel(models[1],_testData[24], false);DecimalnumericArray2M.AssertModel(models[2],_testData[25], false);DecimalnumericArray2M.AssertModel(models[3],_testData[26], false);DecimalnumericArray2M.AssertModel(models[4],_testData[27], false);DecimalnumericArray2M.AssertModel(models[5],_testData[28], false);DecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
DecimalnumericArray2M.AssertModel(models[0],_testData[11], false);DecimalnumericArray2M.AssertModel(models[1],_testData[12], false);DecimalnumericArray2M.AssertModel(models[2],_testData[13], false);DecimalnumericArray2M.AssertModel(models[3],_testData[14], false);DecimalnumericArray2M.AssertModel(models[4],_testData[15], false);DecimalnumericArray2M.AssertModel(models[5],_testData[16], false);DecimalnumericArray2M.AssertModel(models[6],_testData[17], false);DecimalnumericArray2M.AssertModel(models[7],_testData[18], false);DecimalnumericArray2M.AssertModel(models[8],_testData[19], false);DecimalnumericArray2M.AssertModel(models[9],_testData[20], false);DecimalnumericArray2M.AssertModel(models[10],_testData[21], false);DecimalnumericArray2M.AssertModel(models[11],_testData[22], false);DecimalnumericArray2M.AssertModel(models[12],_testData[23], false);DecimalnumericArray2M.AssertModel(models[13],_testData[24], false);DecimalnumericArray2M.AssertModel(models[14],_testData[25], false);DecimalnumericArray2M.AssertModel(models[15],_testData[26], false);DecimalnumericArray2M.AssertModel(models[16],_testData[27], false);DecimalnumericArray2M.AssertModel(models[17],_testData[28], false);DecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2M>(15);

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
                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

