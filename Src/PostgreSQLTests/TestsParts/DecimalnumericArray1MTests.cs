

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
    internal partial interface IDecimalArraynumericArray
    {
    }
    
    internal partial class DecimalArraynumericArray : IDecimalArraynumericArray
    {


#region TestData

        private readonly DecimalnumericArray1M[] _testData = new DecimalnumericArray1M[]
        {
            new DecimalnumericArray1M
{
    Id = 1,
    Value = 
new System.Decimal[3]
{
0.153101828691442m,
0.288758767810089m,
0.131786692193954m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 6,
    Value = 
new System.Decimal[4]
{
0.286221198706977m,
0.234687920789637m,
0.388119225980127m,
0.963756364784714m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 5,
    Value = 
new System.Decimal[4]
{
0.192538115834263m,
0.128526229257631m,
0.700087568904987m,
0.379215443379556m,
},
    NullableValue = 
new System.Decimal[3]
{
0.259635796406471m,
0.772254558359012m,
0.333805053254964m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.96113219870292m,
0.655119170442241m,
0.745018795442409m,
0.983750109409992m,
},
},
            new DecimalnumericArray1M
{
    Id = 10,
    Value = 
new System.Decimal[3]
{
0.819482514560721m,
0.291953762592262m,
0.798042106837874m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.158903473451198m,
0.592857575635528m,
0.893613326094462m,
0.787176655128183m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 13,
    Value = 
new System.Decimal[4]
{
0.592935219710536m,
0.458859395025467m,
0.470639786472183m,
0.188303678678168m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.467045636522005m,
0.954652016953766m,
0.695151780264345m,
0.151422965109911m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.223394381684167m,
0.360639848969262m,
0.966071299108684m,
0.908155277646844m,
},
},
            new DecimalnumericArray1M
{
    Id = 28,
    Value = 
new System.Decimal[4]
{
0.823370093366392m,
0.704269690573876m,
0.555920665445575m,
0.671313125473914m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[3]
{
0.643887907679163m,
0.714201386053979m,
0.349333830795082m,
},
    NullableValue = 
new System.Decimal[3]
{
0.775107391811074m,
0.612692154251933m,
0.396203489730516m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 33,
    Value = 
new System.Decimal[3]
{
0.654926226327815m,
0.706083974991213m,
0.307147560619929m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.562725277881359m,
0.0266595808843649m,
0.42423670644783m,
},
},
            new DecimalnumericArray1M
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.308702534738512m,
0.886415465293089m,
0.49036679283597m,
0.989857152576191m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.454802542541066m,
0.874872718677139m,
0.0687069942773305m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0669111580692231m,
0.182814914875962m,
0.698135922839413m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.574802334326582m,
0.170800337127329m,
0.389953556183936m,
},
},
            new DecimalnumericArray1M
{
    Id = 41,
    Value = 
new System.Decimal[3]
{
0.366953394716847m,
0.166168062341028m,
0.914145199736463m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.905718577988668m,
0.702954635441398m,
0.0564157418514125m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.11788182230584m,
0.248160321593232m,
0.48875227734358m,
0.354954708186595m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 45,
    Value = 
new System.Decimal[4]
{
0.41268423870717m,
0.263110595713161m,
0.461721432868073m,
0.0524942542311462m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.136078467299833m,
0.58277256493517m,
0.577398412466589m,
},
},
            new DecimalnumericArray1M
{
    Id = 46,
    Value = 
new System.Decimal[4]
{
0.460769319781428m,
0.848445928183019m,
0.651765241475626m,
0.369799333570382m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 38,
    Value = 
new System.Decimal[4]
{
0.730229753977606m,
0.966223961101143m,
0.386267159721561m,
0.828929336048965m,
},
    NullableValue = 
new System.Decimal[3]
{
0.73920726543938m,
0.745013260559841m,
0.22435419004521m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 55,
    Value = 
new System.Decimal[3]
{
0.0277002844200743m,
0.165533039388193m,
0.952899745507837m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 56,
    Value = 
new System.Decimal[4]
{
0.68236243486645m,
0.691570551059922m,
0.0623606085812864m,
0.848588668597078m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 41,
    Value = 
new System.Decimal[3]
{
0.300053458810914m,
0.874175132721648m,
0.667124695019838m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.89211907315854m,
0.00872269354007294m,
0.191142207860391m,
0.140313802116118m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.160985519271169m,
0.926730315784456m,
0.999325317967102m,
0.778107838345252m,
},
},
            new DecimalnumericArray1M
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.577453788506449m,
0.869440023382319m,
0.948755671295437m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.879323735235087m,
0.266911845511543m,
0.600784063309806m,
},
    NullableValue = 
new System.Decimal[3]
{
0.899986564462623m,
0.769077608060962m,
0.992801631836858m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.872687944716494m,
0.557915826501079m,
0.284832925173226m,
0.429197619826095m,
},
},
            new DecimalnumericArray1M
{
    Id = 71,
    Value = 
new System.Decimal[4]
{
0.22741470821978m,
0.0422046953136052m,
0.643791230472026m,
0.993225928121833m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.372446525938756m,
0.542271791056635m,
0.0591558585822904m,
},
},
            new DecimalnumericArray1M
{
    Id = 80,
    Value = 
new System.Decimal[3]
{
0.979750137055314m,
0.955596100317052m,
0.26410296844032m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 49,
    Value = 
new System.Decimal[3]
{
0.413729099698958m,
0.708310060684121m,
0.111384222029885m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.352907272342862m,
0.553044247788219m,
0.177614256594779m,
},
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.0668577161920944m,
0.832130028652809m,
0.945969640892217m,
0.00746367440976858m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.531246970379742m,
0.888003564903561m,
0.787441919418m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 52,
    Value = 
new System.Decimal[4]
{
0.689171989406959m,
0.109867731525262m,
0.204601666149472m,
0.661496242935462m,
},
    NullableValue = 
new System.Decimal[4]
{
0.907978996543432m,
0.644123229421944m,
0.236867494089091m,
0.150490807065769m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 95,
    Value = 
new System.Decimal[3]
{
0.696050163281688m,
0.459794734565294m,
0.206378190425312m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 98,
    Value = 
new System.Decimal[4]
{
0.943119889482836m,
0.786214438044976m,
0.632533624311198m,
0.39641536438771m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 56,
    Value = 
new System.Decimal[3]
{
0.0939219531495716m,
0.762761871094797m,
0.277639480827978m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.914991077403064m,
0.837002319401564m,
0.7985060852261m,
},
},
            new DecimalnumericArray1M
{
    Id = 105,
    Value = 
new System.Decimal[4]
{
0.600842639040108m,
0.818811321205217m,
0.495237895776211m,
0.714107904648788m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.256123402896203m,
0.558406391222693m,
0.184423718495443m,
},
},
            new DecimalnumericArray1M
{
    Id = 112,
    Value = 
new System.Decimal[4]
{
0.971851328295766m,
0.652049738081674m,
0.725108650644964m,
0.71450433519601m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.880593955020796m,
0.164286338478532m,
0.123665597734655m,
},
    NullableValue = 
new System.Decimal[4]
{
0.228323957913695m,
0.533101467885156m,
0.906420204434296m,
0.42399288597279m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.478450077177086m,
0.00981838244886912m,
0.0258779449418426m,
0.101669325558329m,
},
},
            new DecimalnumericArray1M
{
    Id = 120,
    Value = 
new System.Decimal[3]
{
0.485421714683036m,
0.410680428896307m,
0.841202502622886m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.991568535672855m,
0.425345739691743m,
0.913343425883455m,
0.883388834836572m,
},
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[3]
{
0.0571793773830167m,
0.343311882152464m,
0.114055274462578m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 61,
    Value = 
new System.Decimal[3]
{
0.102232164525527m,
0.965714937778885m,
0.614336684328434m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.355261696162162m,
0.319302268282552m,
0.0237946482210316m,
0.156215990275213m,
},
},
            new DecimalnumericArray1M
{
    Id = 128,
    Value = 
new System.Decimal[3]
{
0.653789703196481m,
0.986770550860944m,
0.946187820579231m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 131,
    Value = 
new System.Decimal[3]
{
0.893387213111233m,
0.478119705959862m,
0.953822206831106m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[4]
{
0.581224536716521m,
0.569315219277664m,
0.743575063302508m,
0.546634285231805m,
},
    NullableValue = 
new System.Decimal[4]
{
0.185114931977426m,
0.777955972932036m,
0.645277766190809m,
0.895336502851794m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.742825835725607m,
0.427447737762625m,
0.53174145849128m,
},
},
            new DecimalnumericArray1M
{
    Id = 134,
    Value = 
new System.Decimal[4]
{
0.828439515512261m,
0.665627412016286m,
0.879428340357549m,
0.763986570030799m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.900488904859724m,
0.780347554947662m,
0.970513971970038m,
},
},
            new DecimalnumericArray1M
{
    Id = 138,
    Value = 
new System.Decimal[4]
{
0.266409799622338m,
0.511020581450465m,
0.471966482283778m,
0.528246229769184m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 71,
    Value = 
new System.Decimal[4]
{
0.304652121478371m,
0.770024634916894m,
0.739393250984486m,
0.310324516144427m,
},
    NullableValue = 
new System.Decimal[3]
{
0.483728944686248m,
0.26690491862701m,
0.743482195482886m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.828322765147919m,
0.722670944381279m,
0.328007478657055m,
0.224281700422683m,
},
},
            new DecimalnumericArray1M
{
    Id = 146,
    Value = 
new System.Decimal[3]
{
0.94813726355686m,
0.933479304022884m,
0.869275426971265m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 147,
    Value = 
new System.Decimal[4]
{
0.662793551107058m,
0.876128049499002m,
0.405882426064758m,
0.311529515494539m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 76,
    Value = 
new System.Decimal[4]
{
0.551484390150333m,
0.793013106113726m,
0.97705807531517m,
0.142266404546939m,
},
    NullableValue = 
new System.Decimal[4]
{
0.729387009824318m,
0.788613598989651m,
0.334216758497797m,
0.620703503578509m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.657468407918503m,
0.780572012112276m,
0.00893328706979779m,
0.899034276049436m,
},
},
            new DecimalnumericArray1M
{
    Id = 152,
    Value = 
new System.Decimal[4]
{
0.788383063841386m,
0.4577439030089m,
0.357963398697395m,
0.317712319453458m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 161,
    Value = 
new System.Decimal[4]
{
0.724102634268658m,
0.264219042080261m,
0.155355707768084m,
0.126268076690428m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.981949071836454m,
0.137279071546445m,
0.636138341822748m,
0.133012685492781m,
},
    NullableValue = 
new System.Decimal[4]
{
0.730576937302552m,
0.820304620831823m,
0.227386293626069m,
0.310762744197513m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 166,
    Value = 
new System.Decimal[3]
{
0.165691274693068m,
0.69900573111013m,
0.784797177362385m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.16788163741227m,
0.554814593909949m,
0.563575446142463m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
INSERT INTO public.decimalnumericarray1mi(
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
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
            asPartInterface: typeof(IDecimalArraynumericArray)), 
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
                methodParametrName: "decimalnumericarray1mi_id", 
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
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.223394381684167m,
0.360639848969262m,
0.966071299108684m,
0.908155277646844m,
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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.562725277881359m,
0.0266595808843649m,
0.42423670644783m,
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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.574802334326582m,
0.170800337127329m,
0.389953556183936m,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                methodParametrName: "decimalnumericarray1mi_id", 
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
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.136078467299833m,
0.58277256493517m,
0.577398412466589m,
}));
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr2.Value = 33;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 152, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 134, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                DecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
FROM public.binary_decimalnumericarray1m m
LEFT JOIN public.binary_decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models =  ((IDecimalArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI), typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                await ((IDecimalArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                ((IDecimalArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

