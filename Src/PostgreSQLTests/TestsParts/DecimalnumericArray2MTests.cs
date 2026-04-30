

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.534595107409012m,

0.355997181590844m,

0.878841809690948m,

0.455986399021914m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.879346189482986m,

0.509607080587644m,

0.00642763184087691m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.119200949822216m,

0.80078813543476m,

0.585481727868829m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.375438225349049m,

0.140388337041306m,

0.760958468293393m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.677159624249533m,

0.143179020293319m,

0.716358931899171m,

0.747917592870002m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.978697932902704m,

0.881428618693411m,

0.613895839300038m,

0.393193699054485m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.488607344014968m,

0.101997744666812m,

0.0315211841608999m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.966774394859085m,

0.818016031411836m,

0.531594106273279m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0315212409664051m,

0.116227846611415m,

0.0207093261051063m,

0.260796874757118m,

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
0.89272023272473m,

0.0926622263559156m,

0.506137415659145m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.382449848400886m,

0.767518800050561m,

0.568066740959067m,

0.364186982987395m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.916930672389747m,

0.207348531593424m,

0.949358997044755m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.135222064426353m,

0.588006314619105m,

0.690783693189126m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108512297095024m,

0.93235143217554m,

0.207364115296525m,

0.300911531483757m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.92450148286181m,

0.415558228446656m,

0.445148408645972m,

},
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0490888908780572m,

0.0992080718319547m,

0.393027664273661m,

0.512318751131226m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.350309718907055m,

0.0148652143743633m,

0.0313074302819696m,

0.0973823414311709m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.00858127001296249m,

0.831179522417343m,

0.855152870052598m,

0.184601333881711m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.910363886659991m,

0.199044082778162m,

0.938664857983863m,

},
},
            new DecimalnumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.745830792209008m,

0.47187440110104m,

0.920502310605326m,

0.501420288527427m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.508105721312326m,

0.454968474210436m,

0.367874186554272m,

0.0799162594075579m,

},
},
            new DecimalnumericArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.686794696121205m,

0.0554224394010776m,

0.556639006842051m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.895879448122724m,

0.35305682716992m,

0.255904545554652m,

0.640445412303228m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.796845628192415m,

0.703344877228872m,

0.787926789361099m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.150267641264286m,

0.22966430946402m,

0.855714018292678m,

0.354447822369906m,

},
},
            new DecimalnumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.854351335396286m,

0.730528496869395m,

0.987969226600379m,

0.980491694870758m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0482146965603504m,

0.23032780541104m,

0.384270811645784m,

0.558357026694487m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0234253466323737m,

0.0495928837950449m,

0.350067170654332m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.652138020942008m,

0.758638873852757m,

0.0604729497049554m,

0.327068256812883m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.224852210364543m,

0.566383357672918m,

0.991062267313839m,

},
},
            new DecimalnumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.103678785940017m,

0.245632434566624m,

0.416306080390816m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.812688461932402m,

0.539655276237012m,

0.509731917759564m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.949601450403406m,

0.922486775481469m,

0.231854894968333m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.613336274134324m,

0.185080492117528m,

0.219235426947877m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.572503811528888m,

0.904129485082512m,

0.378848815069233m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.934746620895233m,

0.00746986343334011m,

0.662109789230682m,

0.701978548556072m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.267639516724127m,

0.298698226105369m,

0.962150290961267m,

0.558457452467237m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.168851003473743m,

0.170722618455725m,

0.464698581415097m,

0.316546980920976m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.399773568403507m,

0.383522667436649m,

0.725333074074373m,

0.148959007561834m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.81881755126234m,

0.580395266873722m,

0.240817362493478m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.761522171362636m,

0.471025504670713m,

0.469201321970998m,

},
},
            new DecimalnumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.636263405831528m,

0.666277616674659m,

0.173181647298967m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.555013208025329m,

0.501711451822275m,

0.192641253806988m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.384448146982871m,

0.644256975430531m,

0.148901474013173m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.674532089326836m,

0.701470655251901m,

0.348522581547555m,

},
},
            new DecimalnumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.624567965518848m,

0.591844942662954m,

0.981419082641727m,

0.401725678722668m,

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
0.994572838836081m,

0.665774532366702m,

0.0707151682817898m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.795955724232547m,

0.0598156278062879m,

0.383516944443716m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.875813114069478m,

0.675374567642594m,

0.845797156367886m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.327916889649034m,

0.158973920314178m,

0.674498400655598m,

0.444274583061184m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0243363653397292m,

