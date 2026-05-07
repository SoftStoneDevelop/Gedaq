

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
    Id = 3,
    Value = 
new System.Decimal[4]
{
0.826009901537942m,
0.920968705282772m,
0.676891023813277m,
0.297704288119619m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.455952924286765m,
0.958020920591992m,
0.245758519772518m,
0.490512126950422m,
},
},
            new DecimalnumericArray1M
{
    Id = 9,
    Value = 
new System.Decimal[4]
{
0.969415328525613m,
0.86656417664011m,
0.685033070521353m,
0.105753121521717m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 4,
    Value = 
new System.Decimal[3]
{
0.61733552397495m,
0.970515641898412m,
0.0892180983899386m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.95221251911552m,
0.531467215222113m,
0.893859057538812m,
},
},
            new DecimalnumericArray1M
{
    Id = 13,
    Value = 
new System.Decimal[3]
{
0.308203290383466m,
0.153851012894355m,
0.80314621831553m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 19,
    Value = 
new System.Decimal[4]
{
0.594246692125726m,
0.443809287670974m,
0.514648531580822m,
0.103197647931378m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 12,
    Value = 
new System.Decimal[4]
{
0.395549621428125m,
0.813084669875042m,
0.984773454810961m,
0.185037358562951m,
},
    NullableValue = 
new System.Decimal[3]
{
0.55949949700368m,
0.978912326760391m,
0.369600180357504m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.360048220286325m,
0.879278246697778m,
0.397872584726713m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 26,
    Value = 
new System.Decimal[3]
{
0.999384417098488m,
0.398013018934956m,
0.0914445837109885m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 13,
    Value = 
new System.Decimal[3]
{
0.704461468021905m,
0.784021920752191m,
0.5143508987839m,
},
    NullableValue = 
new System.Decimal[3]
{
0.708840040440568m,
0.0215560794778128m,
0.214928316710335m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.407089564870775m,
0.457708698204522m,
0.105871870195043m,
0.527216089102037m,
},
},
            new DecimalnumericArray1M
{
    Id = 31,
    Value = 
new System.Decimal[4]
{
0.230155736343958m,
0.870092080138345m,
0.277653735484529m,
0.347270918668198m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 32,
    Value = 
new System.Decimal[3]
{
0.646469887381305m,
0.11665972248161m,
0.897813646355216m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 21,
    Value = 
new System.Decimal[4]
{
0.403907315126101m,
0.89411625260489m,
0.647838704106307m,
0.766533465599475m,
},
    NullableValue = 
new System.Decimal[4]
{
0.405182226631058m,
0.904201145772257m,
0.381097390420883m,
0.800300286247512m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.11575485687991m,
0.80498922907039m,
0.313925519333925m,
0.964052868194808m,
},
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.854667190339394m,
0.592059086250511m,
0.590092810269253m,
0.0515851031649798m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.123088984220139m,
0.411489193770535m,
0.869487904199684m,
},
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[4]
{
0.585489907126538m,
0.5425528095011m,
0.397143289961583m,
0.674769832607847m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[4]
{
0.811790661700528m,
0.107885136284908m,
0.532046820703234m,
0.0671213757279213m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 47,
    Value = 
new System.Decimal[4]
{
0.363892623797546m,
0.862730750700954m,
0.993899672042008m,
0.0325916141954426m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0777909039226543m,
0.982180555046056m,
0.362437559844168m,
},
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[3]
{
0.250656762186478m,
0.168473336605719m,
0.286123674605219m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.857042906986409m,
0.729962334957071m,
0.444739602964059m,
0.99991976977101m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 59,
    Value = 
new System.Decimal[4]
{
0.71463080136246m,
0.511050236024909m,
0.312184709967363m,
0.9641346218815m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.110610489679117m,
0.548738648876804m,
0.759267795789149m,
},
},
            new DecimalnumericArray1M
{
    Id = 66,
    Value = 
new System.Decimal[3]
{
0.46136556455495m,
0.659278342758434m,
0.421107187352525m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.687606240910096m,
0.145159800402913m,
0.682669268823266m,
},
    NullableValue = 
new System.Decimal[3]
{
0.366978248856083m,
0.465227664305716m,
0.753170591784768m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 75,
    Value = 
new System.Decimal[3]
{
0.391559185888617m,
0.457706279863337m,
0.00736966544874162m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.411961017480235m,
0.328524169407575m,
0.961196276024677m,
0.849134303373485m,
},
},
            new DecimalnumericArray1M
{
    Id = 82,
    Value = 
new System.Decimal[4]
{
0.136170330550729m,
0.844790785198655m,
0.913431369462577m,
0.111637137728377m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.3925081647664m,
0.361961495803984m,
0.652251770960215m,
0.428759151313499m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 91,
    Value = 
new System.Decimal[4]
{
0.330665754037195m,
0.971042432376558m,
0.51380942579059m,
0.763390708670419m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 92,
    Value = 
new System.Decimal[3]
{
0.24964187925207m,
0.716664379661956m,
0.655034124054485m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 53,
    Value = 
new System.Decimal[4]
{
0.575735672662532m,
0.971846234328715m,
0.864343986122734m,
0.17531927363831m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 95,
    Value = 
new System.Decimal[4]
{
0.611333636205389m,
0.731576839019255m,
0.822367676610624m,
0.56588256710046m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.222627265651545m,
0.531152633444305m,
0.643090402430897m,
},
},
            new DecimalnumericArray1M
{
    Id = 102,
    Value = 
new System.Decimal[3]
{
0.390835200290182m,
0.00167804598335197m,
0.654359621518807m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.70633573883778m,
0.401867861763596m,
0.880099327409259m,
0.804167482005006m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.733798941483763m,
0.923438401544169m,
0.675566714339514m,
0.248590820171976m,
},
},
            new DecimalnumericArray1M
{
    Id = 108,
    Value = 
new System.Decimal[3]
{
0.913747051864276m,
0.878683127235771m,
0.728175477071715m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 112,
    Value = 
new System.Decimal[4]
{
0.626119783637102m,
0.63329354878485m,
0.348416647098405m,
0.600134399434424m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.929003680295836m,
0.572891134738138m,
0.227429242055158m,
0.9069449978229m,
},
    NullableValue = 
new System.Decimal[4]
{
0.261315417802666m,
0.406698562912398m,
0.878797947513595m,
0.0505760816747749m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 119,
    Value = 
new System.Decimal[3]
{
0.0439659557107212m,
0.098984322332437m,
0.930265940629332m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 128,
    Value = 
new System.Decimal[3]
{
0.806610672747987m,
0.99282851013289m,
0.166686071795572m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 74,
    Value = 
new System.Decimal[3]
{
0.546057960106476m,
0.553369118864965m,
0.686818900335634m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 129,
    Value = 
new System.Decimal[3]
{
0.34564367195677m,
0.490298514801843m,
0.47418984919898m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.240216329775207m,
0.0234446936629873m,
0.67387635728165m,
0.211592894945217m,
},
},
            new DecimalnumericArray1M
{
    Id = 135,
    Value = 
new System.Decimal[3]
{
0.625291842903259m,
0.395349001556036m,
0.408953783773314m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 80,
    Value = 
new System.Decimal[4]
{
0.403428854951258m,
0.20511068412105m,
0.139021183453039m,
0.776652924425035m,
},
    NullableValue = 
new System.Decimal[4]
{
0.342457260508288m,
0.868706030347645m,
0.307283387031079m,
0.805032539383925m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 138,
    Value = 
new System.Decimal[4]
{
0.308222291546465m,
0.567740585404593m,
0.842791611070533m,
0.677948983246295m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 141,
    Value = 
new System.Decimal[4]
{
0.943201083326485m,
0.885075630512583m,
0.377664006232424m,
0.336231358773054m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 81,
    Value = 
new System.Decimal[3]
{
0.322966018679837m,
0.249456756603612m,
0.76950854259617m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 150,
    Value = 
new System.Decimal[4]
{
0.459185826056826m,
0.992493626279991m,
0.650637501723257m,
0.0979062947239324m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.197062272864905m,
0.478436787760503m,
0.92562539020809m,
0.0968284221240648m,
},
},
            new DecimalnumericArray1M
{
    Id = 153,
    Value = 
new System.Decimal[4]
{
0.39591416029059m,
0.411360787895261m,
0.99416739929051m,
0.465192925743482m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 85,
    Value = 
new System.Decimal[3]
{
0.0651622591644234m,
0.898396500512428m,
0.108651042112578m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.153242493020537m,
0.323061286828898m,
0.459490009387037m,
0.482366944571457m,
},
},
            new DecimalnumericArray1M
{
    Id = 162,
    Value = 
new System.Decimal[4]
{
0.568141722174623m,
0.790865547232471m,
0.204184201693103m,
0.236017748938824m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 167,
    Value = 
new System.Decimal[3]
{
0.205716972866589m,
0.969672154514316m,
0.0627830517094938m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 90,
    Value = 
new System.Decimal[3]
{
0.96907436780497m,
0.993850064760868m,
0.593599704737375m,
},
    NullableValue = 
new System.Decimal[4]
{
0.744696392847219m,
0.293791290743444m,
0.314655371433035m,
0.240161369771632m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.88053529078172m,
0.507363532431302m,
0.282910860009356m,
0.64256033693384m,
},
},
            new DecimalnumericArray1M
{
    Id = 175,
    Value = 
new System.Decimal[3]
{
0.20665516047718m,
0.609374309499198m,
0.460650106117138m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0933432446558738m,
0.678668618686763m,
0.257453200169546m,
},
},
            new DecimalnumericArray1M
{
    Id = 179,
    Value = 
new System.Decimal[3]
{
0.399563613810544m,
0.216336745002905m,
0.872650846020898m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 95,
    Value = 
new System.Decimal[3]
{
0.236833486504409m,
0.737333336760975m,
0.196102127135207m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 187,
    Value = 
new System.Decimal[3]
{
0.930368061890954m,
0.79525277917979m,
0.96271692478969m,
},
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.407089564870775m,
0.457708698204522m,
0.105871870195043m,
0.527216089102037m,
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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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
new System.Decimal[4]
{
0.11575485687991m,
0.80498922907039m,
0.313925519333925m,
0.964052868194808m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.123088984220139m,
0.411489193770535m,
0.869487904199684m,
}));
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
0.0777909039226543m,
0.982180555046056m,
0.362437559844168m,
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 25, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 32, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[32],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 75, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 13))
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 175, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[34], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                DecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                DecimalnumericArray1M.AssertModel(models[0],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[29],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[30],_testData[34], false);
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

