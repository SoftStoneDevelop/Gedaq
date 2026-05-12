

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
    internal partial interface IDecimalMArraynumericMMArrayD1
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD1 : IDecimalMArraynumericMMArrayD1
    {


#region TestData

        private readonly DecimalnumericMMArrayD1E1M[] _testData = new DecimalnumericMMArrayD1E1M[]
        {
            new DecimalnumericMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Decimal[4]
{
0.450181965796744m,
0.245454288466698m,
0.954494885195575m,
0.556750045797756m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0711960790226691m,
0.150828830468346m,
0.343325164878167m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Decimal[4]
{
0.831243990650645m,
0.986707644517423m,
0.782291100265442m,
0.988551613541514m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Decimal[3]
{
0.25905022164035m,
0.110241915000664m,
0.567495417611209m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.655982549390846m,
0.24908704442703m,
0.750897982497287m,
0.0564931429944129m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Decimal[3]
{
0.427944221920832m,
0.550379376240316m,
0.127532360765606m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Decimal[3]
{
0.510527096301105m,
0.290535181186045m,
0.614994743807181m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Decimal[4]
{
0.699417994534936m,
0.677498600442507m,
0.387990711817478m,
0.0578489075501756m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.734926925598644m,
0.595271026908395m,
0.174259374080141m,
0.341775492833991m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Decimal[3]
{
0.456563096526562m,
0.471281076359463m,
0.573746416485243m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.63737234550877m,
0.194004701517906m,
0.40637038562991m,
0.0637186484031492m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.482374227642561m,
0.0527171103868737m,
0.540820559612791m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Decimal[3]
{
0.158702714157884m,
0.126471181062171m,
0.228374381238591m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.259621802789196m,
0.0318513579178422m,
0.554021796855292m,
0.712046828236643m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Decimal[4]
{
0.232163426332352m,
0.362208722369244m,
0.00123737056052664m,
0.258585531181584m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Decimal[4]
{
0.82629340749054m,
0.608567962866755m,
0.342557189239715m,
0.541102421945394m,
},
    NullableValue = 
new System.Decimal[3]
{
0.454046584441138m,
0.373613026231052m,
0.585585673950269m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.79962863500465m,
0.714301395707846m,
0.305274593310571m,
0.31871734242279m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Decimal[4]
{
0.207747090247329m,
0.758886477442967m,
0.167177813223454m,
0.415592435403934m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.839170566158065m,
0.783030254390959m,
0.955485189985661m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Decimal[4]
{
0.805663836717308m,
0.0355959275981043m,
0.301119168960914m,
0.357255370451732m,
},
    NullableValue = 
new System.Decimal[3]
{
0.706793291838761m,
0.841249053964264m,
0.442228602287606m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.456676375215101m,
0.959319152899348m,
0.135940134527769m,
0.547846576160719m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Decimal[3]
{
0.303285121921251m,
0.503095730719503m,
0.763561763424357m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.547620679430694m,
0.189895083050632m,
0.851145820811384m,
0.0120576178273796m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.336442427952242m,
0.160161514202577m,
0.289679718668823m,
0.459117801453462m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.297113633000838m,
0.841937294553659m,
0.647625229949087m,
0.639779924751476m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.15741547078982m,
0.225948472757108m,
0.507593346869932m,
0.975885136456128m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Decimal[4]
{
0.384770459485976m,
0.435861241293856m,
0.932576792656425m,
0.490887727264409m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.0941699051117411m,
0.772757829170554m,
0.314909508131315m,
0.535601255709345m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.208529371414005m,
0.461986130641076m,
0.197367827885139m,
0.44420187601087m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.519317119698456m,
0.0228613065852575m,
0.109738858109222m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.092712983257684m,
0.134633446517128m,
0.416117965632739m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Decimal[4]
{
0.287641543701923m,
0.438934574366348m,
0.0865095717716939m,
0.575254167513895m,
},
    NullableValue = 
new System.Decimal[4]
{
0.478483162580037m,
0.0064889055348063m,
0.574121548418877m,
0.394027855878493m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.656221770597354m,
0.439462099189665m,
0.533797552141227m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.359293839920292m,
0.85090929683105m,
0.109832720549755m,
0.978930380505693m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.42971684489159m,
0.801888187638592m,
0.974685145654564m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Decimal[4]
{
0.0842688879193301m,
0.741024462564739m,
0.369571375125743m,
0.860928312397389m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Decimal[3]
{
0.364154148837184m,
0.0821126820592921m,
0.0147274033357597m,
},
    NullableValue = 
new System.Decimal[4]
{
0.824840041974427m,
0.82985665723568m,
0.440990595168529m,
0.345131744400812m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Decimal[3]
{
0.640820727291932m,
0.0493441508307282m,
0.335887266897297m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Decimal[4]
{
0.330013096412594m,
0.927145655456706m,
0.495396594952933m,
0.396199567784331m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.291838308339565m,
0.344854909953422m,
0.518312668294411m,
},
    NullableValue = 
new System.Decimal[3]
{
0.121799758663867m,
0.394806921834987m,
0.38917925981091m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.606352618504157m,
0.687384018356422m,
0.209622692600744m,
0.219591718173417m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Decimal[4]
{
0.697684055710544m,
0.52874067823472m,
0.834038899794027m,
0.205297783245613m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Decimal[3]
{
0.543756796622496m,
0.211663784472078m,
0.674925851046964m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Decimal[3]
{
0.229021341380959m,
0.00427188844265558m,
0.736203530400505m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Decimal[3]
{
0.73396948053755m,
0.398247656808999m,
0.61267925988621m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Decimal[3]
{
0.116543336247969m,
0.0959499433957295m,
0.422958755624094m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.320444908639272m,
0.495183236426657m,
0.452766909920664m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Decimal[3]
{
0.230116708894049m,
0.31000938891836m,
0.14685118555018m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.276943347862929m,
0.384573334819338m,
0.230184339029343m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Decimal[3]
{
0.907754268029962m,
0.340731176625392m,
0.573100113641904m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Decimal[4]
{
0.311165379562925m,
0.541697807282088m,
0.237448479717883m,
0.171898422731648m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Decimal[3]
{
0.367389766212359m,
0.667394137305404m,
0.0606388407227902m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.532657243954409m,
0.783347549747868m,
0.885311027288659m,
0.818660241598469m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Decimal[3]
{
0.249057047689957m,
0.0549948852586659m,
0.128958706901694m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Decimal[3]
{
0.912521698684049m,
0.42127780109671m,
0.837714643334007m,
},
    NullableValue = 
new System.Decimal[4]
{
0.235599907650885m,
0.469151997427524m,
0.968877787859482m,
0.73367168366538m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 158,
    Value = 
new System.Decimal[4]
{
0.322744360602213m,
0.192747902241495m,
0.235281979839801m,
0.392445656118973m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.656585641674322m,
0.927832050393885m,
0.475183942176077m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Decimal[4]
{
0.433892080647622m,
0.61978629930037m,
0.88183385810886m,
0.614728334667288m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Decimal[3]
{
0.7276924163601m,
0.428934472192867m,
0.228285269249382m,
},
    NullableValue = 
new System.Decimal[4]
{
0.219179205980944m,
0.61691751385131m,
0.48886752532546m,
0.114798328252618m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.846515326451764m,
0.346249631521541m,
0.503594764222649m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Decimal[3]
{
0.390563008993174m,
0.935450260289839m,
0.268081196308272m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Decimal[4]
{
0.598996133425155m,
0.0796948014928389m,
0.883156141303085m,
0.75076722654108m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Decimal[3]
{
0.0331293493427365m,
0.149141802985685m,
0.775918296618695m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Decimal[4]
{
0.480457154616252m,
0.851478300084385m,
0.831651285916669m,
0.963972712661522m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Decimal[3]
{
0.12565962286576m,
0.280715625948527m,
0.617237794629562m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Decimal[3]
{
0.182598633598347m,
0.492269318223555m,
0.777891285488413m,
},
    NullableValue = 
new System.Decimal[3]
{
0.505568739659737m,
0.611079048087704m,
0.622224900992928m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.0682023471280608m,
0.0651331907442172m,
0.611773698336034m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 180,
    Value = 
new System.Decimal[3]
{
0.77336708911009m,
0.48698057847106m,
0.471499917980757m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.132437712016399m,
0.549204784987611m,
0.432702904846734m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
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

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.734926925598644m,
0.595271026908395m,
0.174259374080141m,
0.341775492833991m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.482374227642561m,
0.0527171103868737m,
0.540820559612791m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.259621802789196m,
0.0318513579178422m,
0.554021796855292m,
0.712046828236643m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.79962863500465m,
0.714301395707846m,
0.305274593310571m,
0.31871734242279m,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.336442427952242m,
0.160161514202577m,
0.289679718668823m,
0.459117801453462m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 164, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 35, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD1E1M),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
FROM public.binary_decimalnumericmmarrayd1e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI), typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