0.823329520013621m,

0.376296786149405m,

0.0854732914993029m,

},
},
            new DecimalnumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.285683550176594m,

0.518173484749623m,

0.408176701542378m,

0.339091304542342m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.955879384083203m,

0.785751546038244m,

0.306082828174056m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0494878229281744m,

0.59346699317103m,

0.720014898468114m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46125728425561m,

0.418951387860774m,

0.148657800477927m,

0.17798698369148m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.266667796120661m,

0.393756341558002m,

0.78934636188261m,

},
},
            new DecimalnumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.733017893730546m,

0.639257216790758m,

0.834547136315156m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.706437305954328m,

0.968614018062971m,

0.0764746357215556m,

0.114658104897467m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.677988260244948m,

0.184811723364214m,

0.623805697152634m,

0.1970446579587m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.995023203909119m,

0.67207281023163m,

0.986740967883037m,

0.543262962766131m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.272404463490538m,

0.1186425347209m,

0.250520298896526m,

0.973779027336708m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.871597039842214m,

0.732194581142147m,

0.83620444453124m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.34175644275934m,

0.304763650240979m,

0.939904867912898m,

},
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 54, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 54, query2))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 28, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
DecimalnumericArray2M.AssertModel(models[0],_testData[8], false);DecimalnumericArray2M.AssertModel(models[1],_testData[9], false);DecimalnumericArray2M.AssertModel(models[2],_testData[10], false);DecimalnumericArray2M.AssertModel(models[3],_testData[11], false);DecimalnumericArray2M.AssertModel(models[4],_testData[12], false);DecimalnumericArray2M.AssertModel(models[5],_testData[13], false);DecimalnumericArray2M.AssertModel(models[6],_testData[14], false);DecimalnumericArray2M.AssertModel(models[7],_testData[15], false);DecimalnumericArray2M.AssertModel(models[8],_testData[16], false);DecimalnumericArray2M.AssertModel(models[9],_testData[17], false);DecimalnumericArray2M.AssertModel(models[10],_testData[18], false);DecimalnumericArray2M.AssertModel(models[11],_testData[19], false);DecimalnumericArray2M.AssertModel(models[12],_testData[20], false);DecimalnumericArray2M.AssertModel(models[13],_testData[21], false);DecimalnumericArray2M.AssertModel(models[14],_testData[22], false);DecimalnumericArray2M.AssertModel(models[15],_testData[23], false);DecimalnumericArray2M.AssertModel(models[16],_testData[24], false);DecimalnumericArray2M.AssertModel(models[17],_testData[25], false);DecimalnumericArray2M.AssertModel(models[18],_testData[26], false);DecimalnumericArray2M.AssertModel(models[19],_testData[27], false);DecimalnumericArray2M.AssertModel(models[20],_testData[28], false);DecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
DecimalnumericArray2M.AssertModel(models[0],_testData[8], false);DecimalnumericArray2M.AssertModel(models[1],_testData[9], false);DecimalnumericArray2M.AssertModel(models[2],_testData[10], false);DecimalnumericArray2M.AssertModel(models[3],_testData[11], false);DecimalnumericArray2M.AssertModel(models[4],_testData[12], false);DecimalnumericArray2M.AssertModel(models[5],_testData[13], false);DecimalnumericArray2M.AssertModel(models[6],_testData[14], false);DecimalnumericArray2M.AssertModel(models[7],_testData[15], false);DecimalnumericArray2M.AssertModel(models[8],_testData[16], false);DecimalnumericArray2M.AssertModel(models[9],_testData[17], false);DecimalnumericArray2M.AssertModel(models[10],_testData[18], false);DecimalnumericArray2M.AssertModel(models[11],_testData[19], false);DecimalnumericArray2M.AssertModel(models[12],_testData[20], false);DecimalnumericArray2M.AssertModel(models[13],_testData[21], false);DecimalnumericArray2M.AssertModel(models[14],_testData[22], false);DecimalnumericArray2M.AssertModel(models[15],_testData[23], false);DecimalnumericArray2M.AssertModel(models[16],_testData[24], false);DecimalnumericArray2M.AssertModel(models[17],_testData[25], false);DecimalnumericArray2M.AssertModel(models[18],_testData[26], false);DecimalnumericArray2M.AssertModel(models[19],_testData[27], false);DecimalnumericArray2M.AssertModel(models[20],_testData[28], false);DecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IDecimalListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IDecimalListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(DecimalnumericArray2MI),
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
            queryMapType: typeof(DecimalnumericArray2M),
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

