

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.717705325659629m,

0.486316425852066m,

0.474180940438911m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.509088493159918m,

0.5790008306937m,

0.643695323446477m,

},
},
            new DecimalnumericArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.135536432401909m,

0.0209186832387134m,

0.21720880058926m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.429196498317225m,

0.28831540269671m,

0.209866732262555m,

0.488105507627965m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.128452547446423m,

0.350040379868704m,

0.349572027659822m,

0.086948254762884m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.08492926866338m,

0.103658947636574m,

0.940634433211644m,

},
},
            new DecimalnumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.406525051404011m,

0.528570269805907m,

0.19352005460618m,

0.290666731737684m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.307220865944332m,

0.271553786588663m,

0.476628728483485m,

},
},
            new DecimalnumericArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0850489038780742m,

0.253022962444352m,

0.581893276074099m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.586389783813646m,

0.661777187208208m,

0.283218367070256m,

0.965709493169178m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.389807619052438m,

0.988305096181695m,

0.849613932987742m,

0.152336980972294m,

},
},
            new DecimalnumericArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.676202360101473m,

0.800516433484746m,

0.542925240842644m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.42027881867265m,

0.577243981772079m,

0.16513462417918m,

},
},
            new DecimalnumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.638405668404218m,

0.636063077971183m,

0.264451802679613m,

0.0512448275953371m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.795648284266854m,

0.64410718595952m,

0.0899681906669179m,

0.994648473443997m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.456176199003941m,

0.297282443799246m,

0.918795548786385m,

0.155889584392857m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.441664408061508m,

0.283216929016651m,

0.0293508335228361m,

},
},
            new DecimalnumericArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0570762459190793m,

0.777318046885874m,

0.741272791891986m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.564741204323011m,

0.0168477539360733m,

0.392949638116543m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.750155417143399m,

0.847899174395328m,

0.944350803092969m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.993621660541776m,

0.538107223823932m,

0.383613899038224m,

0.861488434638928m,

},
},
            new DecimalnumericArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.921625440640211m,

0.624672890261481m,

0.545656787748281m,

0.459922894658414m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.725062572961556m,

0.543539600670368m,

0.0823640187520844m,

0.745331013413867m,

},
},
            new DecimalnumericArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.423808443674381m,

0.725306988895968m,

0.119368981984166m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.865166138474812m,

0.122002091187281m,

0.36220761111892m,

0.454199527323151m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.12851605622572m,

0.956551745849274m,

0.716407039260034m,

},
},
            new DecimalnumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.783181639250457m,

0.361590994247879m,

0.161068347273289m,

0.247417879078592m,

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
0.714596771035898m,

0.36760923555495m,

0.737267659431271m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.168271388709378m,

0.753144517990543m,

0.845294050235542m,

0.284939896357362m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.410605951805279m,

0.135099736047625m,

0.839032726999683m,

0.095097221078397m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.315089757124674m,

0.0201384351323651m,

0.0188131944792916m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.779295924310143m,

0.400233786326158m,

0.0289393010121184m,

0.359691768426616m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.222892674849776m,

0.653061681287929m,

0.987028032403042m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.119587467922331m,

0.870671734756026m,

0.907781934490537m,

0.56573234315639m,

},
},
            new DecimalnumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.697681129694845m,

0.296996910290856m,

0.740921035782688m,

0.182360163222965m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.131674140782647m,

0.018838337269955m,

0.534231132269954m,

0.823044535858087m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.351187735612934m,

0.185073035713925m,

0.648442950893996m,

0.282946086535308m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.532443737691285m,

0.16240119187389m,

0.660238181088352m,

0.127838536023273m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.901076264379637m,

0.328198371671285m,

0.688852698285719m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.250500436122764m,

0.915876714557152m,

0.0940666015251923m,

0.216492822487688m,

},
},
            new DecimalnumericArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.833545459982033m,

0.841110889800406m,

0.00356413946727852m,

0.709283105335479m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0389297520661848m,

0.508029259871025m,

0.889055383625048m,

},
},
            new DecimalnumericArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.530368488861848m,

0.647467836473808m,

0.0741776116633299m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.916581001081045m,

0.366269418099722m,

0.939457529354517m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.422812847298697m,

0.507417331146159m,

0.81401032238272m,

0.0137843725810314m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.351476795217212m,

0.556959991963129m,

0.444233868822822m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.907447330895434m,

0.860303920782788m,

0.492722441520303m,

0.0371331251194771m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.492027160602683m,

0.0722236909532795m,

0.384558323324133m,

0.517216318212348m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0922740756683185m,

0.0454489833027341m,

0.225851278201964m,

