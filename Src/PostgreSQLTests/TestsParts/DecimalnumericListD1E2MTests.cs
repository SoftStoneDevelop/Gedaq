

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
    internal partial interface IDecimalListnumericListD1
    {
    }
    
    internal partial class DecimalListnumericListD1 : IDecimalListnumericListD1
    {


#region TestData

        private readonly DecimalnumericListD1E2M[] _testData = new DecimalnumericListD1E2M[]
        {
            new DecimalnumericListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.82373022214913m,

0.910292209162086m,

0.207379736843924m,

0.489858580695782m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.16741696698187m,

0.104158165674488m,

0.909671558339634m,

0.485663816594532m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.787503142591616m,

0.772422182028008m,

0.0657903756459996m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.716492580266457m,

0.78825528663162m,

0.280977227478629m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.502854545460872m,

0.913974173413375m,

0.743936925035089m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.182745356853095m,

0.00426113048287635m,

0.0134308487318957m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.607762531294959m,

0.550123640303353m,

0.431146726501736m,

0.446027002803448m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.978862797117993m,

0.430821494844803m,

0.283503042561522m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.885005167155058m,

0.621624227117806m,

0.841447367669455m,

0.536841332693951m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.113163993652885m,

0.152400530228765m,

0.986590353342263m,

0.560398011218212m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.828007702563029m,

0.987046448597276m,

0.21653176130772m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.734170955822866m,

0.10977041787877m,

0.289508229760722m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.545143638446653m,

0.64956907656191m,

0.300206110785665m,

0.366686262774956m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.92145948222592m,

0.0305905386189235m,

0.043151885906318m,

0.880721145652872m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.825801238624158m,

0.30470148834133m,

0.118545706004349m,

0.275876716894467m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.922853698168222m,

0.134172230068226m,

0.502607183189608m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.860623034065916m,

0.155823762691081m,

0.1100558232618m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.371486170448583m,

0.239174937914933m,

0.294838611580622m,

0.795864983769456m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.164723434611711m,

0.801034361679244m,

0.890171239947174m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.317408903626751m,

0.746367041477542m,

0.279522728229995m,

0.997341750750802m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.405727016652306m,

0.582021072868425m,

0.845142689692266m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.278653246758224m,

0.412441385793634m,

0.503864573302856m,

0.51345941432262m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.217637164784014m,

0.0878214915203498m,

0.547971263574307m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.796335842750486m,

0.330857394836756m,

0.730211334545833m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.234268819737844m,

0.104108190813194m,

0.549179400945421m,

0.991513682120416m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.164932511538466m,

0.633977511008918m,

0.737870079236706m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.124087992904951m,

0.467649793850814m,

0.816694255585654m,

0.698911856454894m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.613612332907804m,

0.693174389810444m,

0.0630065120812473m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.388029751809049m,

0.152632803445018m,

0.452037699024388m,

0.600942833478465m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.310562872794733m,

0.408028361068152m,

0.185665244309784m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.371818235857952m,

0.368137027607811m,

0.0736498084267338m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.236348246412761m,

0.0511076079001621m,

0.0411787070470906m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.136880892530241m,

0.144176531157239m,

0.613396492201034m,

0.541940728705837m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.54208229160284m,

0.238795207888147m,

0.641018878185233m,

0.186122881741932m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.969485875571204m,

0.924965547634024m,

0.448731539574047m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.201660496122013m,

0.36392240599193m,

0.180227317300097m,

0.621255610884322m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88080425386768m,

0.942615160354802m,

0.141687404198743m,

0.732595691392254m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0700402445240512m,

0.269606529758503m,

0.526111384245652m,

0.962297569369052m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.800711185295561m,

0.124467383621374m,

0.228620584784703m,

0.52873834959359m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0882551120731593m,

0.303990694994797m,

0.830530586972521m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.977468925592588m,

0.977619377435888m,

0.571937238298517m,

0.0504019310992119m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.554614752628538m,

0.339987681945789m,

0.664729302827379m,

0.0784009316575454m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.624919003817681m,

0.123218729391573m,

0.00903732442715766m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.789065003026183m,

0.155733256948543m,

0.332388575053895m,

0.0690976447363415m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.803932699906196m,

0.376620470836607m,

0.194501962448652m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.730314026602958m,

0.0758396462681514m,

0.181845909614858m,

0.0454204137746835m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.953792535855357m,

0.477175050316461m,

0.581865396956169m,

0.314191102572103m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.808465986862633m,

0.0799839468029212m,

0.88803263195778m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.109160439620195m,

0.936189930425691m,

0.395457223537308m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.624155752389296m,

0.375026151625129m,

0.0119797496662974m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.778080296697702m,

0.774022954923398m,

0.246550957200174m,

0.658673049419956m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.166935337897874m,

0.603483623759556m,

0.0110354545045701m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.182889926098299m,

0.661348583588965m,

0.653826066519333m,

0.307072549407745m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.509029426837359m,

0.0336929729486877m,

0.133536308740768m,

0.967506394289645m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.701217213645899m,

0.42510966124667m,

0.265524505669528m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.997923945728292m,

0.676888182815828m,

0.215948964327025m,

0.745200507584585m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61670445853516m,

0.00890286422994857m,

0.612319336221366m,

0.584469034428694m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.896742900893689m,

0.222576608127782m,

0.0771749640897107m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.283494554572053m,

0.186306802482751m,

0.662083575908684m,

0.11441437756855m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.559911484393986m,

0.66101109346787m,

0.0194502110680379m,

0.27057732092032m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.517392393345142m,

0.205134090235374m,

0.138289443106759m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.937287752746789m,

0.524070559188803m,

0.0419799363183684m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.616526327408014m,

0.651951378550281m,

0.494135309249228m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.268663449399863m,

0.585334266654522m,

0.498886116754726m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.106068262369082m,

0.859344862611116m,

0.175421378704081m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.704666596027348m,

0.821618289685527m,

0.130065308958759m,

0.13405072797732m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.731416932061753m,

0.526155676315421m,

0.936528812970172m,

0.639462660803193m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00668806287808732m,

0.775599702209453m,

0.422766897505364m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.852010248232637m,

0.339611851031679m,

0.69224532439942m,

0.026189534785246m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.667685281063938m,

0.385154599328467m,

0.667849525490743m,

0.953447147544055m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.648849107994706m,

0.196262464966515m,

0.0193413572747811m,

0.485527648134997m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.806235735368094m,

0.999238033494348m,

0.736056611758296m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.732892797345179m,

0.819128902526087m,

0.244089782707799m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0995933704266618m,

0.770788650739613m,

0.635093263417204m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.789437594231137m,

0.804017066818596m,

0.77470650448999m,

0.467113523909302m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.53574680974933m,

0.235466262373882m,

0.807064437473886m,

0.171811222619156m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.765018985602995m,

0.39108904307369m,

0.462711800186404m,

0.0233291957672491m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.425765227663918m,

0.631585139918579m,

0.916635216856993m,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2mi(
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
INSERT INTO public.decimalnumericlistd1e2mi(
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
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
            asPartInterface: typeof(IDecimalListnumericListD1)), 
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                List<DecimalnumericListD1E2M> models = null;

                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericListD1E2M> models = null;

                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 140, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 32, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 85, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 82, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models = await ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MI),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericListD1E2M),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
FROM public.binary_decimalnumericlistd1e2m m
LEFT JOIN public.binary_decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI), typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                await ((IDecimalListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                ((IDecimalListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