0.560033114879443m,

},
},
            new DecimalnumericArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.385799096460034m,

0.203584368854794m,

0.389067179201995m,

0.655302373385621m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71302584915232m,

0.55591660891312m,

0.846965599783691m,

0.332546419044306m,

},
},
            new DecimalnumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88377527633082m,

0.335583045603669m,

0.397608839405043m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.932989710227023m,

0.462402987000753m,

0.209686996413459m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.364519270488297m,

0.0392682804574563m,

0.109771843955641m,

0.983807245074716m,

},
},
            new DecimalnumericArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.183941080082464m,

0.693108703026182m,

0.0815706269793651m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.876940120239427m,

0.209621415380695m,

0.906106007247819m,

0.22845822012299m,

},
},
            new DecimalnumericArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.676819868063487m,

0.809345737899521m,

0.9256803249062m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.43444522631299m,

0.0319269560246702m,

0.657467407762429m,

0.6248252202198m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.849168664332555m,

0.153905763564807m,

0.0494540969360319m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.170779225891679m,

0.222466091453915m,

0.393263998914689m,

},
},
            new DecimalnumericArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.470334874573701m,

0.263983837046688m,

0.852060906538283m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428255958296304m,

0.834900113296709m,

0.769186166244707m,

},
},
            new DecimalnumericArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.765042764141262m,

0.997838354037651m,

0.06301492575266m,

0.383317788933781m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.663871976623574m,

0.971982690930182m,

0.0386900926624437m,

0.0851732389575939m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.556438592710851m,

0.597651290472779m,

0.846215553907033m,

0.186623238932813m,

},
},
            new DecimalnumericArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.758054702464417m,

0.0205340824895826m,

0.380846335091722m,

0.298924247678979m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.460172952293671m,

0.484501778865784m,

0.958095760859156m,

},
},
            new DecimalnumericArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.627726408032346m,

0.0406675027149932m,

0.0390417979287967m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.788320697831311m,

0.504518946028674m,

0.431906977830625m,

0.0894366576073714m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.489306068393725m,

0.283652721914469m,

0.640328958231102m,

0.425239537678937m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.796968370684256m,

0.752691611731761m,

0.458262839652643m,

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
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
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 78, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 63, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 160, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 169, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 153, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DecimalnumericArray2M.AssertModel(models[0],_testData[6], false);DecimalnumericArray2M.AssertModel(models[1],_testData[7], false);DecimalnumericArray2M.AssertModel(models[2],_testData[8], false);DecimalnumericArray2M.AssertModel(models[3],_testData[9], false);DecimalnumericArray2M.AssertModel(models[4],_testData[10], false);DecimalnumericArray2M.AssertModel(models[5],_testData[11], false);DecimalnumericArray2M.AssertModel(models[6],_testData[12], false);DecimalnumericArray2M.AssertModel(models[7],_testData[13], false);DecimalnumericArray2M.AssertModel(models[8],_testData[14], false);DecimalnumericArray2M.AssertModel(models[9],_testData[15], false);DecimalnumericArray2M.AssertModel(models[10],_testData[16], false);DecimalnumericArray2M.AssertModel(models[11],_testData[17], false);DecimalnumericArray2M.AssertModel(models[12],_testData[18], false);DecimalnumericArray2M.AssertModel(models[13],_testData[19], false);DecimalnumericArray2M.AssertModel(models[14],_testData[20], false);DecimalnumericArray2M.AssertModel(models[15],_testData[21], false);DecimalnumericArray2M.AssertModel(models[16],_testData[22], false);DecimalnumericArray2M.AssertModel(models[17],_testData[23], false);DecimalnumericArray2M.AssertModel(models[18],_testData[24], false);DecimalnumericArray2M.AssertModel(models[19],_testData[25], false);DecimalnumericArray2M.AssertModel(models[20],_testData[26], false);DecimalnumericArray2M.AssertModel(models[21],_testData[27], false);DecimalnumericArray2M.AssertModel(models[22],_testData[28], false);DecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
DecimalnumericArray2M.AssertModel(models[0],_testData[20], false);DecimalnumericArray2M.AssertModel(models[1],_testData[21], false);DecimalnumericArray2M.AssertModel(models[2],_testData[22], false);DecimalnumericArray2M.AssertModel(models[3],_testData[23], false);DecimalnumericArray2M.AssertModel(models[4],_testData[24], false);DecimalnumericArray2M.AssertModel(models[5],_testData[25], false);DecimalnumericArray2M.AssertModel(models[6],_testData[26], false);DecimalnumericArray2M.AssertModel(models[7],_testData[27], false);DecimalnumericArray2M.AssertModel(models[8],_testData[28], false);DecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
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

